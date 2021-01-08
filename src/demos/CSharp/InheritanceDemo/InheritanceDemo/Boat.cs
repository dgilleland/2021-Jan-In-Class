using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Boat : Vehicle
    {
        public int Capacity { get; private set; }
        public double FootLength { get; private set; }
        public Boat(string serial, MakeModel makeModel, Fuel kind, int capacity, double feetLong)
            : base(serial, makeModel, kind)
        {
            Capacity = capacity;
            FootLength = feetLong;
        }
    }
}
