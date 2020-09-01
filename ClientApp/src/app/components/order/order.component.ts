import { CustomerOrder } from './../../models/OrderModels';
import { OrderService } from '../../services/order/OrderService';
import { Component, OnInit } from '@angular/core';


@Component({
    selector: 'app-order',
    templateUrl: './order.component.html',
    styles: [`
    `]
})

export class OrderComponent implements OnInit {
    customerOrders: CustomerOrder[];
    constructor(
        private orderService: OrderService
    ) {}

    ngOnInit(): void {
        this.orderService.getOrders().subscribe(
            data => this.customerOrders = data
        );
    }
}
