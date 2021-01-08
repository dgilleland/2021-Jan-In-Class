using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class MakeModel
    {
        public string Make { get; private set; }
        public string Model { get; private set; }

        public MakeModel(string make, string model)
        {
            if (string.IsNullOrWhiteSpace(make) || string.IsNullOrWhiteSpace(model))
                throw new Exception("MakeModel needs both a Make and a Model number");
            Make = make;
            Model = model;
        }

        public override string ToString()
        {
            return Make + "/" + Model;
        }
    }
}
