using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Mappers
{
    public class UserMapper
    {
        public static MVCProjectDemo.Models.User Map(Data.Entities.UserTbl cake)
        {
            return new MVCProjectDemo.Models.User()
            {
                fullName = cake.fullName,
                dob = cake.dob,
                contactNo = cake.contactNo,
                email = cake.email,
                state = cake.state,
                city = cake.city,
                pincode = cake.pincode,
                fullAddress=cake.fullAddress,
                userId=cake.userId,
                password=cake.password
            };
        }
        public static MVCProjectDemo.Models.UserViewModel MapViewModel(Data.Entities.UserTbl cake)
        {
            return new MVCProjectDemo.Models.UserViewModel()
            {
                fullName = cake.fullName,
                dob = cake.dob,
                contactNo = cake.contactNo,
                email = cake.email,
                state = cake.state,
                city = cake.city,
                pincode = cake.pincode,
                fullAddress = cake.fullAddress,
                userId = cake.userId,
                password = cake.password
            };
        }
        public static Data.Entities.UserTbl Map(MVCProjectDemo.Models.UserViewModel cake)
        {
            return new Data.Entities.UserTbl()
            {
                fullName = cake.fullName,
                dob = cake.dob,
                contactNo = cake.contactNo,
                email = cake.email,
                state = cake.state,
                city = cake.city,
                pincode = cake.pincode,
                fullAddress = cake.fullAddress,
                userId = cake.userId,
                password = cake.password
            };
        }
    }
}