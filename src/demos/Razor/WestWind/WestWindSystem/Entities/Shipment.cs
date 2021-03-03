using System;

namespace WestWindSystem.Entities
{
    public class Shipment
    {
        public int ShipmentID { get; set; }
        public int OrderID { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public decimal FreightCharge { get; set; }
        public string TrackingCode { get; set; }
    }
}
