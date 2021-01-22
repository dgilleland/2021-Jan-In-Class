using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class JavaType
    {
        // Fields should probably be private
        private int _Count; // the _ is typically used to denote a private field
        public void Count(int value)
        {
            if (value < 0) throw new Exception(); // Yay, I guarded by variable so only good data comes in.
            _Count = value;
        } // SetCount(int value)
        public int Count() { return _Count; }            // GetCount()
    }
    public class CSharpType
    {
        private int _Count;
        public int Count
        {
            get { return _Count; }
            set
            {
                if (value < 0) throw new Exception();
                _Count = value;
            }
        }
    }
}
