using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Models
{
    public class Cake
    {
        public int FlavourTypeID { get; set; }

        public int FlavourID { get; set; }
        
        public string FlavourTypeName { get; set; }

        public int? Price { get; set; }

        public int? AvailableQuantity { get; set; }
    }
}