namespace WebApp.Data
{
    public partial class ManifestItem
    {
        public int ManifestItemID { get; set; }
        public int ShipmentID { get; set; }
        public int ProductID { get; set; }
        public short ShipQuantity { get; set; }
    }
}
