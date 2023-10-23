namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(3)]
        public string AccountName { get; set; }

        [StringLength(8)]
        public string Password { get; set; }

        public int? Authority { get; set; }

        [StringLength(3)]
        public string EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
