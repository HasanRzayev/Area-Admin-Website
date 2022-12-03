namespace UltraWebsite.Models.Entity
{
    public class Catagory : Entity
    {
        public string Name { get; set; }
        public string? Image_url { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
