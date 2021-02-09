using System;
using System.ComponentModel.DataAnnotations.Schema; // For the annotations

namespace WebApp.Data
{
    [Table("BuildVersion")] // We can use an annotation on the class to indicate the database table name
    public class BuildVersion
    {
        public int Id { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public DateTime ReleaseDate { get; set; }
        public override string ToString()
        {
            return $"{Major}.{Minor}.{Build} ({ReleaseDate})";
        }
    }
}
