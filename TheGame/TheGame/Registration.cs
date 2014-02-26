using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheGame.Classes.Characters;
using TheGame.Classes;
using TheGame.Classes.Items;
using TheGame.Classes.Actions;
namespace TheGame
{
    public partial class Registration : Form
    {
        private List<Skill> skills = new List<Skill>();
        private string userName;
        private PlayerType playerType;
        private char gender;

        public Registration()
        {
            InitializeComponent();
        }

        public Registration(string username):this()
        {
            this.userName = username;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.panel1.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.FillBoxes("gamer", "1b");
            RestoreLabelColor();
            ChangeLablColor(ref lblGamerBoy);
            this.playerType = PlayerType.Gamer;
            this.gender = 'm';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.FillBoxes("nerd", "2b");
            RestoreLabelColor();
            ChangeLablColor(ref lblNerdBoy);
            this.playerType = PlayerType.Nerd;
            this.gender = 'm';
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.FillBoxes("party", "3b");
            RestoreLabelColor();
            ChangeLablColor(ref lblPartyBoy);
            this.playerType = PlayerType.PartyMan;
            this.gender = 'm';
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.FillBoxes("gamer", "1g");
            RestoreLabelColor();
            ChangeLablColor(ref lblGamerGirl);
            this.playerType = PlayerType.Gamer;
            this.gender = 'f';
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.FillBoxes("nerd", "2g");
            RestoreLabelColor();
            ChangeLablColor(ref lblNerdGirl);
            this.playerType = PlayerType.Nerd;
            this.gender = 'f';
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.FillBoxes("party", "3g");
            RestoreLabelColor();
            ChangeLablColor(ref lblPartyGirl);
            this.playerType = PlayerType.PartyMan;
            this.gender = 'f';
        }

        private void FillBoxes(string file, string picture)
        {
            this.skills = Parser.GetAllSkills(file);
            StringBuilder output = new StringBuilder();
            grdSkills.Rows.Clear();

            foreach (var skill in skills)
            {
                grdSkills.Rows.Add(new string[] {skill.Name,skill.BaseSkillValue.ToString(),skill.SkillCurrentValue.ToString()});
            }
        
            this.txtInfo.Text = Files.GetSkills(file + "info");
            this.lblInfo.Text = "Information: " + file;
            this.pictureBox7.ImageLocation = "../../images/" + picture + ".jpg";
        }

        private void RestoreLabelColor()
        {
            this.lblGamerBoy.ForeColor = SystemColors.ControlText;
            this.lblNerdBoy.ForeColor = SystemColors.ControlText;
            this.lblPartyBoy.ForeColor = SystemColors.ControlText;
            this.lblGamerGirl.ForeColor = SystemColors.ControlText;
            this.lblNerdGirl.ForeColor = SystemColors.ControlText;
            this.lblPartyGirl.ForeColor = SystemColors.ControlText;

            this.lblGamerBoy.BackColor = SystemColors.Window;
            this.lblNerdBoy.BackColor = SystemColors.Window;
            this.lblPartyBoy.BackColor = SystemColors.Window;
            this.lblGamerGirl.BackColor = SystemColors.Window;
            this.lblNerdGirl.BackColor = SystemColors.Window;
            this.lblPartyGirl.BackColor = SystemColors.Window;

        }
        private void ChangeLablColor(ref Label lbl)
        {
            lbl.BackColor = SystemColors.HotTrack;
            lbl.ForeColor = SystemColors.Window;
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            this.panel1.BringToFront();
            this.panel1.Show();
            this.txtHeroName.Focus();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (this.txtHeroName.Text.Length > 2)
            {
                
                
                int numRows = grdSkills.Rows.Count;
                for (int i = 0; i < numRows; i++)
                {
                    skills.Add(new Skill(grdSkills[0, i].Value.ToString(), int.Parse(grdSkills[1, i].Value.ToString()), int.Parse(grdSkills[2, i].Value.ToString())));
                }
                List<Classes.Items.Item> itemList = new List<Classes.Items.Item>();
                List<Classes.Actions.Quest> quests = new List<Classes.Actions.Quest>();
                Player player = new Player(this.txtHeroName.Text,this.userName,0,0,skills,playerType,this.gender,new List<Item>(), 2, new List<Quest>() );
                Parser.SavePlayer(player);
                BaseForm form = new BaseForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The name can't be less 3 characters", "Too short name");
            }
        }

        private void CreateHero()
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtHeroName.Text = "";
            this.panel1.Hide();
        }

        private void grdSkills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
