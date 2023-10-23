using DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllBillDetail
    {
        public List<BillDetail> GetList()
        {
            ProductModel model = new ProductModel();
            return model.BillDetails.ToList();
        }

        public BillDetail findID(string name, ProductModel model)
        {
            return model.BillDetails.FirstOrDefault(p => p.ProductID == name);
        }

        public void Add(BillDetail p, ProductModel model)
        {
            model.BillDetails.AddOrUpdate(p);
            model.SaveChanges();
        }

        public void Del(BillDetail p, ProductModel model)
        {
            var kiemtra = model.BillDetails.Local.FirstOrDefault(st => st.ProductID == p.ProductID);
            if (kiemtra != null)
            {
                model.Entry(kiemtra).State = EntityState.Detached;
            }

            model.BillDetails.Add(p);
            model.Entry(p).State = EntityState.Deleted;
            model.SaveChanges();
        }
    }
}
