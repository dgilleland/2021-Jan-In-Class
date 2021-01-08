using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Car : Vehicle
    {
        public int SeatingCapacity { get; private set; }
        public int Doors { get; set; }

        public Car(string serialNo, MakeModel mm, Fuel fuelKind, int seatsCount, int doorCount)
            : base(serialNo, mm, fuelKind)
        {
            // TODO: Add Validation
            SeatingCapacity = seatsCount;
            Doors = doorCount;
        }
    }
}
