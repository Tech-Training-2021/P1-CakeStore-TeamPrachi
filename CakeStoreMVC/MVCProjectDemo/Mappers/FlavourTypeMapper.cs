using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Mappers
{
    public class Mapper
    {
        public static MVCProjectDemo.Models.FlavourType Map(Data.Entities.FlavourType cake)
        {
            return new MVCProjectDemo.Models.FlavourType()
            {
                FlavourTypeID = cake.FlavourTypeID,
                FlavourID = cake.Flavour.FlavourName,
                FlavourTypeName = cake.FlavourTypeName,
                Price = cake.Price,
                AvailableQuantity = cake.AvailableQuantity,
                ImgUrl=cake.ImgUrl
            };
        }
        public static MVCProjectDemo.Models.FlavourTypeViewModel MapViewModel(Data.Entities.FlavourType cake)
        {
            return new MVCProjectDemo.Models.FlavourTypeViewModel()
            {
                FlavourTypeID = cake.FlavourTypeID,
                FlavourID = (int)cake.FlavourID,
                FlavourTypeName = cake.FlavourTypeName,
                Price = cake.Price,
                AvailableQuantity = cake.AvailableQuantity,
                ImgUrl = cake.ImgUrl
            };
        }
        public static Data.Entities.FlavourType Map(MVCProjectDemo.Models.FlavourTypeViewModel cake)
        {
            return new Data.Entities.FlavourType()
            {
                FlavourID = cake.FlavourID,
                FlavourTypeName = cake.FlavourTypeName,
                Price = cake.Price,
                AvailableQuantity = cake.AvailableQuantity,
                ImgUrl=cake.ImgUrl
            };
        }
    }
}