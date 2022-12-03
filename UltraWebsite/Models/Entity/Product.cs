namespace UltraWebsite.Models.Entity
{
    public class Product:Entity
    {
        public string Image_url { get; set; }
        public string Name { get; set; }
        public int catalogue_id { get; set; }
        public int price { get; set; }
        public string Color { get; set; }
        public string ProductMaterial { get; set; }
        public string ProductAdjective { get; set; }
        public virtual Catagory Catalogue { get; set; }
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }=new List<ProductTag>();


    }
}
