using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace BLL
{
    public class bllProduct
    {
        public List<Product> GetList()
        {
            ProductModel model = new ProductModel();
            return model.Products.ToList();
        }

        public List<Product> findName(string name, ProductModel ctx)
        {
            var result = from s in ctx.Products
                         where s.Name.Contains(name)
                         select s;
            return result.ToList();
        }

        public List<Product> findProv(string name, ProductModel ctx)
        {
            var result = from s in ctx.Products
                         where s.ProviderID.Contains(name)
                         select s;
            return result.ToList();
        }

        public List<Product> findType(string name, ProductModel ctx)
        {
            var result = from s in ctx.Products
                         where s.TypeID.Contains(name)
                         select s;
            return result.ToList();
        }

        public Product findID(string name, ProductModel model)
        {
            return model.Products.FirstOrDefault(p => p.ProductID == name);
        }

        public void Add(Product p, ProductModel model)
        {
            model.Products.AddOrUpdate(p);
            model.SaveChanges();
        }

        public void Del(Product p, ProductModel model)
        {
            var kiemtra = model.Products.Local.FirstOrDefault(st => st.ProductID == p.ProductID);
            if (kiemtra != null)
            {
                model.Entry(kiemtra).State = EntityState.Detached;
            }

            model.Products.Add(p);
            model.Entry(p).State = EntityState.Deleted;
            model.SaveChanges();
        }
    }
}
