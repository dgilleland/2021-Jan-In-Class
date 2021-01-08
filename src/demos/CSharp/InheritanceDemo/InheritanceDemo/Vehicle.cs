using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    // The Vehicle class will be a base class for other kinds of vehicles
    public class Vehicle
    {
        public string SerialNumber { get; private set; }
        public MakeModel MakeAndModel { get; private set; }
        public Fuel FuelType { get; set; }

        public Vehicle(string serial, MakeModel makeModel, Fuel fuel)
        {
            SerialNumber = serial;
            MakeAndModel = makeModel;
            FuelType = fuel;
        }
    }
}
