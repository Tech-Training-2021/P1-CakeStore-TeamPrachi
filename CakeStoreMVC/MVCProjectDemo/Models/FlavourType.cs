using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MVCProjectDemo.Models
{
    public class FlavourType
    {
        public int FlavourTypeID { get; set; }

        [DisplayName("Flavour")]
        public string FlavourID { get; set; }
        
        public string FlavourTypeName { get; set; }

        public int? Price { get; set; }

        public int? AvailableQuantity { get; set; }
        public string ImgUrl { get; set; }
    }
}