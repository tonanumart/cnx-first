import { Component, OnInit, Input, Output, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { Order } from 'src/app/models/OrderModels';

@Component({
    selector: 'app-order-select',
    templateUrl: './order-select.component.html',
    styles: [`
    `]
})

export class OrderSelectComponent implements OnInit, OnChanges {
    @Input() orders: Order[];
    @Output() orderSelected = new EventEmitter();
    orderIdSelected = "";
    constructor() {}

    ngOnInit(): void {}

    
    ngOnChanges(changes: SimpleChanges): void {
        const change = changes.orders;
        if(!!change && !change.firstChange){
            console.log(change.currentValue)
            this.orderIdSelected = "";
        }
        
    }

    selectedDetail(event): void {
        this.orderIdSelected = event;
        this.orderSelected.emit(this.orders.find(
            item => item.orderId === event
        ).details);
    }
}
