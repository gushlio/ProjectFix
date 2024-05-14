using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ZooBazarWEB.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IndexModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPostLogout()
        {
            // Clear username from session
            _httpContextAccessor.HttpContext.Session.Remove("username");

            // Redirect to the index page or any other page you want after logout
            return RedirectToPage("/Index");
        }
    }
}
