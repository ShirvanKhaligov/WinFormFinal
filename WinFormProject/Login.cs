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
    public partial class LoginForm : Form
    {
        private LibraryEntities db;
        private Users usr;
        public LoginForm()
        {
            InitializeComponent();
            db = new LibraryEntities();
            usr = new Users();
        }

        private void btnLoginRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.ShowDialog();

        }

        private void btnLoginlogin_Click(object sender, EventArgs e)
        {
            string email = TxtLoginEmail.Text.Trim();
            string password = txtLoginPassword.Text.Trim();
           if( CheckLogin(email, password))
            {
                if (usr.Levels)
                {
                    new AdminDashBoard(this, usr).Show();
                }
                else
                {
                    new UserDashBoard(this, usr).Show();
                }
            }

        }
        private bool CheckLogin(string email,string pass)
        {
            if(email==""|| pass == "")
            {
                MessageBox.Show("Fill All Inputs");
                return false;
            }

            string hashpass = Helpers.HashCode(pass);
            usr = db.Users.Where(u => u.Email == email).Where(u => u.Password == hashpass).Where(u=>u.Delete==false).FirstOrDefault();

            if (usr == null)
            {
                MessageBox.Show("This user not Found", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (usr.Status == false)
            {
                MessageBox.Show("User not confirm", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            

            return true;
        }
    }
}
