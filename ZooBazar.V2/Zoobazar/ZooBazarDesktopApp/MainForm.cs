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
using Domain.Manager;
using DataAccessLayer;


namespace ZooBazarDesktopApp
{
    public partial class MainForm : Form
    {
        private List<UserControl> userControls;
        private EmployeeManager employeeManager;

        private Color btnSelectedColor = Color.FromArgb(53, 68, 77);
        private Color btnDefaultColor = Color.FromArgb(0, 0, 0);
        public MainForm()
        {
            InitializeComponent();
            /*employeeManager = new EmployeeManager(new EmployeeDatabase(), new FormOpener());*/
            this.userControls = new List<UserControl>() { };

              
            AddControlsToTheForm(this.userControls);
            this.WindowState = FormWindowState.Normal;
        }

        //Code that makes the form moveable
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void HideAllUserControls()
        {
            foreach (UserControl uc in this.userControls)
            {
                uc.Visible = false;
            }
        }

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
            this.HideAllUserControls();
            this.userControls[0].Visible = true;
            this.userControls[0].BringToFront();
            //this.btnDashboard.BackColor = this.btnSelectedColor;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.HideAllUserControls();
            this.userControls[1].Visible = true;
            this.userControls[1].BringToFront();
            //this.btnStaff.BackColor = this.btnSelectedColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAnimals_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.HideAllUserControls();
            this.userControls[1].Visible = true;
            this.userControls[1].BringToFront();
            //this.btnStaff.BackColor = this.btnSelectedColor;
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.HideAllUserControls();
            this.userControls[3].Visible = true;
            this.userControls[3].BringToFront();
            //this.btnStaff.BackColor = this.btnSelectedColor;
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.HideAllUserControls();
            this.userControls[4].Visible = true;
            this.userControls[4].BringToFront();
            //this.btnStaff.BackColor = this.btnSelectedColor;
        }
        private void resetButtonsColor()
        {
            //this.btnStaff.BackColor = this.btnDefaultColor;
            //this.btnAnimals.BackColor = this.btnDefaultColor;
            //this.btnTickets.BackColor = this.btnDefaultColor;
            //this.btnDashboard.BackColor = this.btnDefaultColor;
            //this.btnReport.BackColor = this.btnDefaultColor;
            //this.btnAreas.BackColor = this.btnDefaultColor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.userControls[6].BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.resetButtonsColor();
            this.userControls[5].BringToFront();
        }
    }
}
