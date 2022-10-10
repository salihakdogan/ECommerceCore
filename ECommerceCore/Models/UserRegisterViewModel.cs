using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ECommerceCore.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Name cannot be empty")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last name cannot be empty")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "E-mail cannot be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage = "Passwords do not match")]
        [Required(ErrorMessage = "Verify password cannot be empty")]
        public string ConfirmPassword { get; set; }
    }
}
