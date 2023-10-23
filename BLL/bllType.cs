using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllType
    {
        ProductModel model = new ProductModel();

        public List<ProductType> GetAll()
        {
            return model.ProductTypes.ToList();
        }
    }
}
