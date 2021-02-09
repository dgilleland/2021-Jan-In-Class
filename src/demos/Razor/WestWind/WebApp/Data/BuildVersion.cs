using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data
{
    [Table("BuildVersion")]
    public class BuildVersion
    {
        public int Id { get; set; }
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Build { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
