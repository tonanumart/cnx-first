﻿using Autofac;
using Autofac.Integration.WebApi;
using Domain.Database;
using Domain.Interfaces.Service;
using Service.Implements;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Web.App_Start
{
    public class AppSeed
    {
        public static void ConfigAutoFac()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            var service = Assembly.GetAssembly(typeof(SimpleService));
            builder.RegisterAssemblyTypes(service)
                .Where(t => t.Name.EndsWith("Service"))
                .InstancePerRequest()
                .AsImplementedInterfaces()
                .PropertiesAutowired();

            var entities = Assembly.GetAssembly(typeof(ExamsEntities));
            builder.RegisterAssemblyTypes(entities)
                .InstancePerRequest()
                .AsSelf()
                .PropertiesAutowired();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

        }
    }
}