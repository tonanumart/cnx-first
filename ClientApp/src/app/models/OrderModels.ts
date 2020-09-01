export interface CustomerOrder {
    customerName: string;
    orders: Array<Order>;
}

export interface Order {
    orderId: string;
    orderDate: string | Date;
    details: Array<OrderDetail>;
}


export interface OrderDetail {
    productName: string;
    quantity: number;
    unitPrice: number;
}
