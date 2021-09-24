using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCProjectDemo.Models
{
    public class OrderHistory
    {
        public int OrderHistoryID { get; set; }

        [DisplayName("Name")]
        public string UserId { get; set; }
        [DisplayName("Flavour Name")]

        public int FlavourTypeID { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        
        public string ImgUrl { get; set; }
        [DisplayName("Flavour")]

        public string FlavourID { get; set; }

    }
}