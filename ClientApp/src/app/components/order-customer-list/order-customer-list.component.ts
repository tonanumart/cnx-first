import { CustomerOrder } from './../../models/OrderModels';
import { Component, OnInit, Input } from '@angular/core';

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
    currentIndex: number;
    constructor() {}

    ngOnInit(): void {}

    onClick(index: number): void {
        this.currentIndex = index;
    }
}
