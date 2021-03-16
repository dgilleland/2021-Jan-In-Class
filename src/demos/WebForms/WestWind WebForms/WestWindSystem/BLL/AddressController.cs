using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class AddressController
    {
        public List<Address> ListAllAddresses()
        {
            using(var context = new WestWindContext())
            {
                return context.Addresses.ToList().OrderBy(x => x.AbbreviatedAddress).ToList();
            }
        }
    }
}
