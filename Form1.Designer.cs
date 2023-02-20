
namespace NumerickaIntegrace
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.index = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpsonovo = new System.Windows.Forms.RadioButton();
            this.lichobeznikove = new System.Windows.Forms.RadioButton();
            this.sin = new System.Windows.Forms.RadioButton();
            this.cos = new System.Windows.Forms.RadioButton();
            this.linear = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.horniMez = new System.Windows.Forms.TextBox();
            this.dolniMez = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.index)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lichobeznikove);
            this.groupBox1.Controls.Add(this.simpsonovo);
            this.groupBox1.Location = new System.Drawing.Point(63, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pravidla";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linear);
            this.groupBox2.Controls.Add(this.cos);
            this.groupBox2.Controls.Add(this.sin);
            this.groupBox2.Location = new System.Drawing.Point(301, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(123, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funkce";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(128, 152);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(120, 20);
            this.index.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Horní mez";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dolní mez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dělící index";
            // 
            // simpsonovo
            // 
            this.simpsonovo.AutoSize = true;
            this.simpsonovo.Location = new System.Drawing.Point(18, 52);
            this.simpsonovo.Name = "simpsonovo";
            this.simpsonovo.Size = new System.Drawing.Size(83, 17);
            this.simpsonovo.TabIndex = 8;
            this.simpsonovo.TabStop = true;
            this.simpsonovo.Text = "Simpsonovo";
            this.simpsonovo.UseVisualStyleBackColor = true;
            this.simpsonovo.CheckedChanged += new System.EventHandler(this.simpsonovo_CheckedChanged);
            // 
            // lichobeznikove
            // 
            this.lichobeznikove.AutoSize = true;
            this.lichobeznikove.Location = new System.Drawing.Point(18, 19);
            this.lichobeznikove.Name = "lichobeznikove";
            this.lichobeznikove.Size = new System.Drawing.Size(102, 17);
            this.lichobeznikove.TabIndex = 10;
            this.lichobeznikove.TabStop = true;
            this.lichobeznikove.Text = "Lichoběžníkové";
            this.lichobeznikove.UseVisualStyleBackColor = true;
            this.lichobeznikove.CheckedChanged += new System.EventHandler(this.lichobeznikove_CheckedChanged);
            // 
            // sin
            // 
            this.sin.AutoSize = true;
            this.sin.Location = new System.Drawing.Point(26, 27);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(66, 17);
            this.sin.TabIndex = 12;
            this.sin.TabStop = true;
            this.sin.Text = "y = sin(x)";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.CheckedChanged += new System.EventHandler(this.sin_CheckedChanged);
            // 
            // cos
            // 
            this.cos.AutoSize = true;
            this.cos.Location = new System.Drawing.Point(26, 50);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(70, 17);
            this.cos.TabIndex = 14;
            this.cos.TabStop = true;
            this.cos.Text = "y = cos(x)";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.CheckedChanged += new System.EventHandler(this.cos_CheckedChanged);
            // 
            // linear
            // 
            this.linear.AutoSize = true;
            this.linear.Location = new System.Drawing.Point(26, 73);
            this.linear.Name = "linear";
            this.linear.Size = new System.Drawing.Size(47, 17);
            this.linear.TabIndex = 16;
            this.linear.TabStop = true;
            this.linear.Text = "y = x";
            this.linear.UseVisualStyleBackColor = true;
            this.linear.CheckedChanged += new System.EventHandler(this.linear_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Integruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 256);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // horniMez
            // 
            this.horniMez.Location = new System.Drawing.Point(129, 44);
            this.horniMez.Name = "horniMez";
            this.horniMez.Size = new System.Drawing.Size(119, 20);
            this.horniMez.TabIndex = 10;
            this.horniMez.Text = "0";
            // 
            // dolniMez
            // 
            this.dolniMez.Location = new System.Drawing.Point(128, 99);
            this.dolniMez.Name = "dolniMez";
            this.dolniMez.Size = new System.Drawing.Size(119, 20);
            this.dolniMez.TabIndex = 11;
            this.dolniMez.Text = "0";
            this.dolniMez.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 349);
            this.Controls.Add(this.dolniMez);
            this.Controls.Add(this.horniMez);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.index);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Integrace";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.index)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton lichobeznikove;
        private System.Windows.Forms.RadioButton simpsonovo;
        private System.Windows.Forms.RadioButton linear;
        private System.Windows.Forms.RadioButton cos;
        private System.Windows.Forms.RadioButton sin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox horniMez;
        private System.Windows.Forms.TextBox dolniMez;
    }
}

