using System.ComponentModel.DataAnnotations;

namespace test_blog_app.Models
{
    public class UserRegistrationModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress] 
        public string EmailAddress { get; set;}

        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [DataType(DataType.PhoneNumber)] 
        public string PhoneNumberConfirmed { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation do not match")]
        public string ConfirmPassword { get; set;}
    }
 }
