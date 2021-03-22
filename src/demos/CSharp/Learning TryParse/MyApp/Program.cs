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
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }
        public Fraction(int num, int denom)
        {
            if (denom == 0)
                throw new DivideByZeroException();
            Numerator = num;
            Denominator = denom;
            FixSign();
        }
        private void FixSign()
        {
            if (Denominator < 0)
            {
                Denominator *= -1;
                Numerator *= -1;
            }
        }
        public bool IsProper
        {
            get
            {
                bool proper;
                if (Numerator < Denominator)
                    proper = true;
                else
                    proper = false;
                return proper;
            }
        }
        public override string ToString()
        {
            string stringValue = "";
            if (IsProper)
                stringValue += (Numerator / Denominator) + " and "
                             + (Numerator % Denominator) + "/" + Denominator;
            else
                stringValue += Numerator + "/" + Denominator;
            return stringValue;
        }

        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }
        public Fraction Reciprocal
        {
            get { return new Fraction(Denominator, Numerator); }
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

        public static Fraction operator +(Fraction a) => a;
        public static Fraction operator -(Fraction a) => new Fraction(-a.Numerator, a.Denominator);

        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.Numerator * b.Denominator + b.Numerator * a.Denominator, a.Denominator * b.Denominator);

        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        private int GreatestCommonDenominator()
        {
            int commonDenominator = 1;
            int count = 2, halfWay;
            int absoluteNumerator = System.Math.Abs(Numerator);
            if (absoluteNumerator > Denominator)
                halfWay = absoluteNumerator / 2;
            else
                halfWay = Denominator / 2;

            while (count <= halfWay)
            {
                if (absoluteNumerator % count == 0 &&
                    Denominator % count == 0)
                    commonDenominator = count;
                count++;
            }

            return commonDenominator;
        }
    }
}
