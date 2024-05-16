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

            if (_userDB.IsUsernameTaken(username))
            {
                ModelState.AddModelError("UsernameTaken", "This username is already taken.");
                return Page();
            }

            var userDTO = new UserDTO
            {
                Username = username,
                Password = password
            };

            _userDB.RegisterUser(userDTO);
            return RedirectToPage("/Login"); 
        }
    }
}