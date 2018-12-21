using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_1_2
{
    public class Order
    {
    private int id {get; set;}

    private DateTime OrderDate {get; set;}

    private string OrderNumber {get; set;}

    private ICollection Items {get; set;} 

    public Order(int id, DateTime OrderDate, string OrderNumber, ICollection Items) {
        this.id = id;
        this.OrderDate = OrderDate;
        this.OrderNumber = OrderNumber;
        this.Items = Items;
    } 
    }
}