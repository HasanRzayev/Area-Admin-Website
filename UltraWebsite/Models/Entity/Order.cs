namespace UltraWebsite.Models.Entity
{
    public class Order:Entity
    {
        public virtual Product Product { get; set; }
        public int? product_id { get; set; }
        public virtual AppUser user { get; set; }
        public string user_id { get; set; }

        public int Count { get; set; }

    }
}
