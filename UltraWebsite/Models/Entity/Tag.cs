namespace UltraWebsite.Models.Entity
{
    public class Tag : Entity
    {
        public string Name { get; set; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}
