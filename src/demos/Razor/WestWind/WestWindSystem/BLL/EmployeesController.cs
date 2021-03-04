using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Data;

namespace WestWindSystem.BLL
{
    public class EmployeesController
    {
        public List<Employee> ListEmployees()
        {
            using (var context = new WestWindContext())
            {
                return context.Employees.ToList();
            }
        }
    }
}
