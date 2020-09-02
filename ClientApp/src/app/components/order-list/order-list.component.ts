import { OrderDetail } from './../../models/OrderModels';
import { Component, OnInit, Input } from '@angular/core';

@Component({
    selector: 'app-order-list',
    templateUrl: './order-list.component.html',
    styles: [`
    `]
})

 export class OrderListComponent implements OnInit {
     @Input() orderDetails: OrderDetail[];
     constructor() {}

     ngOnInit(): void {}
 }
