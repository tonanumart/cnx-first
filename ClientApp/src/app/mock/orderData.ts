import { CustomerOrder } from './../models/OrderModels';

export const orderData: CustomerOrder[] = [
    {
        customerName: 'Siwat Jirawiwatpat',
        orders: [
            {
                orderId: 'Q001',
                orderDate: '2009-01-05T00:00:00',
                details: [
                    {
                        productName: 'Yakult',
                        quantity: 3,
                        unitPrice: 6
                    },
                    {
                        productName: 'Nesvita',
                        quantity: 2,
                        unitPrice: 10
                    },
                    {
                        productName: 'Lays',
                        quantity: 1,
                        unitPrice: 20
                    }
                ]
            },
            {
                orderId: 'Q002',
                orderDate: '2020-06-22T00:00:00',
                details: [
                    {
                        productName: 'Testo',
                        quantity: 10,
                        unitPrice: 14
                    },
                    {
                        productName: 'CoCoCruch',
                        quantity: 10,
                        unitPrice: 5
                    },
                    {
                        productName: 'Burger',
                        quantity: 3,
                        unitPrice: 20
                    }
                ]
            },
            {
                orderId: 'Q003',
                orderDate: '2009-01-05T00:00:00',
                details: [
                    {
                        productName: 'Yakult',
                        quantity: 20,
                        unitPrice: 6
                    },
                    {
                        productName: 'Nesvita',
                        quantity: 9,
                        unitPrice: 10
                    },
                    {
                        productName: 'Lays',
                        quantity: 15,
                        unitPrice: 20
                    }
                ]
            }
        ]
    },
    {
        customerName: 'Kittipat Sutthiniam',
        orders: [
            {
                orderId: 'A001',
                orderDate: '2018-11-05T00:00:00',
                details: [
                    {
                        productName: 'Yakult',
                        quantity: 20,
                        unitPrice: 6
                    },
                    {
                        productName: 'Lays',
                        quantity: 6,
                        unitPrice: 10
                    },
                    {
                        productName: 'Lays',
                        quantity: 1,
                        unitPrice: 20
                    }
                ]
            },
            {
                orderId: 'A002',
                orderDate: '2020-06-22T00:00:00',
                details: [
                    {
                        productName: 'Testo',
                        quantity: 10,
                        unitPrice: 14
                    },
                    {
                        productName: 'CoCoCruch',
                        quantity: 10,
                        unitPrice: 5
                    },
                    {
                        productName: 'Burger',
                        quantity: 3,
                        unitPrice: 20
                    }
                ]
            },
            {
                orderId: 'A003',
                orderDate: '2009-01-05T00:00:00',
                details: [
                    {
                        productName: 'Yakult',
                        quantity: 3,
                        unitPrice: 6
                    },
                    {
                        productName: 'Nesvita',
                        quantity: 2,
                        unitPrice: 10
                    },
                    {
                        productName: 'Lays',
                        quantity: 1,
                        unitPrice: 20
                    }
                ]
            }
        ]
    },
    {
        customerName: 'TestName TestSurname',
        orders: [
            {
                orderId: 'F001',
                orderDate: '2018-11-05T00:00:00',
                details: [
                    {
                        productName: 'Yakult',
                        quantity: 33,
                        unitPrice: 6
                    },
                    {
                        productName: 'Lays',
                        quantity: 56,
                        unitPrice: 10
                    },
                    {
                        productName: 'Lays',
                        quantity: 44,
                        unitPrice: 20
                    }
                ]
            },
            {
                orderId: 'F002',
                orderDate: '2020-06-22T00:00:00',
                details: [
                    {
                        productName: 'Testo',
                        quantity: 10,
                        unitPrice: 14
                    },
                    {
                        productName: 'Burger',
                        quantity: 3,
                        unitPrice: 20
                    }
                ]
            },
            {
                orderId: 'F003',
                orderDate: '2009-01-05T00:00:00',
                details: [
                    {
                        productName: 'Yakult',
                        quantity: 3,
                        unitPrice: 6
                    }
                ]
            }
        ]
    }
];
