using Domain.Entity;
using Domain.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooBazarDesktopApp
{
    public partial class SignUp : Form
    {
        string firstName;
        string lastName;
        string password;
        string email;
        string bsn;
        string phoneNumber;
        string address;
        string emergencyContactInfo;
        string emergencyContactRelationship;
        string dateOfBirth;
        string username;
        int rowCount;
        RegularExpression regex;
        EmployeeManager em;

        public SignUp()
        {
            regex = new RegularExpression();
            em = new EmployeeManager();
            InitializeComponent();
        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            password = txtPassword.Text;
            email = txtEmail.Text;
            phoneNumber = txtPhoneNumber.Text;
            address = txtAddress.Text;
            dateOfBirth = txtDateOfBirth.Text;
            bsn = txtBSN.Text;
            if (firstName != "" && lastName != "" && password != "" && email != "" && phoneNumber != "" && address != ""  && bsn != "")
            {
                if (regex.regexEmail.IsMatch(email))
                {
                    if (phoneNumber.Length <= 15 && regex.regexPhone.IsMatch(phoneNumber))
                    {
                        if (password.Length >= 8)
                        {
                            if (regex.regexBirthday.IsMatch(dateOfBirth))
                            {
                                if (regex.regexBsn.IsMatch(bsn))
                                {
                                    em.AddEmployee(firstName, lastName, password, email, dateOfBirth, phoneNumber, bsn, address);

                                    Employee newEmployee = em.GetEmployeeByEmail(email);

                                    ZooKeeperForm mainForm = new ZooKeeperForm(newEmployee);
                                    this.Hide();
                                    mainForm.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("BSN is inputted incorrectly.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Date of birth is inputted incorrectly.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be at least 8 characters long.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone number is inputted incorrectly.");
                    }
                }
                else
                {
                    MessageBox.Show("Email is inputted incorrectly.");
                }

            }
            else
            {
                MessageBox.Show("Some of the required fields are empty.");
            }
        }
    }
}
