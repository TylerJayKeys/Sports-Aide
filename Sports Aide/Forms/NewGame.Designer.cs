namespace Sports_Aide.Forms
{
    partial class NewGame
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
            this.btnTackle = new System.Windows.Forms.Button();
            this.btnFoul = new System.Windows.Forms.Button();
            this.btnOffside = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPlaytime = new System.Windows.Forms.Button();
            this.btnAssist = new System.Windows.Forms.Button();
            this.btnDist = new System.Windows.Forms.Button();
            this.btnGoal = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gameDate = new System.Windows.Forms.DateTimePicker();
            this.numDist = new System.Windows.Forms.NumericUpDown();
            this.numPlayTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTackle
            // 
            this.btnTackle.Location = new System.Drawing.Point(195, 218);
            this.btnTackle.Name = "btnTackle";
            this.btnTackle.Size = new System.Drawing.Size(73, 23);
            this.btnTackle.TabIndex = 55;
            this.btnTackle.Tag = "tackles";
            this.btnTackle.Text = "Add Tackle";
            this.btnTackle.UseVisualStyleBackColor = true;
            this.btnTackle.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // btnFoul
            // 
            this.btnFoul.Location = new System.Drawing.Point(195, 160);
            this.btnFoul.Name = "btnFoul";
            this.btnFoul.Size = new System.Drawing.Size(73, 23);
            this.btnFoul.TabIndex = 54;
            this.btnFoul.Tag = "fouls";
            this.btnFoul.Text = "Add Foul";
            this.btnFoul.UseVisualStyleBackColor = true;
            this.btnFoul.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // btnOffside
            // 
            this.btnOffside.Location = new System.Drawing.Point(195, 247);
            this.btnOffside.Name = "btnOffside";
            this.btnOffside.Size = new System.Drawing.Size(73, 23);
            this.btnOffside.TabIndex = 53;
            this.btnOffside.Tag = "offsides";
            this.btnOffside.Text = "Add Offside";
            this.btnOffside.UseVisualStyleBackColor = true;
            this.btnOffside.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(188, 189);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(89, 23);
            this.btnInt.TabIndex = 52;
            this.btnInt.Tag = "interceptions";
            this.btnInt.Text = "Add Intercept";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 102);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Tag = "saved";
            this.btnSave.Text = "Add Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // btnPlaytime
            // 
            this.btnPlaytime.Location = new System.Drawing.Point(321, 222);
            this.btnPlaytime.Name = "btnPlaytime";
            this.btnPlaytime.Size = new System.Drawing.Size(100, 23);
            this.btnPlaytime.TabIndex = 50;
            this.btnPlaytime.Tag = "playtime";
            this.btnPlaytime.Text = "Add Playtime (m)";
            this.btnPlaytime.UseVisualStyleBackColor = true;
            this.btnPlaytime.Click += new System.EventHandler(this.btnPlaytime_Click);
            // 
            // btnAssist
            // 
            this.btnAssist.Location = new System.Drawing.Point(195, 131);
            this.btnAssist.Name = "btnAssist";
            this.btnAssist.Size = new System.Drawing.Size(73, 23);
            this.btnAssist.TabIndex = 49;
            this.btnAssist.Tag = "assists";
            this.btnAssist.Text = "Add Assist";
            this.btnAssist.UseVisualStyleBackColor = true;
            this.btnAssist.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // btnDist
            // 
            this.btnDist.Location = new System.Drawing.Point(321, 131);
            this.btnDist.Name = "btnDist";
            this.btnDist.Size = new System.Drawing.Size(100, 23);
            this.btnDist.TabIndex = 48;
            this.btnDist.Tag = "";
            this.btnDist.Text = "Add Distance (m)";
            this.btnDist.UseVisualStyleBackColor = true;
            this.btnDist.Click += new System.EventHandler(this.btnDist_Click);
            // 
            // btnGoal
            // 
            this.btnGoal.Location = new System.Drawing.Point(193, 73);
            this.btnGoal.Name = "btnGoal";
            this.btnGoal.Size = new System.Drawing.Size(75, 23);
            this.btnGoal.TabIndex = 47;
            this.btnGoal.Tag = "goals";
            this.btnGoal.Text = "Add Goal";
            this.btnGoal.UseVisualStyleBackColor = true;
            this.btnGoal.Click += new System.EventHandler(this.statBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(96, 278);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(80, 23);
            this.refreshBtn.TabIndex = 46;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(12, 278);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 23);
            this.backBtn.TabIndex = 45;
            this.backBtn.Text = "Done";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "New Game";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 225);
            this.listBox1.TabIndex = 43;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gameDate
            // 
            this.gameDate.CustomFormat = "dd-MM-yyyy";
            this.gameDate.Location = new System.Drawing.Point(195, 46);
            this.gameDate.Name = "gameDate";
            this.gameDate.Size = new System.Drawing.Size(200, 20);
            this.gameDate.TabIndex = 58;
            this.gameDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numDist
            // 
            this.numDist.Location = new System.Drawing.Point(321, 105);
            this.numDist.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numDist.Name = "numDist";
            this.numDist.Size = new System.Drawing.Size(100, 20);
            this.numDist.TabIndex = 59;
            // 
            // numPlayTime
            // 
            this.numPlayTime.Location = new System.Drawing.Point(321, 194);
            this.numPlayTime.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPlayTime.Name = "numPlayTime";
            this.numPlayTime.Size = new System.Drawing.Size(100, 20);
            this.numPlayTime.TabIndex = 60;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 311);
            this.Controls.Add(this.numPlayTime);
            this.Controls.Add(this.numDist);
            this.Controls.Add(this.gameDate);
            this.Controls.Add(this.btnTackle);
            this.Controls.Add(this.btnFoul);
            this.Controls.Add(this.btnOffside);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPlaytime);
            this.Controls.Add(this.btnAssist);
            this.Controls.Add(this.btnDist);
            this.Controls.Add(this.btnGoal);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "NewGame";
            this.Text = "NewGame";
            this.Activated += new System.EventHandler(this.NewGame_Activated);
            this.Deactivate += new System.EventHandler(this.StatsMenu_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.numDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTackle;
        private System.Windows.Forms.Button btnFoul;
        private System.Windows.Forms.Button btnOffside;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPlaytime;
        private System.Windows.Forms.Button btnAssist;
        private System.Windows.Forms.Button btnDist;
        private System.Windows.Forms.Button btnGoal;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker gameDate;
        private System.Windows.Forms.NumericUpDown numDist;
        private System.Windows.Forms.NumericUpDown numPlayTime;
    }
}