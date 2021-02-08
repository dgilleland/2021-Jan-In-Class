namespace WebApp.Data
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; } // Image column - equivalent to an array of bytes
        public string PictureMimeType { get; set; }
    }
}
