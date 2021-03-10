using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class EmployeesController
    {
        public List<Employee> ListAllEmployees()
        {
            using(var context = new WestWindContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}
