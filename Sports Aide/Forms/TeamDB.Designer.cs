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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rmbtn = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.plyname = new System.Windows.Forms.TextBox();
            this.plyImgBox = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.posBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.activeCheck = new System.Windows.Forms.CheckBox();
            this.plyNotes = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
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
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(206, 250);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(63, 23);
            this.btnUpload.TabIndex = 22;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(276, 250);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(63, 23);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(458, 88);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(130, 20);
            this.txtFirstName.TabIndex = 24;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(458, 122);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(130, 20);
            this.txtLastName.TabIndex = 25;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(367, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Surname:";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(218, 295);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(106, 52);
            this.saveBtn.TabIndex = 28;
            this.saveBtn.Text = "Save Changes";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // posBox
            // 
            this.posBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Goalkeeper",
            "Defender",
            "Midfielder",
            "Forward"});
            this.posBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.posBox.Items.AddRange(new object[] {
            "Goalkeeper",
            "Defender",
            "Midfielder",
            "Forward"});
            this.posBox.Location = new System.Drawing.Point(458, 157);
            this.posBox.Name = "posBox";
            this.posBox.Size = new System.Drawing.Size(130, 21);
            this.posBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(372, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Position:";
            // 
            // activeCheck
            // 
            this.activeCheck.AutoSize = true;
            this.activeCheck.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.activeCheck.Location = new System.Drawing.Point(482, 184);
            this.activeCheck.Name = "activeCheck";
            this.activeCheck.Size = new System.Drawing.Size(75, 23);
            this.activeCheck.TabIndex = 30;
            this.activeCheck.Text = "Active";
            this.activeCheck.UseVisualStyleBackColor = true;
            // 
            // plyNotes
            // 
            this.plyNotes.Location = new System.Drawing.Point(376, 271);
            this.plyNotes.Multiline = true;
            this.plyNotes.Name = "plyNotes";
            this.plyNotes.Size = new System.Drawing.Size(283, 209);
            this.plyNotes.TabIndex = 31;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(238, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(372, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Notes:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(670, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.plyNotes);
            this.Controls.Add(this.activeCheck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.posBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.plyImgBox);
            this.Controls.Add(this.plyname);
            this.Controls.Add(this.rmbtn);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox posBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox activeCheck;
        private System.Windows.Forms.TextBox plyNotes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
    }
}