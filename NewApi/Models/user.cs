namespace NewApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        [Key]
        public int uid { get; set; }

        [StringLength(50)]
        public string firstname { get; set; }

        [StringLength(50)]
        public string lastname { get; set; }

        [StringLength(50)]
        public string middlename { get; set; }

        [StringLength(50)]
        public string fullname { get; set; }

        [Required]
        [StringLength(50)]
        public string emailid { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dob { get; set; }

        public string phone { get; set; }

        public int? mobile { get; set; }

        [StringLength(50)]
        public string address { get; set; }

        [StringLength(50)]
        public string state { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        [StringLength(50)]
        public string role { get; set; }

        public bool? sendemail { get; set; }

        public string Status { get; set; }
    }
}
