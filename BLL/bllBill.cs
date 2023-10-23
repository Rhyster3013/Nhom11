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
    public class bllBill
    {
        public List<Bill> GetList()
        {
            ProductModel model = new ProductModel();
            return model.Bills.ToList();
        }

        public Bill findID(string name, ProductModel model)
        {
            return model.Bills.FirstOrDefault(p => p.BillID == name);
        }

        public void Add(Bill p, ProductModel model)
        {
            model.Bills.AddOrUpdate(p);
            model.SaveChanges();
        }

        public void Del(Bill p, ProductModel model)
        {
            var kiemtra = model.BillDetails.Local.FirstOrDefault(st => st.BillID == p.BillID);
            if (kiemtra != null)
            {
                model.Entry(kiemtra).State = EntityState.Detached;
            }

            model.Bills.Add(p);
            model.Entry(p).State = EntityState.Deleted;
            model.SaveChanges();
        }
    }
}
