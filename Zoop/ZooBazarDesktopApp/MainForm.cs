using LibraryApplication.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZooBazarDesktopApp.UserControls;

namespace ZooBazarDesktopApp
{
    public partial class MainForm : Form
    {
        private List<UserControl> userControls;

        private Color btnSelectedColor = Color.FromArgb(53, 68, 77);
        private Color btnDefaultColor = Color.FromArgb(44, 57, 65);
        public MainForm()
        {
            InitializeComponent();
            this.userControls = new List<UserControl>()
                {new Dashboard(), new AnimalsUC(), new EmployeesUC(), new TicketsUC(), new MapUC() };
            AddControlsToTheForm(this.userControls);
        }

        //Code that makes the form moveable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void panelMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void AddControlsToTheForm(List<UserControl> userControls)
        {
            foreach (UserControl userControl in userControls)
            {
                this.Controls.Add(userControl);
            }
        }
        private void lblQuickAccess_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.userControls[0].BringToFront();
            this.btnDashboard.BackColor = this.btnSelectedColor;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.userControls[2].BringToFront();
            this.btnStaff.BackColor = this.btnSelectedColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void btnAnimals_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.userControls[1].BringToFront();
            this.btnAnimals.BackColor = this.btnSelectedColor;
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.userControls[3].BringToFront();
            this.btnTickets.BackColor = this.btnSelectedColor;
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.userControls[4].BringToFront();
            this.btnAreas.BackColor = this.btnSelectedColor;
        }
        private void resetButtonsColor()
        {
            this.btnStaff.BackColor = this.btnDefaultColor;
            this.btnAnimals.BackColor = this.btnDefaultColor;
            this.btnTickets.BackColor = this.btnDefaultColor;
            this.btnDashboard.BackColor = this.btnDefaultColor;
            this.btnReport.BackColor = this.btnDefaultColor;
            this.btnAreas.BackColor = this.btnDefaultColor;

        }
    }
}
