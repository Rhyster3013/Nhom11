using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllProvider
    {
        ProductModel model = new ProductModel();

        public List<Provider> GetAll()
        {
            return model.Providers.ToList();
        }
    }
}
