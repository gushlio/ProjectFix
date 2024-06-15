using Domain.Entity;
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
using ZooBazarDesktopApp.UserControls;


namespace ZooBazarDesktopApp
{
    public partial class ZookeeperForm : Form
    {
        private UserControl currentControl;
        private ReportManager reportsManager;
        private Employee loggedInEmployee;
        private EmployeeManager employeeManager;
        public ZookeeperForm(EmployeeManager _employeeManager)
        {
            InitializeComponent();
            // Initialize ReportsManager and other necessary components
            reportsManager = new ReportManager();

            /*loggedInEmployee = employeeManager.GetLoggedInEmployee();*/

            // Load reports when the form loads
            LoadReports();
            LoadHomeControl();
        }

        private void LoadHomeControl()
        {
            HomeControl homeControl = new HomeControl();
            LoadControl(homeControl);
        }

        private void LoadReportsControl()
        {
            ReportsControl reportsControl = new ReportsControl(loggedInEmployee);
            LoadControl(reportsControl);
        }

        private void LoadScheduleControl()
        {
            ScheduleControl scheduleControl = new ScheduleControl();
            LoadControl(scheduleControl);
        }

        private void LoadControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
            currentControl = control;
        }

        private void LoadReports()
        {
            List<Report> reports = reportsManager.GetAllReports();

            listBoxReports.DisplayMember = "Title"; 
            listBoxReports.DataSource = reports;
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            Report selectedReport = (Report)listBoxReports.SelectedItem;

            if (selectedReport != null)
            {
                MessageBox.Show($"Title: {selectedReport.Title}\n" +
                                $"Category: {selectedReport.Category}\n" +
                                $"Description: {selectedReport.Description}\n" +
                                $"Date Created: {selectedReport.DateCreated}\n" +
                                $"Created By: {selectedReport.CreatedBy.FirstName} {selectedReport.CreatedBy.LastName}");
            }
            else
            {
                MessageBox.Show("Please select a report to view.");
            }
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            ReportCategory category = (ReportCategory)Enum.Parse(typeof(ReportCategory), cboCategory.SelectedItem.ToString());
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please enter Title and Description.");
                return;
            }

            Report newReport = new Report(title, category, description, loggedInEmployee);

          /*  reportsManager.CreateReport(newReport);*/

            LoadReports();

            MessageBox.Show("Report created successfully.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!(currentControl is HomeControl))
            {
                LoadHomeControl();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (!(currentControl is ReportsControl))
            {
                LoadReportsControl();
            }
        }
    }
}
