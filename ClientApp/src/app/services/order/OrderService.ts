import { CustomerOrder } from './../../models/OrderModels';
import { Injectable } from '@angular/core';
import { orderData } from '../../mock/orderData';
import { of, Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})

export class OrderService {
    private orders: CustomerOrder[] = orderData;

    constructor() {}

    getOrders(): Observable<CustomerOrder[]> {
        return of(this.orders);
    }
}
