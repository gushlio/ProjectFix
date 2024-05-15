using DataAccessLayer;
using DataAccessLayer.DTO;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ZooBazarWEB.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserDB _userDB;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginModel(UserDB userDB, IHttpContextAccessor httpContextAccessor)
        {
            _userDB = userDB;
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(string username, string password)
        {
            if (!_userDB.IsUsernameTaken(username))
            {
                ModelState.AddModelError("InvalidLogin", "Username is not known.");
                return Page();
            }

            if (!_userDB.IsPasswordCorrect(username, password))
            {
                ModelState.AddModelError("InvalidLogin", "Password is incorrect.");
                return Page();
            }

            // Fetch user's role from the database
            string role = _userDB.GetUserRole(username);

            // Store user's role in session
            _httpContextAccessor.HttpContext.Session.SetString("role", role);
            _httpContextAccessor.HttpContext.Session.SetString("username", username);

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostLogout()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
            return RedirectToPage("/Index");
        }
    }
}
