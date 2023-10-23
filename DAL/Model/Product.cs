namespace DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            BillDetails = new HashSet<BillDetail>();
        }

        [StringLength(3)]
        public string ProductID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(3)]
        public string TypeID { get; set; }

        [StringLength(3)]
        public string ProviderID { get; set; }

        public DateTime? Date { get; set; }

        public int? PriceIn { get; set; }

        public int? PriceOut { get; set; }

        public int? Quantity { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillDetail> BillDetails { get; set; }

        public virtual Provider Provider { get; set; }

        public virtual ProductType ProductType { get; set; }
    }
}
