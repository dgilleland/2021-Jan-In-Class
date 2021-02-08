using System;

namespace WebApp.Data
{
    public partial class Payment
    {
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public byte PaymentTypeID { get; set; }
        public int OrderID { get; set; }
        public Guid TransactionID { get; set; }
        public DateTime? ClearedDate { get; set; }
    }
}
