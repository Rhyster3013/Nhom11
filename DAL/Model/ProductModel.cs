using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Model
{
    public partial class ProductModel : DbContext
    {
        public ProductModel()
            : base("name=ProductModel")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.BillID)
                .IsUnicode(false);

            modelBuilder.Entity<Bill>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.BillID)
                .IsUnicode(false);

            modelBuilder.Entity<BillDetail>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeID)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Accounts)
                .WithOptional(e => e.Employee)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.TypeID)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);

            modelBuilder.Entity<ProductType>()
                .Property(e => e.TypeID)
                .IsUnicode(false);

            modelBuilder.Entity<Provider>()
                .Property(e => e.ProviderID)
                .IsUnicode(false);
        }
    }
}
