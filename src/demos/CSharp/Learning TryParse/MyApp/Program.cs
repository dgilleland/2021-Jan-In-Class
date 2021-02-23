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
            int wholeNumber;
            if (int.TryParse(input, out wholeNumber))
                WriteLine($"{wholeNumber} is an integer.");
            else
                WriteLine("It is not a whole number.");

            // Test to see if it is a real number
            double realNumber;
            if( double.TryParse(input, out realNumber))
                WriteLine($"{realNumber} is a real number.");
            else
                WriteLine("It is not a real number.");

            // Test to see if it is a fraction
            Fraction frac;
            if (Fraction.TryParse(input, out frac))
                WriteLine($"{frac} is a fraction with a double equivalent of {frac.ToDouble()}");
            else
                WriteLine("It is not a fraction");
        }
    }

    public class Fraction
    {
        public int Numerator { get; }
        public int Denominator { get; }
        public Fraction(int num, int denom)
        {
            Numerator = num;
            Denominator = denom;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }

        public static Fraction Parse(string input)
        {
            // Simple parsing of a string - we just let any errors get thrown
            var parts = input.Split('/');
            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }

        public static bool TryParse(string input, out Fraction result)
        {
            // Since the result parameter is an out parameter, I have to ensure its value is set whether
            // I succeed or not
            try
            {
                result = Parse(input); // Happy path
                return true;
            }
            catch
            {
                result = null; // Failed. Give a null object as the default
                return false;
            }
        }
    }
}
