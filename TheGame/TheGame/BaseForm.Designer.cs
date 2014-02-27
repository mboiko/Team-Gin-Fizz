namespace TheGame
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.panelTelerik = new System.Windows.Forms.Panel();
            this.lblTelerikInfo = new System.Windows.Forms.Label();
            this.picBoxTelerik = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panelHero = new System.Windows.Forms.Panel();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.gridQuests = new System.Windows.Forms.DataGridView();
            this.lblSkills = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblChooseMission = new System.Windows.Forms.Label();
            this.lblChat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstChat = new System.Windows.Forms.ListBox();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.progresTime = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMax1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.btnRestore = new System.Windows.Forms.Button();
            this.tabHome.SuspendLayout();
            this.panelTelerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelerik)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panelHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHome
            // 
            this.tabHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHome.BackgroundImage")));
            this.tabHome.Controls.Add(this.btnRestore);
            this.tabHome.Controls.Add(this.panelTelerik);
            this.tabHome.Controls.Add(this.lblTelerikInfo);
            this.tabHome.Controls.Add(this.picBoxTelerik);
            this.tabHome.Controls.Add(this.lstChat);
            this.tabHome.Controls.Add(this.lblChat);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(866, 603);
            this.tabHome.TabIndex = 1;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            this.tabHome.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // panelTelerik
            // 
            this.panelTelerik.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTelerik.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelTelerik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTelerik.BackgroundImage")));
            this.panelTelerik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTelerik.Controls.Add(this.lblChooseMission);
            this.panelTelerik.Controls.Add(this.gridQuests);
            this.panelTelerik.Location = new System.Drawing.Point(6, 63);
            this.panelTelerik.Name = "panelTelerik";
            this.panelTelerik.Size = new System.Drawing.Size(860, 367);
            this.panelTelerik.TabIndex = 5;
            this.panelTelerik.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTelerik_Paint);
            // 
            // lblTelerikInfo
            // 
            this.lblTelerikInfo.AutoSize = true;
            this.lblTelerikInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTelerikInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTelerikInfo.ForeColor = System.Drawing.Color.Red;
            this.lblTelerikInfo.Location = new System.Drawing.Point(244, 298);
            this.lblTelerikInfo.Name = "lblTelerikInfo";
            this.lblTelerikInfo.Size = new System.Drawing.Size(204, 25);
            this.lblTelerikInfo.TabIndex = 4;
            this.lblTelerikInfo.Text = "Click to Get Mission";
            this.lblTelerikInfo.Visible = false;
            // 
            // picBoxTelerik
            // 
            this.picBoxTelerik.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTelerik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxTelerik.Location = new System.Drawing.Point(244, 331);
            this.picBoxTelerik.Name = "picBoxTelerik";
            this.picBoxTelerik.Size = new System.Drawing.Size(250, 154);
            this.picBoxTelerik.TabIndex = 3;
            this.picBoxTelerik.TabStop = false;
            this.picBoxTelerik.Click += new System.EventHandler(this.picBoxTelerik_Click);
            this.picBoxTelerik.MouseLeave += new System.EventHandler(this.picBoxTelerik_MouseLeave);
            this.picBoxTelerik.MouseHover += new System.EventHandler(this.picBoxTelerik_MouseHover);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControl1.Location = new System.Drawing.Point(306, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(874, 629);
            this.tabControl1.TabIndex = 0;
            // 
            // panelHero
            // 
            this.panelHero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHero.Controls.Add(this.label12);
            this.panelHero.Controls.Add(this.label13);
            this.panelHero.Controls.Add(this.progressBar6);
            this.panelHero.Controls.Add(this.label10);
            this.panelHero.Controls.Add(this.label11);
            this.panelHero.Controls.Add(this.progressBar5);
            this.panelHero.Controls.Add(this.label9);
            this.panelHero.Controls.Add(this.label8);
            this.panelHero.Controls.Add(this.label7);
            this.panelHero.Controls.Add(this.label6);
            this.panelHero.Controls.Add(this.label5);
            this.panelHero.Controls.Add(this.label4);
            this.panelHero.Controls.Add(this.label3);
            this.panelHero.Controls.Add(this.LblMax1);
            this.panelHero.Controls.Add(this.label2);
            this.panelHero.Controls.Add(this.label1);
            this.panelHero.Controls.Add(this.progressBar4);
            this.panelHero.Controls.Add(this.progressBar3);
            this.panelHero.Controls.Add(this.progressBar2);
            this.panelHero.Controls.Add(this.progressBar1);
            this.panelHero.Controls.Add(this.progresTime);
            this.panelHero.Controls.Add(this.lblName);
            this.panelHero.Controls.Add(this.lblNameInfo);
            this.panelHero.Controls.Add(this.lblSkills);
            this.panelHero.Controls.Add(this.picHero);
            this.panelHero.Location = new System.Drawing.Point(3, 34);
            this.panelHero.Name = "panelHero";
            this.panelHero.Size = new System.Drawing.Size(297, 603);
            this.panelHero.TabIndex = 1;
            // 
            // picHero
            // 
            this.picHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHero.Location = new System.Drawing.Point(10, 16);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(103, 122);
            this.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHero.TabIndex = 0;
            this.picHero.TabStop = false;
            // 
            // gridQuests
            // 
            this.gridQuests.AllowUserToAddRows = false;
            this.gridQuests.AllowUserToDeleteRows = false;
            this.gridQuests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridQuests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridQuests.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.gridQuests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.gridQuests.GridColor = System.Drawing.Color.OliveDrab;
            this.gridQuests.Location = new System.Drawing.Point(141, 80);
            this.gridQuests.Name = "gridQuests";
            this.gridQuests.ReadOnly = true;
            this.gridQuests.Size = new System.Drawing.Size(716, 284);
            this.gridQuests.TabIndex = 3;
            this.gridQuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridQuests_CellContentClick);
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkills.Location = new System.Drawing.Point(7, 151);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(49, 18);
            this.lblSkills.TabIndex = 3;
            this.lblSkills.Text = "Skills";
            // 
            // Column5
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 40;
            // 
            // Column6
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Type";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 56;
            // 
            // Column7
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "Description";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 85;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.HeaderText = "Energy Costs";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 94;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column9.HeaderText = "Time Costs";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 84;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Rewards";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 74;
            // 
            // Column11
            // 
            this.Column11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column11.HeaderText = "Status";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column11.Width = 62;
            // 
            // lblChooseMission
            // 
            this.lblChooseMission.AutoSize = true;
            this.lblChooseMission.BackColor = System.Drawing.Color.Transparent;
            this.lblChooseMission.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChooseMission.ForeColor = System.Drawing.Color.White;
            this.lblChooseMission.Location = new System.Drawing.Point(332, 36);
            this.lblChooseMission.Name = "lblChooseMission";
            this.lblChooseMission.Size = new System.Drawing.Size(269, 39);
            this.lblChooseMission.TabIndex = 4;
            this.lblChooseMission.Text = "Choose a quest";
            // 
            // lblChat
            // 
            this.lblChat.AutoSize = true;
            this.lblChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChat.Location = new System.Drawing.Point(571, 455);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(43, 18);
            this.lblChat.TabIndex = 4;
            this.lblChat.Text = "Chat";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstChat
            // 
            this.lstChat.FormattingEnabled = true;
            this.lstChat.Location = new System.Drawing.Point(574, 476);
            this.lstChat.MultiColumn = true;
            this.lstChat.Name = "lstChat";
            this.lstChat.Size = new System.Drawing.Size(289, 121);
            this.lstChat.TabIndex = 5;
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameInfo.Location = new System.Drawing.Point(167, 16);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(75, 25);
            this.lblNameInfo.TabIndex = 6;
            this.lblNameInfo.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(153, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 22);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "label1";
            // 
            // progresTime
            // 
            this.progresTime.BackColor = System.Drawing.SystemColors.Control;
            this.progresTime.ForeColor = System.Drawing.Color.Yellow;
            this.progresTime.Location = new System.Drawing.Point(10, 193);
            this.progresTime.Name = "progresTime";
            this.progresTime.Size = new System.Drawing.Size(251, 15);
            this.progresTime.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.ForeColor = System.Drawing.Color.DeepPink;
            this.progressBar1.Location = new System.Drawing.Point(10, 230);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 15);
            this.progressBar1.TabIndex = 9;
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar2.ForeColor = System.Drawing.Color.ForestGreen;
            this.progressBar2.Location = new System.Drawing.Point(10, 261);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(251, 15);
            this.progressBar2.TabIndex = 10;
            // 
            // progressBar3
            // 
            this.progressBar3.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar3.ForeColor = System.Drawing.Color.Aquamarine;
            this.progressBar3.Location = new System.Drawing.Point(10, 298);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(251, 15);
            this.progressBar3.TabIndex = 11;
            // 
            // progressBar4
            // 
            this.progressBar4.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar4.ForeColor = System.Drawing.Color.Blue;
            this.progressBar4.Location = new System.Drawing.Point(10, 333);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(251, 15);
            this.progressBar4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "lbl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "lbl";
            // 
            // LblMax1
            // 
            this.LblMax1.AutoSize = true;
            this.LblMax1.Location = new System.Drawing.Point(244, 173);
            this.LblMax1.Name = "LblMax1";
            this.LblMax1.Size = new System.Drawing.Size(17, 13);
            this.LblMax1.TabIndex = 15;
            this.LblMax1.Text = "lbl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "lbl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "lbl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "lbl";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "lbl";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "lbl";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "lbl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "lbl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "lbl";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(244, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "lbl";
            // 
            // progressBar5
            // 
            this.progressBar5.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar5.ForeColor = System.Drawing.Color.DarkOrchid;
            this.progressBar5.Location = new System.Drawing.Point(10, 365);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(251, 15);
            this.progressBar5.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "lbl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(244, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "lbl";
            // 
            // progressBar6
            // 
            this.progressBar6.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar6.ForeColor = System.Drawing.Color.Magenta;
            this.progressBar6.Location = new System.Drawing.Point(10, 396);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(251, 15);
            this.progressBar6.TabIndex = 26;
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.ForeColor = System.Drawing.Color.Red;
            this.btnRestore.Location = new System.Drawing.Point(6, 548);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(192, 49);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Buy some food for more energy";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 653);
            this.Controls.Add(this.panelHero);
            this.Controls.Add(this.tabControl1);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!!!";
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.panelTelerik.ResumeLayout(false);
            this.panelTelerik.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelerik)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panelHero.ResumeLayout(false);
            this.panelHero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuests)).EndInit();
            this.ResumeLayout(false);

        }

     

        #endregion

        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox picBoxTelerik;
        private System.Windows.Forms.Label lblTelerikInfo;
        private System.Windows.Forms.Panel panelTelerik;
        private System.Windows.Forms.Panel panelHero;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.DataGridView gridQuests;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column11;
        private System.Windows.Forms.Label lblChooseMission;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstChat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.ProgressBar progresTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMax1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Button btnRestore;

    }
}

