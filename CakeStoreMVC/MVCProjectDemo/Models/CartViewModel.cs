using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Models
{
    public class CartViewModel
    {
        public string ItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
        public string ImgUrl { get; set; }
        public string FlavourTypeName { get; set; }
    }
}