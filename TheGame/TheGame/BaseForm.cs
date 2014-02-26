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
    public partial class BaseForm : Form
    {
        private string username;
        public BaseForm()
        {
            InitializeComponent();
         
        }

        public BaseForm(string username):this()
        {
            panelTelerik.Hide();
            lblTelerikInfo.Hide();
            this.username = username;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void picBoxTelerik_Click(object sender, EventArgs e)
        {
            panelTelerik.Show();
        }
        void picBoxTelerik_MouseHover(object sender, System.EventArgs e)
        {
            lblTelerikInfo.Show();
        }
        void picBoxTelerik_MouseLeave(object sender, System.EventArgs e)
        {
            lblTelerikInfo.Hide();
        }

        private void panelTelerik_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
