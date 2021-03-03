using System;

namespace WestWindSystem.Entities
{
    // ![](0E5086FF7A3E2D2D930F567B0F037D8A.png)
    public class Payment
    {
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public byte PaymentTypeID { get; set; }
        public int OrderID { get; set; }
        // GUID -> Globally Unique Identifier
        public Guid TransactionID { get; set; } // uniqueidentifier
        public DateTime? ClearedDate { get; set; }
    }
}
