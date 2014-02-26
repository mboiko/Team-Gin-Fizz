using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheGame.Classes;

namespace TheGame
{
    public partial class BaseForm : Form
    {
        private string username;
        public BaseForm()
        {
            InitializeComponent();
            panelTelerik.Hide();
            lblTelerikInfo.Hide();
        }

        public BaseForm(string username):this()
        {
         
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
            List<TheGame.Classes.Actions.Quest> quests = new List<Classes.Actions.Quest>();
            Random random = new Random();
           
            quests = Parser.GetAllQuests();
            int counter = 1;
            foreach (var quest in quests)
            {
                string[] words = quest.ToString().Split('|');
                gridQuests.Rows.Add(counter++, words[0], words[2], words[4], random.Next(10, 200), words[6], "Do the quest");    
            }
            
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

        private void gridQuests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.gridQuests.Rows[e.RowIndex];
         
            if (gridQuests.SelectedCells[0].Value.ToString() == "Do the quest")
            {
                gridQuests.SelectedCells[0].Value = "Done";
                gridQuests.SelectedCells[0].Style.BackColor = SystemColors.GrayText;
            }
        }
        

    }
}
