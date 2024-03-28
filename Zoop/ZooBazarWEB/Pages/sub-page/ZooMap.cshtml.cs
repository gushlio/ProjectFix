using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain.Manager;

namespace ZooBazarWEB.Pages.sub_page
{
    public class ZooMapModel : PageModel
    {
        private readonly ImageManager _imageManager;

        public List<string> ImagesBase64 { get; set; }

        public ZooMapModel(ImageManager imageManager)
        {
            _imageManager = imageManager;
        }

        public void OnGet()
        {
            // Fetch images from the ImageManager
            try
            {
                ImagesBase64 = _imageManager.GetAllImagesAsBase64();
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                // For example, you can log the error or display a message on the page
                // In this example, we'll just set ImagesBase64 to an empty list
                ImagesBase64 = new List<string>();
                TempData["ErrorMessage"] = "An error occurred while fetching images: " + ex.Message;
            }
        }
    }
}
