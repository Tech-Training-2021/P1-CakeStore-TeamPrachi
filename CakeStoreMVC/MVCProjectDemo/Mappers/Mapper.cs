using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Models
{
    public class Mapper
    {
        public static MVCProjectDemo.Models.Cake Map(Data.Entities.FlavourType cake)
        {
            return new MVCProjectDemo.Models.Cake()
            {
                FlavourTypeID = cake.FlavourTypeID,
                FlavourID = cake.FlavourID,
                FlavourTypeName = cake.FlavourTypeName,
                Price = cake.Price,
                AvailableQuantity = cake.AvailableQuantity
            };
        }
    }
}