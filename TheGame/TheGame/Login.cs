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
           // Files.ReadUsersFromFile(this.txtUserName.Text, this.txtPassword.Text).ToString()));
            this.lblErrorMessage.Text = Validation.IsCorrectLogin(this.txtUserName.Text.ToString(), this.txtPassword.Text.ToString());
        }

      
    }
}
