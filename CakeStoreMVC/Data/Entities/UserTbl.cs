namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserTbl")]
    public partial class UserTbl
    {
        [StringLength(50)]
        public string fullName { get; set; }

        [StringLength(50)]
        public string dob { get; set; }

        [StringLength(50)]
        public string contactNo { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [StringLength(50)]
        public string city { get; set; }

        [StringLength(50)]
        public string pincode { get; set; }

        public string fullAddress { get; set; }

        [Key]
        [StringLength(50)]
        public string userId { get; set; }

        [StringLength(50)]
        public string password { get; set; }
    }
}
