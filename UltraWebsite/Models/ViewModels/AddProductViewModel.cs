using UltraWebsite.Models.Entity;

namespace UltraWebsite.Models.ViewModels
{
    public class AddProductViewModel
    {
        public IFormFile Image_url { get; set; }
        public string Name { get; set; }
        public int catalogue_id { get; set; }
        public int price { get; set; }
        public string Color { get; set; }
        public string ProductMaterial { get; set; }
        public string ProductAdjective { get; set; }
       

        public int[] TagIds { get; set; }
    }
}
