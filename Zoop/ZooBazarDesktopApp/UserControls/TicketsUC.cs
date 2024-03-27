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

namespace ZooBazarDesktopApp.UserControls
{
    public partial class TicketsUC : UserControl
    {
     
        public TicketsUC()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string selectedItem = checkedCategoryTicket.SelectedItem?.ToString();

            if (selectedItem != null)
            {

                string value = textBox1.Text;


                for (int i = 0; i < checkedCategoryTicket.Items.Count; i++)
                {
                    if (checkedCategoryTicket.GetItemChecked(i))
                    {

                        string checkedItem = checkedCategoryTicket.Items[i].ToString();


                        string info = $"{checkedItem}: {value}";
                        CurrentPrices.Items.Add(info);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CurrentPrices.Items.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem?.ToString();

            if (selectedItem != null)
            {
                // Get the price from the TextBox
                string price = textBox1.Text;

                // Check if the selected quantity is greater than 0
                if (comboBox1.SelectedIndex >= 0)
                {
                    int selectedQuantity = comboBox1.SelectedIndex + 1; // +1 because ComboBox is zero-indexed

                    // Clear both list boxes
                    CurrentPrices.Items.Clear();
                    RemainingTickets.Items.Clear();

                    // Display items in CurrentPrices ListBox
                    for (int i = 0; i < selectedQuantity; i++)
                    {
                        // Display the selected item along with its associated price in the CurrentPrices ListBox
                        string info = $"{selectedItem}: {price}";
                        CurrentPrices.Items.Add(info);
                    }

                    // Display remaining items in RemainingItems ListBox
                    int remainingQuantity = comboBox1.Items.Count - selectedQuantity;
                    for (int i = 0; i < remainingQuantity; i++)
                    {
                        // Display the remaining items in the RemainingItems ListBox
                        RemainingTickets.Items.Add(comboBox1.Items[selectedQuantity + i]);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a quantity from the list.");
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the list.");
            }
        }
    }
}
