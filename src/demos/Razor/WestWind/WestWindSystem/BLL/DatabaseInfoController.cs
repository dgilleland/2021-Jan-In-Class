using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class DatabaseInfoController
    {
        public BuildVersion GetBuildVersion()
        {
            using (var context = new WestWindContext())
            {
                return context.BuildVersions.Single(); // Get the only row in the table
            }
        }
    }
}
