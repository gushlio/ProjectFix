using DataAccessLayer;
using DataAccessLayer.DTO;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazarWEB.Pages
{
    public class LoginModel : PageModel
    {
        private readonly UserDB _userDB ;

        public LoginModel(UserDB userDB)
        {
            _userDB = userDB;

        }
        private UserDTO MapToDTO(User user)
        {
            return new UserDTO
            {
                Username = user.Username,
                Password = user.Password
                // Map other properties as needed...
            };
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(string username, string password)
        {
            if (!_userDB.IsUsernameTaken(username))
            {
                // Username doesn't exist
                ModelState.AddModelError("InvalidLogin", "Username is not known.");
                return Page();
            }

            if (!_userDB.IsPasswordCorrect(username, password))
            {
                // Password is incorrect
                ModelState.AddModelError("InvalidLogin", "Password is incorrect.");
                return Page();
            }



            // Redirect to the catalogue page
            return RedirectToPage("/Index");
        }
    }
}
