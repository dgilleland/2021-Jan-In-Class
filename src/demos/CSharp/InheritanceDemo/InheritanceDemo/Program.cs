using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> spyRental = new List<Vehicle>();
            Car common = new Car("25FD4TR654", new MakeModel("GMC", "Econo"), Fuel.Unleaded, 5, 4);
            Boat zodiac = new Boat("1558PO3", new MakeModel("StarCraft", "Z5098"), Fuel.Leaded, 12, 8.5);

            spyRental.Add(common);
            spyRental.Add(zodiac);

            foreach(Vehicle thing in spyRental)
            {
                // The is keyword allows us to test the data type of the object
                if (thing is Car)
                    Console.Write("This is a car: " + thing.MakeAndModel);
                else if (thing is Boat)
                    Console.Write("This is a boat: " + thing.MakeAndModel);

                // The as keyword performs safe type casting of an object to some subtype
                // The var keyword allows us to let the compiler figure out the data type we need
                var myBoat = thing as Boat;
                // When using the as keyword to do a safe type casting, if the object's actual
                // datatype does NOT match the type we are trying to cast it to, then the resulting
                // value assigned is null.
                if (myBoat != null)
                    Console.Write(" and the boat is " + myBoat.FootLength + " feet long");
                Console.WriteLine(); // write a blank line
            }
        }
    }
}
