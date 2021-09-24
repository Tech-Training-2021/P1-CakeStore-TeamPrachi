using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Mappers
{
    public class FlavourMapper
    {
        public static MVCProjectDemo.Models.Flavour Map(Data.Entities.Flavour cake)
        {
            return new MVCProjectDemo.Models.Flavour()
            {
                FlavourID = cake.FlavourID,
                FlavourName = cake.FlavourName
            };
        }
        public static MVCProjectDemo.Models.FlavourViewModel MapViewModel(Data.Entities.Flavour cake)
        {
            return new MVCProjectDemo.Models.FlavourViewModel()
            {
                FlavourID = (int)cake.FlavourID,
                FlavourName = cake.FlavourName
            };
        }
        public static Data.Entities.Flavour Map(MVCProjectDemo.Models.FlavourViewModel cake)
        {
            return new Data.Entities.Flavour()
            {
                FlavourID = cake.FlavourID,
                FlavourName = cake.FlavourName
            };
        }
    }
}