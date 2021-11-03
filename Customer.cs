using static LearningC_.ClassBasics;
using System;
using System.Collections.Generic;

namespace LearningC_
{
    public class Customer
    {
       public int Id;
       public string Name;
       readonly public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(string name) : this()
        {
            Name = name;
        }

         public Customer(int id, string name) : this(name)
        {
            Id = id;
            Name = name;
        }

        public void Promote(){

            //Orders = new List<Order>();
            //..
        }

       

        
    }
}