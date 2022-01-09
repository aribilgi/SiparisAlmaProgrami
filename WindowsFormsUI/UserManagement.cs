using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace WindowsFormsUI
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }
        UserManager manager = new UserManager();
        private void UserManagement_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = manager.GetAll();
        }
    }
}
