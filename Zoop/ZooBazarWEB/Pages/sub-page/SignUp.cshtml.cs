using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DataAccessLayer;
using Domain.Entity;
using DataAccessLayer.DTO;

namespace ZooBazarWEB.Pages
{
    public class SignUpModel : PageModel
    {
        private readonly UserDB _userDB;

        public SignUpModel(UserDB userDB)
        {
            _userDB = userDB;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(string username, string password)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Check if the username is already taken
            if (_userDB.IsUsernameTaken(username))
            {
                ModelState.AddModelError("UsernameTaken", "This username is already taken.");
                return Page();
            }

            // Create a new UserDTO object
            var userDTO = new UserDTO
            {
                Username = username,
                Password = password
            };

            // Register the new user using DTO
            _userDB.RegisterUser(userDTO);

            // Redirect to a different page after successful registration
            return RedirectToPage("/Index"); // Redirect to Account page
        }
    }
}