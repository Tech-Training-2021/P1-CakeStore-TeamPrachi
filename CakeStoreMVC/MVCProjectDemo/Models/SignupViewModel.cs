using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCProjectDemo.Models
{
    public class SignupViewModel
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



        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string PasswordUs { get; set; }


        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "RePassword")]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("PasswordUs", ErrorMessage = "Confirm password doesn't match, type agian!")]
        public string RePasswordUs { get; set; }
    }
}