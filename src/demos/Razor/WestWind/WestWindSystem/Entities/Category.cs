namespace WestWindSystem.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; } // The image SQL data type is a byte[] in C#
        public string PictureMimeType { get; set; }
    }
}
