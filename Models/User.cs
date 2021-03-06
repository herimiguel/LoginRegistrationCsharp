using System.ComponentModel.DataAnnotations;


namespace loginRegistration.Models
{
    public abstract class BaseEntity {}
    public class User : BaseEntity 
    {
        [Required]
        [MinLength(3, ErrorMessage = "First Name must be at least 3 characters!")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Last Name must be at least 3 characters!")]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string email { get; set; }
        
        [Required]
        [MinLength(8, ErrorMessage = "Passwords must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage="Passwords must match")]
        [Display(Name = "Confirm Password")]
        public string passwordConfirmation { get; set; }

    }
}