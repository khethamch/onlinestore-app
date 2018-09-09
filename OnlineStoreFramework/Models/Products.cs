using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStoreFramework.Models
{
    public class Products
    {
        public Products()
        {
            Id = Guid.NewGuid();
            DateTimeStamp = DateTime.Now;
            IsCancelled = false;
        }
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductImage { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsOnSale { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public bool IsCancelled { get; set; }
    }
}