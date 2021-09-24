using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProjectDemo.Models;

namespace MVCProjectDemo.Mappers
{
    public class OrderMapper
    {
        public static MVCProjectDemo.Models.OrderModel Map2(Data.Entities.Order cake)
        {
            return new MVCProjectDemo.Models.OrderModel()
            {
                OrderID = cake.OrderID,
                UserId = cake.UserId,
                FlavourTypeID = cake.FlavourTypeID,
                Price = cake.Price,
                Quantity = cake.Quantity,
                ImgUrl = cake.ImgUrl,
                FlavourID = cake.FlavourID
            };
        }
        
        public static Data.Entities.Order Map(MVCProjectDemo.Models.OrderModel cake)
        {
            return new Data.Entities.Order()
            {
                UserId = cake.UserId,
                FlavourTypeID = cake.FlavourTypeID,
                Price = cake.Price,
                Quantity = cake.Quantity,
                ImgUrl = cake.ImgUrl,
                FlavourID = cake.FlavourID
            };
        }

        public static MVCProjectDemo.Models.OrderModel  Map(Data.Entities.FlavourType cake,string session)
        {
            return new MVCProjectDemo.Models.OrderModel()
            {
             FlavourTypeID=cake.FlavourTypeID,
             UserId= session,
             Price =(decimal)cake.Price,
             Quantity=1,
             ImgUrl=cake.ImgUrl,
             FlavourID=cake.FlavourID,
            };
        }

    }
}