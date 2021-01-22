using System;
using System.Collections.Generic;
using System.Data.Entity; // for the DbContext class from Entity Framework
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> data;
            // The following using keyword is different from the using keyword at the top of this file.
            using(A04Context context = new A04Context()) // ensures some "clean-up" after "using" the context object
            {
                // Grab some data
                data = context.Courses.ToList();
            }
            // Display the data
            foreach (Course info in data)
                Console.WriteLine($"{info.CourseId} - {info.Name}");
        }
    }

    /// <summary>
    /// This is an Entity class that mirrors the structure of the Courses table.
    /// </summary>
    public class Course
    {
        public string CourseId { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// This is a virtual representation of my database.
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    public class A04Context : DbContext
    {
        public A04Context() : base("name=A04Db") // Identify the name for a connection string in the .config file.
        {
            Database.SetInitializer<A04Context>(null); // Ensures that EF6 does not auto-generate the Db tables.
        }

        public DbSet<Course> Courses { get; set; } // Virtual representation of a table in my database
    }
}
