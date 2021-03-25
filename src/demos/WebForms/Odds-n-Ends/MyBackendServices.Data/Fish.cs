using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBackendServices.Data
{
    [Table("Fishies")] // This explicit naming of the database table will override EF's default
    public class Fish
    {
        public int FishId { get; set; }
        public string CommonName { get; set; }
        private string _ScientificName;
        public string ScientificName
        {
            get { return _ScientificName; }
            set
            {
                _ScientificName = string.IsNullOrWhiteSpace(value) ? null : value;
            }
        }

        [NotMapped]
        public string WholeName
        {
            get { return $"{CommonName} [{ScientificName}]"; }
        }
    }
}
