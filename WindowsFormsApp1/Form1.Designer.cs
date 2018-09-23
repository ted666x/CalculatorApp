namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Angka1 = new System.Windows.Forms.TextBox();
            this.Angka2 = new System.Windows.Forms.TextBox();
            this.hasilteks = new System.Windows.Forms.TextBox();
            this.operator1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // Angka1
            // 
            this.Angka1.Location = new System.Drawing.Point(75, 113);
            this.Angka1.Name = "Angka1";
            this.Angka1.Size = new System.Drawing.Size(100, 20);
            this.Angka1.TabIndex = 4;
            // 
            // Angka2
            // 
            this.Angka2.Location = new System.Drawing.Point(75, 149);
            this.Angka2.Name = "Angka2";
            this.Angka2.Size = new System.Drawing.Size(100, 20);
            this.Angka2.TabIndex = 5;
            // 
            // hasilteks
            // 
            this.hasilteks.Location = new System.Drawing.Point(75, 182);
            this.hasilteks.Name = "hasilteks";
            this.hasilteks.Size = new System.Drawing.Size(100, 20);
            this.hasilteks.TabIndex = 6;
            // 
            // operator1
            // 
            this.operator1.FormattingEnabled = true;
            this.operator1.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Pembagian",
            "Perkalian"});
            this.operator1.Location = new System.Drawing.Point(75, 60);
            this.operator1.Name = "operator1";
            this.operator1.Size = new System.Drawing.Size(121, 21);
            this.operator1.TabIndex = 7;
            this.operator1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operator1);
            this.Controls.Add(this.hasilteks);
            this.Controls.Add(this.Angka2);
            this.Controls.Add(this.Angka1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Angka1;
        private System.Windows.Forms.TextBox Angka2;
        private System.Windows.Forms.TextBox hasilteks;
        private System.Windows.Forms.ComboBox operator1;
        private System.Windows.Forms.Button button1;
    }
}

