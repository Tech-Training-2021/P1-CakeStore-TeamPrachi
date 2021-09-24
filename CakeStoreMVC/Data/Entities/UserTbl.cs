namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTbl")]
    public partial class UserTbl
    {
        [StringLength(50)]
        [DisplayName("FullName")]
        public string fullName { get; set; }

        [StringLength(50)]
        [DisplayName("DOB")]
        public string dob { get; set; }

        [StringLength(50)]
        [DisplayName("ContactNo.")]
        public string contactNo { get; set; }

        [StringLength(50)]
        [DisplayName("Email")]
        public string email { get; set; }

        [StringLength(50)]
        [DisplayName("State")]
        public string state { get; set; }

        [StringLength(50)]
        [DisplayName("City")]
        public string city { get; set; }

        [StringLength(50)]
        [DisplayName("Pincode")]
        public string pincode { get; set; }
        [DisplayName("Address")]
        public string fullAddress { get; set; }

        [Key]
        [StringLength(50)]
        [DisplayName("UserID")]
        public string userId { get; set; }

        [StringLength(50)]
        [DisplayName("Password")]
        public string password { get; set; }
    }
}
