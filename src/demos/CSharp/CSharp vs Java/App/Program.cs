using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try { DemoJava(); } catch { }
            Console.ForegroundColor = ConsoleColor.Green;
            try { DemoCSharp(); } catch { }
            Console.ResetColor();
        }
        static void DemoJava()
        {
            JavaType first, second;
            first = new JavaType();
            second = new JavaType();
            Console.WriteLine($"First is {first.Count()} and Second is {second.Count()}"); // see the value
            SetCount(first, 42);
            SetCount(second, -5);
        }
        static void SetCount(JavaType item, int count)
        {
            item.Count(count); // Change the value
        }

        static void DemoCSharp()
        {
            CSharpType first, second;
            first = new CSharpType();
            second = new CSharpType();
            Console.WriteLine($"First is {first.Count} and Second is {second.Count}"); // see the value
            SetCount(first, 42);
            SetCount(second, -5);
        }
        static void SetCount(CSharpType item, int count)
        {
            item.Count = count; // Change the value
        }

    }
}
