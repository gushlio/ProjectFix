using DataAccessLayer;
using DataAccessLayer.DTO;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace ZooBazarWEB.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserDB _userDB ;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginModel(UserDB userDB, IHttpContextAccessor httpContextAccessor)
        {
            _userDB = userDB;
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string username, string password)
        {
            if (!_userDB.IsUsernameTaken(username))
            {
                //username doesn't exist
                ModelState.AddModelError("InvalidLogin", "Username is not known.");
                return Page();
            }

            if (!_userDB.IsPasswordCorrect(username, password))
            {
                // pass doesn't exist
                ModelState.AddModelError("InvalidLogin", "Password is incorrect.");
                return Page();
            }

            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, username),
        };
            var claimsIdentity = new ClaimsIdentity(claims, "login");

            var authProperties = new AuthenticationProperties
            {
            };
            var principal = new ClaimsPrincipal(claimsIdentity);
            await HttpContext.SignInAsync(principal, authProperties);
            return RedirectToPage("/Index");
        }
    }
}
