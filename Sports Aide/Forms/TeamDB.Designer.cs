namespace SportsAide
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rmbtn = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.plyname = new System.Windows.Forms.TextBox();
            this.plyImgBox = new System.Windows.Forms.PictureBox();
            this.plyLabel = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plyImgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(164, 381);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Players";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rmbtn
            // 
            this.rmbtn.Location = new System.Drawing.Point(96, 438);
            this.rmbtn.Name = "rmbtn";
            this.rmbtn.Size = new System.Drawing.Size(80, 23);
            this.rmbtn.TabIndex = 18;
            this.rmbtn.Text = "Remove";
            this.rmbtn.UseVisualStyleBackColor = true;
            this.rmbtn.Click += new System.EventHandler(this.rmbtn_Click);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(12, 438);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(80, 23);
            this.addBTN.TabIndex = 17;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // plyname
            // 
            this.plyname.Location = new System.Drawing.Point(12, 407);
            this.plyname.Name = "plyname";
            this.plyname.Size = new System.Drawing.Size(164, 20);
            this.plyname.TabIndex = 19;
            this.plyname.Text = "Player Name";
            // 
            // plyImgBox
            // 
            this.plyImgBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.plyImgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plyImgBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.plyImgBox.Location = new System.Drawing.Point(194, 44);
            this.plyImgBox.Name = "plyImgBox";
            this.plyImgBox.Size = new System.Drawing.Size(155, 200);
            this.plyImgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plyImgBox.TabIndex = 20;
            this.plyImgBox.TabStop = false;
            // 
            // plyLabel
            // 
            this.plyLabel.AutoSize = true;
            this.plyLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plyLabel.Location = new System.Drawing.Point(355, 44);
            this.plyLabel.Name = "plyLabel";
            this.plyLabel.Size = new System.Drawing.Size(282, 44);
            this.plyLabel.TabIndex = 21;
            this.plyLabel.Text = "Select a Player";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(205, 250);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(63, 23);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(274, 250);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(63, 23);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 512);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.plyLabel);
            this.Controls.Add(this.plyImgBox);
            this.Controls.Add(this.plyname);
            this.Controls.Add(this.rmbtn);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Team Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plyImgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button rmbtn;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox plyname;
        private System.Windows.Forms.PictureBox plyImgBox;
        private System.Windows.Forms.Label plyLabel;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnRemove;
    }
}