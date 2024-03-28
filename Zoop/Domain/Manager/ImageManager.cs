

namespace Domain.Manager
{
    public class ImageManager
    {
        private DataAccessLayer.ImagesDB imagesDB;

        public ImageManager()
        {
            // Initialize the ImagesDB class
            imagesDB = new DataAccessLayer.ImagesDB();
        }

        // Method to add an image
        public void AddImage(byte[] imageData)
        {
            try
            {
                imagesDB.AddImage(imageData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while adding image: " + ex.Message);
                // You may handle or log the exception as needed
                throw;
            }
        }

        // Method to get all images
        public List<byte[]> GetAllImages()
        {
            try
            {
                return imagesDB.GetAllImages();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all images: " + ex.Message);
                // You may handle or log the exception as needed
                throw;
            }
        }
        // Method to get all images as base64 strings
        public List<string> GetAllImagesAsBase64()
        {
            try
            {
                // Retrieve images as byte arrays
                List<byte[]> images = imagesDB.GetAllImages();

                // Convert each image byte array to base64 string
                List<string> imagesBase64 = new List<string>();
                foreach (byte[] imageData in images)
                {
                    string base64String = Convert.ToBase64String(imageData);
                    imagesBase64.Add(base64String);
                }

                return imagesBase64;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting all images as base64: " + ex.Message);
                // You may handle or log the exception as needed
                throw;
            }
        }

        // Method to delete an image
        public void DeleteImage(int imageID)
        {
            try
            {
                imagesDB.DeleteImage(imageID);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while deleting image: " + ex.Message);
                // You may handle or log the exception as needed
                throw;
            }
        }

        // Method to update an image
        public void UpdateImage(int imageID, byte[] newImageData)
        {
            try
            {
                imagesDB.UpdateImage(imageID, newImageData);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while updating image: " + ex.Message);
                // You may handle or log the exception as needed
                throw;
            }
        }
        
    }
}
