using Domain.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drawing = System.Drawing;

namespace ZooBazarDesktopApp.UserControls
{
    public partial class MapUC : UserControl
    {
        private ImageManager imageManager;
        public MapUC()
        {
            InitializeComponent();
            imageManager = new ImageManager();
            dgvImages.Columns.Add("ImageDataColumn", "Image");

            LoadImages();
        }
        private void LoadImages()
        {
            try
            {
                // Get all images from the database
                List<byte[]> images = imageManager.GetAllImages();

                // Clear existing rows in the DataGridView
                dgvImages.Rows.Clear();

                // Add each image to the DataGridView
                foreach (byte[] imageData in images)
                {
                    // Convert byte array to Image
                    Drawing.Image image = Drawing.Image.FromStream(new System.IO.MemoryStream(imageData));

                    // Add the Image to the DataGridView
                    dgvImages.Rows.Add(new object[] { image });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while retrieving images: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            // Open a file dialog to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Read the selected image file and convert it to a byte array
                    byte[] imageData = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                    // Add the image to the database
                    imageManager.AddImage(imageData);
                    // Refresh the DataGridView displaying the images
                    RefreshImageDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while adding image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvImages.SelectedRows.Count > 0)
            {
                // Get the ImageID of the selected row
                int imageID = (int)dgvImages.SelectedRows[0].Cells["ImageID"].Value;
                try
                {
                    // Delete the image from the database
                    imageManager.DeleteImage(imageID);
                    // Refresh the DataGridView displaying the images
                    RefreshImageDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while deleting image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an image to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Method to refresh the DataGridView displaying the images
        private void RefreshImageDataGrid()
        {
            try
            {
                // Reload images
                LoadImages();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing images: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
