import { CustomerOrder, OrderDetail } from './../../models/OrderModels';
import { OrderService } from '../../services/order/OrderService';
import { Component, OnInit, OnChanges, SimpleChanges } from '@angular/core';


@Component({
    selector: 'app-order',
    templateUrl: './order.component.html',
    styles: [`
        .space {
            margin-top: 24px;
        }
    `]
})

export class OrderComponent implements OnInit {
    customerOrders: CustomerOrder[];
    customerSelected: CustomerOrder;
    detailSelected: OrderDetail[];
    isDetailSelected = false;
    constructor(
        private orderService: OrderService
    ) {}


    ngOnInit(): void {
        this.orderService.getOrders().subscribe(
            data => this.customerOrders = data
        );
    }

    onListClick(customer: CustomerOrder): void {
        this.customerSelected = customer;
        this.detailSelected = [];
        this.isDetailSelected = false;
    }
}
