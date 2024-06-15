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

namespace ZooBazarDesktopApp.UserControls
{
    public partial class ReportsControl : UserControl
    {
        private ReportManager reportsManager;
        private Employee loggedInEmployee;
        public ReportsControl(Employee employee)
        {
            InitializeComponent();
            loggedInEmployee = employee;
            reportsManager = new ReportManager();

            // Load reports when the control loads
            LoadReports();
        }

        private void LoadReports()
        {
            listBoxReports.Items.Clear();

            List<Report> reports = reportsManager.GetAllReports();
            foreach (var report in reports)
            {
                listBoxReports.Items.Add($"{report.Title} - {report.DateCreated.ToShortDateString()}");
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

            if (loggedInEmployee == null)
            {
                MessageBox.Show("Error: No logged-in user found. Please log in again.");
                return;
            }

            Report newReport = new Report(title, category, description, loggedInEmployee);

            // Save new report using ReportsManager
            reportsManager.CreateReport(title, category, description, loggedInEmployee);

            // Reload reports in ListBox after creating
            LoadReports();

            MessageBox.Show("Report created successfully.");
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            if (listBoxReports.SelectedIndex >= 0)
            {
                int selectedReportIndex = listBoxReports.SelectedIndex;
                List<Report> reports = reportsManager.GetAllReports();
                Report selectedReport = reports[selectedReportIndex];

                string reportDetails = $"Title: {selectedReport.Title}\n" +
                                       $"Category: {selectedReport.Category}\n" +
                                       $"Description: {selectedReport.Description}\n" +
                                       $"Date Created: {selectedReport.DateCreated}\n" +
                                       $"Created By: {selectedReport.CreatedBy.FirstName} {selectedReport.CreatedBy.LastName}";

                MessageBox.Show(reportDetails, "Report Details");
            }
            else
            {
                MessageBox.Show("Please select a report to view.");
            }
        }
    }
}
