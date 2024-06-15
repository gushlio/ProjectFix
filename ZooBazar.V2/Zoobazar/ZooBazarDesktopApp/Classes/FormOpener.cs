using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace ZooBazarDesktopApp.Classes
{
    public class FormOpener : IFormFactory
    {
        public void OpenForm(string jobTitle)
        {
            Form form = null;

            switch (jobTitle)
            {
                case "Veterinarian":
                    form = new Animal();
                    break;
                case "Zookeeper":
                    form = new MainForm();
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
