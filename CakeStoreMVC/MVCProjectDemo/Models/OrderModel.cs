using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Models
{
    public class OrderModel
    {
        public int OrderID { get; set; }

       
        public string UserId { get; set; }

        public int FlavourTypeID { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

       
        public string ImgUrl { get; set; }

        public int FlavourID { get; set; }

    }
}