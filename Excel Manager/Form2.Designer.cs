namespace Excel_Manager
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.berlapOszlop = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.berlapSor = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nevekOszlop = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nevekSor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.berlapOszlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.berlapSor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nevekOszlop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekSor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(52, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Alkalmaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnApplyClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.berlapOszlop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.berlapSor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(173, 67);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bérlapon a név helye";
            // 
            // berlapOszlop
            // 
            this.berlapOszlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.berlapOszlop.Location = new System.Drawing.Point(109, 39);
            this.berlapOszlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.berlapOszlop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.berlapOszlop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.berlapOszlop.Name = "berlapOszlop";
            this.berlapOszlop.Size = new System.Drawing.Size(52, 21);
            this.berlapOszlop.TabIndex = 3;
            this.berlapOszlop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oszlop (szám):";
            // 
            // berlapSor
            // 
            this.berlapSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.berlapSor.Location = new System.Drawing.Point(109, 16);
            this.berlapSor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.berlapSor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.berlapSor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.berlapSor.Name = "berlapSor";
            this.berlapSor.Size = new System.Drawing.Size(52, 21);
            this.berlapSor.TabIndex = 1;
            this.berlapSor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sor (szám):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nevekOszlop);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nevekSor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(9, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(173, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ahonnan a nevek kezdődnek";
            // 
            // nevekOszlop
            // 
            this.nevekOszlop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevekOszlop.Location = new System.Drawing.Point(109, 39);
            this.nevekOszlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nevekOszlop.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nevekOszlop.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nevekOszlop.Name = "nevekOszlop";
            this.nevekOszlop.Size = new System.Drawing.Size(52, 21);
            this.nevekOszlop.TabIndex = 3;
            this.nevekOszlop.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(5, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Oszlop (szám):";
            // 
            // nevekSor
            // 
            this.nevekSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nevekSor.Location = new System.Drawing.Point(109, 16);
            this.nevekSor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nevekSor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nevekSor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nevekSor.Name = "nevekSor";
            this.nevekSor.Size = new System.Drawing.Size(52, 21);
            this.nevekSor.TabIndex = 1;
            this.nevekSor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(5, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sor (szám):";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 196);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.berlapOszlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.berlapSor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nevekOszlop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nevekSor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown berlapOszlop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown berlapSor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nevekOszlop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nevekSor;
        private System.Windows.Forms.Label label4;
    }
}