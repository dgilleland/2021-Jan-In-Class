using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindSystem.Entities
{
    // ![](E95460FE0D25A912F00BC86BF6A3692C.png)
    [Table("BuildVersion")] // An annotation to identify the name of the database table
    public class BuildVersion
    {
        public int Id { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public DateTime ReleaseDate { get; set; }

        public override string ToString()
        {
            return $"{Major}.{Minor}.{Build} (Released {ReleaseDate.ToLongDateString()})";
        }
    }
}
