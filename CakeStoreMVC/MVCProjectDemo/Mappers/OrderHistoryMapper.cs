using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Mappers
{
    public class OrderHistoryMapper
    {
        public static MVCProjectDemo.Models.OrderHistory Map(Data.Entities.OrderHistory cake)
        {
            return new MVCProjectDemo.Models.OrderHistory()
            {
                OrderHistoryID = cake.OrderHistoryID,
                UserId = cake.UserId,
                FlavourTypeID =cake.FlavourTypeID,
                Price = cake.Price,
                Quantity = cake.Quantity,
                ImgUrl = cake.ImgUrl,
                FlavourID = cake.Flavour.FlavourName
            };
        }
    }
}