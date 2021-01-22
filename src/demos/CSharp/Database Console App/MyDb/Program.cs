using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDb
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> data;
            // The following using keyword is different from the using keyword at the top of this file.
            using (var context = new A03Context()) // "Clean-up" after "using" this object
            {
                data = context.Courses.ToList();
            }
            foreach(Course course in data)
            {
                Console.WriteLine($"{course.CourseId} - {course.Name}");
            }
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
    public class A03Context : DbContext
    {
        public A03Context() : base("name=A03Db") // Identify the name for a connection string in .config
        {
            Database.SetInitializer<A03Context>(null); // Ensures that EF6 does not auto-generate the db
        }

        public DbSet<Course> Courses { get; set; }
    }
}
