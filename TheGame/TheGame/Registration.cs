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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
           
            // pictureBox1.ImageLocation ="../../images/nerdgirl.jpg";
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string box = Files.GetSkills("gamer");
            this.textBox1.Text = box;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string box = Files.GetSkills("nerd");
            this.textBox1.Text = box;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string box = Files.GetSkills("party");
            this.textBox1.Text = box;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string box = Files.GetSkills("gamer");
            this.textBox1.Text = box;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string box = Files.GetSkills("nerd");
            this.textBox1.Text = box;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string box = Files.GetSkills("party");
            this.textBox1.Text = box;
        }

    }
}
