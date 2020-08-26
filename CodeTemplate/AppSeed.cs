using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using AutoMapper;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using Service.Implements;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Web.Handler;

namespace Web.App_Start
{
    public class AppSeed
    {
        private static void RegisterRepoAndService(ContainerBuilder builder)
        {

            var service = Assembly.GetAssembly(typeof(AccountService));
            builder.RegisterAssemblyTypes(service)
                .Where(t => t.Name.EndsWith("Service"))
                .InstancePerRequest()
                .AsImplementedInterfaces()
                .PropertiesAutowired();

            RegisterAutoMapper(builder);

            //remove when project has repository patter
            //builder.RegisterAssemblyTypes(dataAccess)
            // .Where(t => t.Name.EndsWith("Repo"))
            // .AsImplementedInterfaces()
            // .PropertiesAutowired()
            // .InstancePerRequest();

            //remove when use ef or database inject 
            //builder.RegisterType<AppEntities>().InstancePerRequest();
            //builder.Register(x => SqlFactory.NewConnection())
            //        .As<IDbConnection>()
            //        .InstancePerRequest()
            //        .PropertiesAutowired();
        }
        public static void RegisterAutoFac(HttpConfiguration config, IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterWebApiFilterProvider(config);
            RegisterRepoAndService(builder);
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);  //Set the WebApi DependencyResolver
            config.DependencyResolver = GlobalConfiguration.Configuration.DependencyResolver;
            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();
            app.UseAutofacWebApi(config);
        }

        public static void RegisterStaticFile(IAppBuilder app)
        {
            string root = AppDomain.CurrentDomain.BaseDirectory;
            app.UseCors(CorsOptions.AllowAll);
            var physicalFileSystem = new PhysicalFileSystem(Path.Combine(root, "wwwroot"));
            var options = new FileServerOptions
            {
                RequestPath = PathString.Empty,
                EnableDefaultFiles = true,
                FileSystem = physicalFileSystem
            };
            options.StaticFileOptions.FileSystem = physicalFileSystem;
            options.StaticFileOptions.ServeUnknownFileTypes = false;
            app.UseFileServer(options);
        }

        public static void RegisterAutoMapper(ContainerBuilder builder)
        {
            //snake camel to pascal
            var profileAssembly = Assembly.GetAssembly(typeof(AccountProfile));
            var MapperConfiguration = new MapperConfiguration(cfg =>
            {
                // Scan for all profiles in an assembly
                cfg.AddMaps(profileAssembly);
                //cfg.AddProfile<Handler.AccountProfile>();
            });
            builder.Register(x => new Mapper(MapperConfiguration))
                .As<IMapper>()
                .PropertiesAutowired()
                .SingleInstance();
        }
    }
}