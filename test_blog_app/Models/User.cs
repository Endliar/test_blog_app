using System.ComponentModel.DataAnnotations;
using test_blog_app.UserEnum;

namespace test_blog_app.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Post RegAs { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
