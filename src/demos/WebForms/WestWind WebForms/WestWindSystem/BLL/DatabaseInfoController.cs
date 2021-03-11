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
                // I'm making a little bit of an assumption that the database
                // has only one row in the BuildVersion table.
                // That's what the DBA has promised anyway.... ;)
                return context.BuildVersions.Single();
            }
        }
    }
}
