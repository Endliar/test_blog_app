using Microsoft.AspNetCore.Identity;
using test_blog_app.Models;

namespace test_blog_app.Services
{
    public class AuthenticationService
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;

        public AuthenticationService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<bool> RegisterNewUser(User user)
        {
            var identityUser = new IdentityUser()
            {
                Email = user.Email,
                UserName = user.Name,
                PasswordHash = user.Password,
            };
            var result = await _userManager.CreateAsync(identityUser);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
