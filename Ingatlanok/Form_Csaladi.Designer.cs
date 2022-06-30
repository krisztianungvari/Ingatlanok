
namespace Ingatlanok
{
    partial class Form_Csaladi
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
            this.button_MentesCsaladi = new System.Windows.Forms.Button();
            this.button_ujCsaladi = new System.Windows.Forms.Button();
            this.numeric_GarazsCsaladi = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_TelekCsaladi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_BerletiCsaladi = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_alapteruletCsaladi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_IranyarCsaladi = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_CsaladiCim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_GarazsCsaladi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TelekCsaladi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BerletiCsaladi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alapteruletCsaladi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IranyarCsaladi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_MentesCsaladi);
            this.groupBox1.Controls.Add(this.button_ujCsaladi);
            this.groupBox1.Controls.Add(this.numeric_GarazsCsaladi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numeric_TelekCsaladi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numeric_BerletiCsaladi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numeric_alapteruletCsaladi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numeric_IranyarCsaladi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_CsaladiCim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új Családiház";
            // 
            // button_MentesCsaladi
            // 
            this.button_MentesCsaladi.Location = new System.Drawing.Point(7, 258);
            this.button_MentesCsaladi.Name = "button_MentesCsaladi";
            this.button_MentesCsaladi.Size = new System.Drawing.Size(163, 23);
            this.button_MentesCsaladi.TabIndex = 13;
            this.button_MentesCsaladi.Text = "Mentés CSV be";
            this.button_MentesCsaladi.UseVisualStyleBackColor = true;
            // 
            // button_ujCsaladi
            // 
            this.button_ujCsaladi.Location = new System.Drawing.Point(7, 228);
            this.button_ujCsaladi.Name = "button_ujCsaladi";
            this.button_ujCsaladi.Size = new System.Drawing.Size(163, 23);
            this.button_ujCsaladi.TabIndex = 12;
            this.button_ujCsaladi.Text = "Új Családiház";
            this.button_ujCsaladi.UseVisualStyleBackColor = true;
            this.button_ujCsaladi.Click += new System.EventHandler(this.button_ujCsaladi_Click);
            // 
            // numeric_GarazsCsaladi
            // 
            this.numeric_GarazsCsaladi.Location = new System.Drawing.Point(174, 191);
            this.numeric_GarazsCsaladi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_GarazsCsaladi.Name = "numeric_GarazsCsaladi";
            this.numeric_GarazsCsaladi.Size = new System.Drawing.Size(120, 20);
            this.numeric_GarazsCsaladi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Garázs";
            // 
            // numeric_TelekCsaladi
            // 
            this.numeric_TelekCsaladi.Location = new System.Drawing.Point(174, 162);
            this.numeric_TelekCsaladi.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_TelekCsaladi.Name = "numeric_TelekCsaladi";
            this.numeric_TelekCsaladi.Size = new System.Drawing.Size(120, 20);
            this.numeric_TelekCsaladi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telek terület";
            // 
            // numeric_BerletiCsaladi
            // 
            this.numeric_BerletiCsaladi.Location = new System.Drawing.Point(174, 130);
            this.numeric_BerletiCsaladi.Name = "numeric_BerletiCsaladi";
            this.numeric_BerletiCsaladi.ReadOnly = true;
            this.numeric_BerletiCsaladi.Size = new System.Drawing.Size(120, 20);
            this.numeric_BerletiCsaladi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bérleti díj";
            // 
            // numeric_alapteruletCsaladi
            // 
            this.numeric_alapteruletCsaladi.Location = new System.Drawing.Point(174, 95);
            this.numeric_alapteruletCsaladi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_alapteruletCsaladi.Name = "numeric_alapteruletCsaladi";
            this.numeric_alapteruletCsaladi.Size = new System.Drawing.Size(120, 20);
            this.numeric_alapteruletCsaladi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alapterület";
            // 
            // numeric_IranyarCsaladi
            // 
            this.numeric_IranyarCsaladi.Location = new System.Drawing.Point(174, 63);
            this.numeric_IranyarCsaladi.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_IranyarCsaladi.Name = "numeric_IranyarCsaladi";
            this.numeric_IranyarCsaladi.Size = new System.Drawing.Size(120, 20);
            this.numeric_IranyarCsaladi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Irány ár";
            // 
            // textBox_CsaladiCim
            // 
            this.textBox_CsaladiCim.Location = new System.Drawing.Point(174, 32);
            this.textBox_CsaladiCim.Name = "textBox_CsaladiCim";
            this.textBox_CsaladiCim.Size = new System.Drawing.Size(120, 20);
            this.textBox_CsaladiCim.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            // 
            // Form_Csaladi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Csaladi";
            this.Text = "Form_Csaladi";
            this.Load += new System.EventHandler(this.Form_Csaladi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_GarazsCsaladi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TelekCsaladi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BerletiCsaladi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alapteruletCsaladi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IranyarCsaladi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numeric_IranyarCsaladi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_CsaladiCim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_MentesCsaladi;
        private System.Windows.Forms.Button button_ujCsaladi;
        private System.Windows.Forms.NumericUpDown numeric_GarazsCsaladi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_TelekCsaladi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_BerletiCsaladi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_alapteruletCsaladi;
        private System.Windows.Forms.Label label3;
    }
}