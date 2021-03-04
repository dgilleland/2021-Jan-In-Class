using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WestWindSystem.Entities
{
    // ![](BE0B1BF22D77A0551161BF09E219B433.png)
    public class EmployeeTerritory
    {
        // I have a composite Primary Key in this table. I can identify it with attributes
        [Key, Column(Order = 1)]
        public int EmployeeID { get; set; }
        [Key, Column(Order = 2)]
        public int TerritoryID { get; set; }
    }
}
