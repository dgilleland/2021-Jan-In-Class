using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class EmployeeController
    {
        // A simple CRUD-like pattern where we use a single "controller" class per database table
        public List<Employee> ListEmployees()
        {
            using (var context = new WestWindContext())
            {
                return context.Employees.ToList().OrderBy(x => x.FullName).ToList();
            }
        }
    }
}
