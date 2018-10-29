namespace SportsAide
{
    partial class Form3
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.plyName = new System.Windows.Forms.Label();
            this.plyImgBox = new System.Windows.Forms.PictureBox();
            this.posText = new System.Windows.Forms.Label();
            this.activeText = new System.Windows.Forms.Label();
            this.factText = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statGoals = new System.Windows.Forms.Label();
            this.statAssists = new System.Windows.Forms.Label();
            this.statPlaytime = new System.Windows.Forms.Label();
            this.statIntercept = new System.Windows.Forms.Label();
            this.statTackles = new System.Windows.Forms.Label();
            this.statFouls = new System.Windows.Forms.Label();
            this.statOffside = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.statDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plyImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(15, 362);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 23);
            this.backBtn.TabIndex = 29;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Players";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 316);
            this.listBox1.TabIndex = 17;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(99, 362);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(80, 23);
            this.refreshBtn.TabIndex = 31;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // plyName
            // 
            this.plyName.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.plyName.Location = new System.Drawing.Point(389, 39);
            this.plyName.Name = "plyName";
            this.plyName.Size = new System.Drawing.Size(278, 36);
            this.plyName.TabIndex = 32;
            this.plyName.Text = "Select a Player";
            this.plyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plyImgBox
            // 
            this.plyImgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plyImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plyImgBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.plyImgBox.Location = new System.Drawing.Point(185, 40);
            this.plyImgBox.Name = "plyImgBox";
            this.plyImgBox.Size = new System.Drawing.Size(155, 200);
            this.plyImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plyImgBox.TabIndex = 33;
            this.plyImgBox.TabStop = false;
            // 
            // posText
            // 
            this.posText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posText.Location = new System.Drawing.Point(389, 73);
            this.posText.Name = "posText";
            this.posText.Size = new System.Drawing.Size(278, 25);
            this.posText.TabIndex = 34;
            this.posText.Text = "Position";
            this.posText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // activeText
            // 
            this.activeText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeText.Location = new System.Drawing.Point(389, 98);
            this.activeText.Name = "activeText";
            this.activeText.Size = new System.Drawing.Size(278, 25);
            this.activeText.TabIndex = 35;
            this.activeText.Text = "Active";
            this.activeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // factText
            // 
            this.factText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factText.Location = new System.Drawing.Point(346, 150);
            this.factText.Name = "factText";
            this.factText.Size = new System.Drawing.Size(361, 26);
            this.factText.TabIndex = 36;
            this.factText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGoal
            // 
            this.txtGoal.AutoSize = true;
            this.txtGoal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.Location = new System.Drawing.Point(345, 231);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(118, 19);
            this.txtGoal.TabIndex = 37;
            this.txtGoal.Text = "Goals Scored:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Playtime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(348, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Interceptions:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(628, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tackles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Fouls:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(623, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Offsides:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Goals Assisted:";
            // 
            // statGoals
            // 
            this.statGoals.AutoSize = true;
            this.statGoals.Font = new System.Drawing.Font("Arial", 12F);
            this.statGoals.Location = new System.Drawing.Point(469, 231);
            this.statGoals.Name = "statGoals";
            this.statGoals.Size = new System.Drawing.Size(0, 18);
            this.statGoals.TabIndex = 44;
            // 
            // statAssists
            // 
            this.statAssists.AutoSize = true;
            this.statAssists.Font = new System.Drawing.Font("Arial", 12F);
            this.statAssists.Location = new System.Drawing.Point(469, 274);
            this.statAssists.Name = "statAssists";
            this.statAssists.Size = new System.Drawing.Size(0, 18);
            this.statAssists.TabIndex = 45;
            // 
            // statPlaytime
            // 
            this.statPlaytime.AutoSize = true;
            this.statPlaytime.Font = new System.Drawing.Font("Arial", 12F);
            this.statPlaytime.Location = new System.Drawing.Point(469, 317);
            this.statPlaytime.Name = "statPlaytime";
            this.statPlaytime.Size = new System.Drawing.Size(0, 18);
            this.statPlaytime.TabIndex = 46;
            // 
            // statIntercept
            // 
            this.statIntercept.AutoSize = true;
            this.statIntercept.Font = new System.Drawing.Font("Arial", 12F);
            this.statIntercept.Location = new System.Drawing.Point(469, 361);
            this.statIntercept.Name = "statIntercept";
            this.statIntercept.Size = new System.Drawing.Size(0, 18);
            this.statIntercept.TabIndex = 47;
            // 
            // statTackles
            // 
            this.statTackles.AutoSize = true;
            this.statTackles.Font = new System.Drawing.Font("Arial", 12F);
            this.statTackles.Location = new System.Drawing.Point(707, 232);
            this.statTackles.Name = "statTackles";
            this.statTackles.Size = new System.Drawing.Size(0, 18);
            this.statTackles.TabIndex = 48;
            // 
            // statFouls
            // 
            this.statFouls.AutoSize = true;
            this.statFouls.Font = new System.Drawing.Font("Arial", 12F);
            this.statFouls.Location = new System.Drawing.Point(707, 276);
            this.statFouls.Name = "statFouls";
            this.statFouls.Size = new System.Drawing.Size(0, 18);
            this.statFouls.TabIndex = 49;
            // 
            // statOffside
            // 
            this.statOffside.AutoSize = true;
            this.statOffside.Font = new System.Drawing.Font("Arial", 12F);
            this.statOffside.Location = new System.Drawing.Point(707, 318);
            this.statOffside.Name = "statOffside";
            this.statOffside.Size = new System.Drawing.Size(0, 18);
            this.statOffside.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Distance Travelled:";
            // 
            // statDistance
            // 
            this.statDistance.AutoSize = true;
            this.statDistance.Font = new System.Drawing.Font("Arial", 12F);
            this.statDistance.Location = new System.Drawing.Point(707, 360);
            this.statDistance.Name = "statDistance";
            this.statDistance.Size = new System.Drawing.Size(0, 18);
            this.statDistance.TabIndex = 52;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 398);
            this.Controls.Add(this.statDistance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statOffside);
            this.Controls.Add(this.statFouls);
            this.Controls.Add(this.statTackles);
            this.Controls.Add(this.statIntercept);
            this.Controls.Add(this.statPlaytime);
            this.Controls.Add(this.statAssists);
            this.Controls.Add(this.statGoals);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGoal);
            this.Controls.Add(this.factText);
            this.Controls.Add(this.activeText);
            this.Controls.Add(this.posText);
            this.Controls.Add(this.plyImgBox);
            this.Controls.Add(this.plyName);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form3";
            this.Text = "Tracker";
            this.Activated += new System.EventHandler(this.StatsMenu_Activated);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plyImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label plyName;
        private System.Windows.Forms.PictureBox plyImgBox;
        private System.Windows.Forms.Label posText;
        private System.Windows.Forms.Label activeText;
        private System.Windows.Forms.Label factText;
        private System.Windows.Forms.Label txtGoal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statGoals;
        private System.Windows.Forms.Label statAssists;
        private System.Windows.Forms.Label statPlaytime;
        private System.Windows.Forms.Label statIntercept;
        private System.Windows.Forms.Label statTackles;
        private System.Windows.Forms.Label statFouls;
        private System.Windows.Forms.Label statOffside;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statDistance;
    }
}