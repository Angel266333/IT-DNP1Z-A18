using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_1_2
{
    public class OrderItem
    {
        private int id {get; set;}
        private int quantity {get; set;}
        private Order order {get; set;}
        public OrderItem(int id, int quantity, Order order) {
            this.id = id;
            this.quantity = quantity;
            this.order = order;
        } 
    }
}