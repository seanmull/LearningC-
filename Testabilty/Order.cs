using System;

namespace LearningC_.Testabilty
{
    public class Order
    {
        public int Id { get; set; }
        public float TotalPrice { get; set; }
        public DateTime DatePlaced { get; set; }

        public bool IsShipped { 
            get{ return Shipment != null;
        }
        }
        public Shipment Shipment { get; set; }
    }
}