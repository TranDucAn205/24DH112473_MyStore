using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _24DH112473_MyStore.Models.ViewModel
{
    public class OrderDetailcs
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        //public decimal TotalPrice { get; set; }
        //[NotMapped]
        //public decimal LineTotal => Quantity * UnitPrice;
        public Nullable<decimal> TotalPrice { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}