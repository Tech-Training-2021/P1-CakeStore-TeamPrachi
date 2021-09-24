using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Models
{
    public class UserViewModel
    {
        public string fullName { get; set; }

        public string dob { get; set; }

        public string contactNo { get; set; }
        public string email { get; set; }

        public string state { get; set; }

        public string city { get; set; }

        public string pincode { get; set; }

        public string fullAddress { get; set; }

        public string userId { get; set; }

        public string password { get; set; }
    }
}