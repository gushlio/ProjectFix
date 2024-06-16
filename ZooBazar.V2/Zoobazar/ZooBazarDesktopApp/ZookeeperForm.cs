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
    }
}
