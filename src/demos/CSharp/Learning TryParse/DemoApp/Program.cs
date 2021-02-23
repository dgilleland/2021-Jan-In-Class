using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoApp
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
            Write("Enter a number: ");
            string userInput = ReadLine();
            double total = 0;
            while(!string.IsNullOrWhiteSpace(userInput))
            {
                // Total up some numbers
                total += ProcessedInput(userInput);
                Write("Enter another number (or blank line to exit):");
                userInput = ReadLine();
            };
            WriteLine($"\nThe final total is {total}");
        }

        private double ProcessedInput(string input)
        {
            double value = 0;
            // The user input might be a whole number or it might be a real number
            int tempWholeNumber;
            if (int.TryParse(input, out tempWholeNumber))
                value = tempWholeNumber;
            else
            {
                WriteLine($"the value {input} is not a whole number.");

                double tempNumber;
                if (double.TryParse(input, out tempNumber))
                {
                    value = tempNumber;
                    WriteLine("... but it is a real number, so I'll add it.");
                }
                else
                {
                    WriteLine($"The value {input} is not a real number.");
                    Fraction fractionNumber;
                    if (Fraction.TryParse(input, out fractionNumber))
                    {
                        WriteLine($"At least {input} is a fraction, and I understand those...");
                        value += fractionNumber.ToDouble();
                    }
                    else
                        WriteLine($"The value {input} is not a fraction either.");
                }
            }

            return value;
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
        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static Fraction Parse(string text)
        {
            // i.e.:    3/4
            string[] parts = text.Split('/'); // should give me two parts
            int n = int.Parse(parts[0]);
            int d = int.Parse(parts[1]);
            return new Fraction(n, d);
        }

        public static bool TryParse(string text, out Fraction result) // Notice the out parameter
        {
            try
            {
                result = Parse(text); // returning the result via the out parameter
                return true; // Explicit return type
            }
            catch
            {
                result = default(Fraction); // which is a null
                return false; // Explicit return type
            }
        }
    }
}
