using System.ComponentModel.DataAnnotations;

namespace ECommerceCore.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="E-mail")]
        [Required(ErrorMessage = "E-mail cannot be empty")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password cannot be empty")]
        public string Password { get; set; }
    }
}
