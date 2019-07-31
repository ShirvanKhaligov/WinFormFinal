using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.Model;

namespace WinFormProject
{
    public partial class Register : Form
    {
        private LibraryEntities db;
        private Form _login;
        public Register(Form login)
        {
            InitializeComponent();
            _login = login;
            db = new LibraryEntities();

        }

        private void Register_Load(object sender, EventArgs e)
        {
            _login.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {

            string name = txtrgsName.Text.Trim();
            string surname = txtrgssurname.Text.Trim();
            string password = txtpaswwordRegister.Text.Trim();
            string email = txtRgsEmail.Text.Trim();
            string repeatpass = txtRgsRptPassword.Text.Trim();
            if(CheckRegistration(name, surname, password, email, repeatpass))
            {
                string hashPassword = Helpers.HashCode(password);
                Users user = new Users()
                {
                    Name = name,
                    Surname = surname,
                    Password=hashPassword,
                    Email=email
                };
                db.Users.Add(user);
                await db.SaveChangesAsync();
                MessageBox.Show("You Registered");
                txtpaswwordRegister.Text = "";
                txtRgsEmail.Text = "";
                txtrgsName.Text = "";
                txtRgsRptPassword.Text = "";
                txtrgssurname.Text = "";
            }
        }
        private bool CheckRegistration(string name, string surname, string password, string email, string repeatpass)
        {

            if (name == "" || surname == "" || password == "" || email == "" || repeatpass == "")
            {
                MessageBox.Show("Fill All Input", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (password != repeatpass)
            {
                MessageBox.Show("Kodlari eyni yazda aye", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                MailAddress mail = new MailAddress(email);
            }
            catch 
            {
                return false;
            }
            if (db.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("This mail already exist", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            return true;
        }
        
    }
}
