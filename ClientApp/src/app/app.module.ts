import { OrderListComponent } from './components/order-list/order-list.component';
import { OrderSelectComponent } from './components/order-select/order-select.component';
import { OrderCustomerListComponent } from './components/order-customer-list/order-customer-list.component';
import { HomeComponent } from './components/home/home.component';
import { OrderComponent } from './components/order/order.component';
import { TopBarComponent } from './components/top-bar/top-bar.component';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { NgModule } from '@angular/core';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent,
    TopBarComponent,
    OrderComponent,
    HomeComponent,
    OrderCustomerListComponent,
    OrderSelectComponent,
    OrderListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
