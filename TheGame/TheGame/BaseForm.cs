using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using TheGame.Classes;
using TheGame.Classes.Characters;
using TheGame.Classes.Exceptions;
using TheGame.Classes.Items;

namespace TheGame
{
    public partial class BaseForm : Form
    {
        private string username;
        private int counter = 0;
        private int score = 0;
        private List<string> lines = new List<string>();
        private List<string> bots = new List<string> { "Ivailo", "Doncho", "Pesho", "Kukuruzcho", "Cvetko", "Urujcho", "Evstati", "007" };
        private Player player;
        Random random = new Random();
        public BaseForm()
        {
            InitializeComponent();
            panelTelerik.Hide();
            lblTelerikInfo.Hide();
            GetLines();
            btnRestore.Hide();
            timer1.Start();
            lblScore.Text = "0";
        }

        public BaseForm(Player player)
            : this()
        {

            this.player = player;
            FillPlayerInfo();

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
          

        }

        private void FillPlayerInfo()
        {
            string location = "";
            if (player.PlayerType == PlayerType.Gamer)
            {
                if (player.Gender == 'f')
                {
                    location = "1g";
                }
                else if (player.Gender == 'm')
                {
                    location = "1b";
                }
            }
            else if (player.PlayerType == PlayerType.Nerd)
            {
                if (player.Gender == 'f')
                {
                    location = "2g";
                }
                else if (player.Gender == 'm')
                {
                    location = "2b";
                }
            }
            else if (player.PlayerType == PlayerType.PartyMan)
            {
                if (player.Gender == 'f')
                {
                    location = "3g";
                }
                else if (player.Gender == 'm')
                {
                    location = "3b";
                }
            }
            this.picHero.ImageLocation = "../../images/" + location + ".jpg";


            lblName.Text = this.player.Name;

            label1.Text = player.Skills[0].Name;
            progresTime.Minimum = 0;
            progresTime.Maximum = this.player.Skills[0].BaseSkillValue;
            progresTime.Value = this.player.Skills[0].SkillCurrentValue;
            LblMax1.Text = player.Skills[0].SkillCurrentValue.ToString();


            progressBar1.Minimum = 0;
            progressBar1.Maximum = this.player.Skills[1].BaseSkillValue;
            progressBar1.Value = this.player.Skills[1].SkillCurrentValue;


            label2.Text = player.Skills[1].Name;
            progressBar2.Maximum = this.player.Skills[1].BaseSkillValue;
            progressBar2.Value = this.player.Skills[1].BaseSkillValue;
            label3.Text = player.Skills[1].SkillCurrentValue.ToString();

            label4.Text = player.Skills[2].Name;
            progressBar3.Minimum = 0;
            progressBar3.Maximum = this.player.Skills[2].BaseSkillValue;
            progressBar3.Value = this.player.Skills[2].BaseSkillValue;
            label5.Text = player.Skills[2].SkillCurrentValue.ToString();

            label6.Text = player.Skills[3].Name;
            progressBar4.Minimum = 0;
            progressBar4.Maximum = this.player.Skills[3].BaseSkillValue;
            progressBar4.Value = this.player.Skills[3].BaseSkillValue;
            label7.Text = player.Skills[3].SkillCurrentValue.ToString();

            label8.Text = player.Skills[4].Name;
            progressBar4.Minimum = 0;
            progressBar4.Maximum = this.player.Skills[4].BaseSkillValue;
            progressBar4.Value = this.player.Skills[4].BaseSkillValue;
            label9.Text = player.Skills[4].SkillCurrentValue.ToString();

            label10.Text = player.Skills[5].Name;
            progressBar5.Minimum = 0;
            progressBar5.Maximum = this.player.Skills[5].BaseSkillValue;
            progressBar5.Value = this.player.Skills[5].BaseSkillValue;
            label11.Text = player.Skills[5].SkillCurrentValue.ToString();


            label12.Text = player.Skills[6].Name;
            progressBar6.Minimum = 0;
            progressBar6.Maximum = this.player.Skills[6].BaseSkillValue;
            progressBar6.Value = this.player.Skills[6].BaseSkillValue;
            label13.Text = player.Skills[6].SkillCurrentValue.ToString();

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
                if (progressBar1.Value - int.Parse(gridQuests[3, row.Index].Value.ToString()) <= 0)
                {
                    MessageBox.Show(("No Enought Energy"));
                    btnRestore.Show();
                }
                else if (progresTime.Value - int.Parse(gridQuests[4, row.Index].Value.ToString()) <= 0)
                {
                    MessageBox.Show(("No Enought Time"));
                }
                else
                {
                    progressBar1.Value -= int.Parse(gridQuests[3, row.Index].Value.ToString());
                    progresTime.Value -= int.Parse(gridQuests[4, row.Index].Value.ToString());
                    gridQuests.SelectedCells[0].Value = "Done";
                    gridQuests.SelectedCells[0].Style.BackColor = SystemColors.MenuHighlight;

                    lblScore.Text = (int.Parse(lblScore.Text) + random.Next(1, 50)).ToString();
                }


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            lstChat.Items.Add(this.bots[random.Next(0, this.bots.Count)] + ":" + this.lines[random.Next(0, this.lines.Count)]);

            timer1.Interval = random.Next(2200, 5000);
            this.counter++;
            if (this.counter == 11)
            {
                lstChat.Items.Clear();
                this.counter = 0;
            }
        }

        private void GetLines()
        {
            StreamReader sr = new StreamReader("../../chat.txt");
            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    this.lines.Add(sr.ReadLine().ToString());
                }
            }
            sr.Close();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            panelTelerik.Hide();
            this.btnRestore.Hide();
            tabMarket.Show();
        }

        private void BaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataMarket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataMarket.Rows[e.RowIndex];


            if (dataMarket.SelectedCells[0].Value.ToString() == "Buy")
            {
                 progresTime.Value = ValidateBar(progresTime, int.Parse(dataMarket[1,row.Index].Value.ToString()),int.Parse(LblMax1.Text));

                 progressBar1.Value = ValidateBar(progressBar1, int.Parse(dataMarket[2, row.Index].Value.ToString()), int.Parse(label3.Text));

                 progressBar2.Value = ValidateBar(progressBar2, int.Parse(dataMarket[3, row.Index].Value.ToString()), int.Parse(label5.Text));
                 progressBar3.Value = ValidateBar(progressBar3, int.Parse(dataMarket[4, row.Index].Value.ToString()), int.Parse(label7.Text));
              


            }
        }

        private int ValidateBar(ProgressBar pbar, int val, int max)
        {
            int result = 0;
            if ((pbar.Value + val) > 0)
            {
                result = pbar.Value + val;
            }
            if ((pbar.Value + val) >= max)
            {
                result = max-1;
            }
            return result;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataMarket.Rows.Clear();
            this.GetFood();
            this.dataMarket.Show();
        }

        private void GetFood()
        {
            List<string[]> consumables = new List<string[]>();
            consumables = Parser.GetFood();
            foreach (var item in consumables)
            {
                dataMarket.Rows.Add(item[0],item[2],item[4],item[6],item[8],item[10],item[12],item[14], "Buy");
            }
        }

    }
}
