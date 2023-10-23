using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class bllEmployee
    {
        public Employee findID(string name, ProductModel model)
        {
            return model.Employees.FirstOrDefault(p => p.EmployeeID == name);
        }

        public Employee findName(string name, ProductModel model)
        {
            return model.Employees.FirstOrDefault(p => p.Name == name);
        }
    }
}
