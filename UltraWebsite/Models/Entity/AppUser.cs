using Microsoft.AspNetCore.Identity;

namespace UltraWebsite.Models.Entity
{
    public class AppUser : IdentityUser
    {
        public virtual ICollection<Order> Orders  { get; set; }
       

    }
}
