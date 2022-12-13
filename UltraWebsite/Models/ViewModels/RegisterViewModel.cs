using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using UltraWebsite.Models.Entity;

namespace UltraWebsite.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        public string UserName { get; set; }

        [Required]
        [StringLength(
   100,
   ErrorMessage = "The {0} must be at least {2} characters long.",
   MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
      
    }
}
