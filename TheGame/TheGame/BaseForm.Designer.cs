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
            this.dgPlayerStats = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgChat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabHome.SuspendLayout();
            this.panelTelerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTelerik)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panelHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuests)).BeginInit();
            this.SuspendLayout();
            // 
            // tabHome
            // 
            this.tabHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabHome.BackgroundImage")));
            this.tabHome.Controls.Add(this.panelTelerik);
            this.tabHome.Controls.Add(this.lblTelerikInfo);
            this.tabHome.Controls.Add(this.picBoxTelerik);
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
            this.panelHero.Controls.Add(this.lblSkills);
            this.panelHero.Controls.Add(this.dgPlayerStats);
            this.panelHero.Controls.Add(this.dgChat);
            this.panelHero.Controls.Add(this.picHero);
            this.panelHero.Location = new System.Drawing.Point(3, 34);
            this.panelHero.Name = "panelHero";
            this.panelHero.Size = new System.Drawing.Size(297, 603);
            this.panelHero.TabIndex = 1;
            // 
            // dgPlayerStats
            // 
            this.dgPlayerStats.AllowUserToAddRows = false;
            this.dgPlayerStats.AllowUserToDeleteRows = false;
            this.dgPlayerStats.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgPlayerStats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPlayerStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayerStats.ColumnHeadersVisible = false;
            this.dgPlayerStats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgPlayerStats.GridColor = System.Drawing.Color.OliveDrab;
            this.dgPlayerStats.Location = new System.Drawing.Point(9, 255);
            this.dgPlayerStats.Name = "dgPlayerStats";
            this.dgPlayerStats.ReadOnly = true;
            this.dgPlayerStats.Size = new System.Drawing.Size(284, 150);
            this.dgPlayerStats.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Skill";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Value";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // dgChat
            // 
            this.dgChat.AllowUserToAddRows = false;
            this.dgChat.AllowUserToDeleteRows = false;
            this.dgChat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgChat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChat.ColumnHeadersVisible = false;
            this.dgChat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgChat.GridColor = System.Drawing.Color.OliveDrab;
            this.dgChat.Location = new System.Drawing.Point(3, 450);
            this.dgChat.Name = "dgChat";
            this.dgChat.ReadOnly = true;
            this.dgChat.Size = new System.Drawing.Size(284, 150);
            this.dgChat.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Message";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // picHero
            // 
            this.picHero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHero.Location = new System.Drawing.Point(10, 16);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(137, 189);
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
            this.gridQuests.Location = new System.Drawing.Point(147, 80);
            this.gridQuests.Name = "gridQuests";
            this.gridQuests.ReadOnly = true;
            this.gridQuests.Size = new System.Drawing.Size(710, 284);
            this.gridQuests.TabIndex = 3;
            this.gridQuests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridQuests_CellContentClick);
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSkills.Location = new System.Drawing.Point(10, 236);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChat)).EndInit();
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
        private System.Windows.Forms.DataGridView dgChat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView dgPlayerStats;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
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

    }
}

