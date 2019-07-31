using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.Model;

namespace WinFormProject
{
    public partial class UserDashBoard : Form
    {
        private Form _login;
        private Users _user;
        public UserDashBoard(Form login, Users usr)
        {
            InitializeComponent();
            _login = login;
            _user = usr;
        }

        private void UserDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private void UserDashBoard_Load(object sender, EventArgs e)
        {
            _login.Hide();
        }
    }
}
