using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheGame
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //BaseForm form1 = new BaseForm();
            //form1.Show();
          
           if(!Files.ReadUsersFromFile(this.txtUserName.Text, this.txtPassword.Text))
            {
              this.lblErrorMessage.Text = "User name or Password are incorrect!";
            }

            this.lblErrorMessage.Text = Validation.IsCorrectLogin(this.txtUserName.Text.ToString(), this.txtPassword.Text.ToString());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
              Registration registration = new Registration();
              registration.Show();
              this.Hide();
        }

      
    }
}
