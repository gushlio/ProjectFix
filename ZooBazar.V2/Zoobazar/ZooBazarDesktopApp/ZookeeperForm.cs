using Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp
{
    public partial class ZooKeeperForm : Form
    {
        Employee loggedEmployee;
        public ZooKeeperForm(Employee currentUser)
        {
            InitializeComponent();
            loggedEmployee = currentUser;
        }

        private void ShowForm(Form form)
        {
            pnlForm.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.AutoScroll = true;
            form.Size = pnlForm.Size;
            pnlForm.Controls.Add(form);
            form.Show();
        }

        

        private void pictureBoxAnimals_Click(object sender, EventArgs e)
        {
            ShowForm(new Animal(loggedEmployee));
        }

        private void pictureBoxEmployees_Click(object sender, EventArgs e)
        {
            ShowForm(new EmployeeForm(loggedEmployee));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStatistics_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
