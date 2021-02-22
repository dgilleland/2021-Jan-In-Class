using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            app.Run();
        }

        private void Run()
        {
            string userInput;
            do
            {
                Write("Enter information: ");
                userInput = ReadLine();
                AnalyzeInput(userInput);
            } while (userInput != "exit");
        }

        private void AnalyzeInput(string input)
        {
            // Test to see if it is a whole number
            try
            {
                int wholeNumber = int.Parse(input);
                WriteLine($"{wholeNumber} is an integer.");
            }
            catch (Exception ex)
            {
                WriteLine("It is not a whole number.");
            }

            // Test to see if it a real number
            try
            {
                double realNumber = double.Parse(input);
                WriteLine($"{realNumber} is a real number.");
            }
            catch // Identifying the exception is optional if you are not going to use it. (but you SHOULD USE IT)
            {
                WriteLine("It is not a real number.");
            }
        }
    }
}
