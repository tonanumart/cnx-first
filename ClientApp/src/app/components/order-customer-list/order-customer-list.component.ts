import { CustomerOrder } from './../../models/OrderModels';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
    selector: 'app-order-customer-list',
    templateUrl: './order-customer-list.component.html',
    styles: [`
        .list-group-item {
            cursor: pointer;
        }
    `]
})

export class OrderCustomerListComponent implements OnInit {
    @Input() customerOrders: Array<CustomerOrder>;
    @Output() listClick = new EventEmitter();
    currentIndex: number;
    constructor() {}

    ngOnInit(): void {}

    onClick(index: number, customer: CustomerOrder): void {
        this.currentIndex = index;
        this.listClick.emit(customer);
    }
}
