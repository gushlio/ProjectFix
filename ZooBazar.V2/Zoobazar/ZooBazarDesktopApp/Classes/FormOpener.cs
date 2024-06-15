using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Manager;

namespace ZooBazarDesktopApp.Classes
{
    public class FormOpener : IFormFactory
    {
        public EmployeeManager emp;
        public void OpenForm(string jobTitle)
        {
            Form form = null;

            switch (jobTitle)
            {
                case "Veterinarian":
                    form = new Animal();
                    break;
                case "Zookeeper":
                    form = new ZookeeperForm(emp);
                    break;
                case "AdministrativeStaff":
                    form = new MainForm();
                    break;
                default:
                    MessageBox.Show("Invalid job title. Please contact the administrator.");
                    return;
            }

            form.Show();
        }
    }
}
