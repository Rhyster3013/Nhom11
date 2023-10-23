namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string BillID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string ProductID { get; set; }

        public int? Quantity { get; set; }

        public int? PricePerItem { get; set; }

        public int? TotalPricePerItem { get; set; }

        public virtual Bill Bill { get; set; }

        public virtual Product Product { get; set; }
    }
}
