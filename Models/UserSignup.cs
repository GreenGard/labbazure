using System.ComponentModel.DataAnnotations;

namespace WebApplicationMA.Models
{
    public class UserSignup
    {
        [Required(ErrorMessage = "First Name is required.")]
        public required string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last Name is required.")]
        public required string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public required string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public required string Password { get; set; } = string.Empty;
    }
}


