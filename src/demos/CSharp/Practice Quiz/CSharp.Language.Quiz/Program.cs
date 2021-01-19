using System;
using System.Collections.Generic;
using CSharp.Language.Quiz.Entities;

namespace CSharp.Language.Quiz
{
    public class Program
    {
        private static Random rnd = new Random();

        public static void Main(string[] args)
        {
        }
    }
}

namespace CSharp.Language.Quiz.Entities
{
    public class Student
    {
        public string Name { get; private set; }
        public EarnedMark[] Marks { get; private set; }

        public Student(string name, EarnedMark[] marks)
        {
            Name = name;
            Marks = marks;
        }
    }

    public class WeightedMark
    {
        public int Weight { get; private set; }
        public string Name { get; private set; }

        public WeightedMark(string name, int weight)
        {
            if (weight <= 0 || weight > 100)
                throw new Exception("Invalid weight: must be greater than zero and at most 100");
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(name.Trim()))
                throw new Exception("Name cannot be empty for weighted item");
            Weight = weight;
            Name = name;
        }
    }

    public class EarnedMark : WeightedMark
    {
        public int Possible { get; private set; }
        private double _Earned;
        public double Earned
        {
            get { return _Earned; }
            set
            {
                if (value < 0 || value > Possible)
                    throw new Exception("Invalid earned mark assigned");
                _Earned = value;
            }
        }

        public double Percent
        { get { return (Earned / Possible) * 100; } }

        public double WeightedPercent
        { get { return Percent * Weight / 100; } }

        public EarnedMark(WeightedMark markableItem, int possible, double earned)
            : this(markableItem.Name, markableItem.Weight, possible, earned)
        {
        }

        public EarnedMark(string name, int weight, int possible, double earned)
            : base(name, weight)
        {
            if (possible <= 0)
                throw new Exception("Invalid possible marks");
            Possible = possible;
            Earned = earned;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1})\t - {2}% ({3}/{4}) \t- Weighted Mark {5}%",
                                 Name,
                                 Weight,
                                 Percent,
                                 Earned,
                                 Possible,
                                 WeightedPercent);
        }
    }
}