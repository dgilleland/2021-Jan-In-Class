using System;
using System.Collections.Generic;
using System.Linq;
using WestWindSystem.DAL;
using WestWindSystem.Entities;

namespace WestWindSystem.BLL
{
    public class AddressController
    {
        public List<Address> ListAllAddresses()
        {
            using (var context = new WestWindContext())
            {
                return context.Addresses.ToList();
            }
        }
    }
}
