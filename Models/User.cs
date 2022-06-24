using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SimplePropertyInvesting.Models
{
    public enum AccountType
    {
        [Display(Name = "Basic user")]
        basic,
        [Display(Name = "Admin user")]
        admin
    }
    public class User
    {
        [Key] 
        [DisplayName("User ID")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Field is required")]
        [Display(Name = "User Name")]
        public string Name { get; set; }
        [DisplayName("User Type")]
        public AccountType UserType { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }

        // Add list of property ID's.

    }
}
