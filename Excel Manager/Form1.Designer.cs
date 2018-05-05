namespace Excel_Manager
{
    partial class Form1
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
            this.berlapFileDialogBtn = new System.Windows.Forms.Button();
            this.berlapFDTxtBox = new System.Windows.Forms.TextBox();
            this.nevekFDTxtBox = new System.Windows.Forms.TextBox();
            this.nevekFileDialogBtn = new System.Windows.Forms.Button();
            this.mentesFDTxtBox = new System.Windows.Forms.TextBox();
            this.mentesFileDialogBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.mentesMappabaCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dirName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.customSettingsBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // berlapFileDialogBtn
            // 
            this.berlapFileDialogBtn.Location = new System.Drawing.Point(563, 27);
            this.berlapFileDialogBtn.Name = "berlapFileDialogBtn";
            this.berlapFileDialogBtn.Size = new System.Drawing.Size(143, 31);
            this.berlapFileDialogBtn.TabIndex = 0;
            this.berlapFileDialogBtn.Text = "Fájl megnyitás";
            this.berlapFileDialogBtn.UseVisualStyleBackColor = true;
            this.berlapFileDialogBtn.Click += new System.EventHandler(this.berlapFileDialogBtn_Click);
            // 
            // berlapFDTxtBox
            // 
            this.berlapFDTxtBox.Location = new System.Drawing.Point(147, 31);
            this.berlapFDTxtBox.Name = "berlapFDTxtBox";
            this.berlapFDTxtBox.Size = new System.Drawing.Size(410, 22);
            this.berlapFDTxtBox.TabIndex = 1;
            // 
            // nevekFDTxtBox
            // 
            this.nevekFDTxtBox.Location = new System.Drawing.Point(147, 33);
            this.nevekFDTxtBox.Name = "nevekFDTxtBox";
            this.nevekFDTxtBox.Size = new System.Drawing.Size(410, 22);
            this.nevekFDTxtBox.TabIndex = 3;
            // 
            // nevekFileDialogBtn
            // 
            this.nevekFileDialogBtn.Location = new System.Drawing.Point(563, 29);
            this.nevekFileDialogBtn.Name = "nevekFileDialogBtn";
            this.nevekFileDialogBtn.Size = new System.Drawing.Size(143, 31);
            this.nevekFileDialogBtn.TabIndex = 2;
            this.nevekFileDialogBtn.Text = "Fájl megnyitás";
            this.nevekFileDialogBtn.UseVisualStyleBackColor = true;
            this.nevekFileDialogBtn.Click += new System.EventHandler(this.nevekFileDialogBtn_Click);
            // 
            // mentesFDTxtBox
            // 
            this.mentesFDTxtBox.Location = new System.Drawing.Point(147, 30);
            this.mentesFDTxtBox.Name = "mentesFDTxtBox";
            this.mentesFDTxtBox.Size = new System.Drawing.Size(410, 22);
            this.mentesFDTxtBox.TabIndex = 5;
            // 
            // mentesFileDialogBtn
            // 
            this.mentesFileDialogBtn.Location = new System.Drawing.Point(563, 26);
            this.mentesFileDialogBtn.Name = "mentesFileDialogBtn";
            this.mentesFileDialogBtn.Size = new System.Drawing.Size(143, 31);
            this.mentesFileDialogBtn.TabIndex = 4;
            this.mentesFileDialogBtn.Text = "Mappa választás";
            this.mentesFileDialogBtn.UseVisualStyleBackColor = true;
            this.mentesFileDialogBtn.Click += new System.EventHandler(this.mentesFileDialogBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Berlap helye:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nevek helye:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mentés helye:";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startBtn.Location = new System.Drawing.Point(586, 377);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(132, 61);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "Csináld";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 412);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(568, 26);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 10;
            // 
            // mentesMappabaCheckBox
            // 
            this.mentesMappabaCheckBox.AutoSize = true;
            this.mentesMappabaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mentesMappabaCheckBox.Location = new System.Drawing.Point(66, 39);
            this.mentesMappabaCheckBox.Name = "mentesMappabaCheckBox";
            this.mentesMappabaCheckBox.Size = new System.Drawing.Size(184, 22);
            this.mentesMappabaCheckBox.TabIndex = 11;
            this.mentesMappabaCheckBox.Text = "Csináljon külön mappát";
            this.mentesMappabaCheckBox.UseVisualStyleBackColor = true;
            this.mentesMappabaCheckBox.CheckedChanged += new System.EventHandler(this.mentesMappabaCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(432, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mappa neve:";
            // 
            // dirName
            // 
            this.dirName.Enabled = false;
            this.dirName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dirName.Location = new System.Drawing.Point(539, 37);
            this.dirName.Name = "dirName";
            this.dirName.Size = new System.Drawing.Size(122, 24);
            this.dirName.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.berlapFDTxtBox);
            this.groupBox1.Controls.Add(this.berlapFileDialogBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 78);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bérlap helye";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nevekFDTxtBox);
            this.groupBox2.Controls.Add(this.nevekFileDialogBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 78);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nevek helye";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.mentesFDTxtBox);
            this.groupBox3.Controls.Add(this.mentesFileDialogBtn);
            this.groupBox3.Location = new System.Drawing.Point(12, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 78);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metés helye";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dirName);
            this.groupBox4.Controls.Add(this.mentesMappabaCheckBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(12, 264);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(712, 78);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Külön mappa";
            // 
            // customSettingsBtn
            // 
            this.customSettingsBtn.Location = new System.Drawing.Point(12, 362);
            this.customSettingsBtn.Name = "customSettingsBtn";
            this.customSettingsBtn.Size = new System.Drawing.Size(119, 35);
            this.customSettingsBtn.TabIndex = 18;
            this.customSettingsBtn.Text = "Egyéb beállítás";
            this.customSettingsBtn.UseVisualStyleBackColor = true;
            this.customSettingsBtn.Click += new System.EventHandler(this.customSettingsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.customSettingsBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startBtn);
            this.Name = "Form1";
            this.Text = "Excel manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button berlapFileDialogBtn;
        private System.Windows.Forms.TextBox berlapFDTxtBox;
        private System.Windows.Forms.TextBox nevekFDTxtBox;
        private System.Windows.Forms.Button nevekFileDialogBtn;
        private System.Windows.Forms.TextBox mentesFDTxtBox;
        private System.Windows.Forms.Button mentesFileDialogBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox mentesMappabaCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dirName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button customSettingsBtn;
    }
}

