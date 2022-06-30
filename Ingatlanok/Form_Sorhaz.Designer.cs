
namespace Ingatlanok
{
    partial class Form_Sorhaz
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
            this.button_MentesSor = new System.Windows.Forms.Button();
            this.button_ujSor = new System.Windows.Forms.Button();
            this.numeric_GarazsSor = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_TelekSor = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_BerletiSor = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_alapteruletSor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_IranyarSor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SorCim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_GarazsSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TelekSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BerletiSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alapteruletSor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IranyarSor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_MentesSor);
            this.groupBox1.Controls.Add(this.button_ujSor);
            this.groupBox1.Controls.Add(this.numeric_GarazsSor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numeric_TelekSor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numeric_BerletiSor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numeric_alapteruletSor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numeric_IranyarSor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_SorCim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új Sorház";
            // 
            // button_MentesSor
            // 
            this.button_MentesSor.Location = new System.Drawing.Point(7, 253);
            this.button_MentesSor.Name = "button_MentesSor";
            this.button_MentesSor.Size = new System.Drawing.Size(163, 23);
            this.button_MentesSor.TabIndex = 27;
            this.button_MentesSor.Text = "Mentés CSV be";
            this.button_MentesSor.UseVisualStyleBackColor = true;
            // 
            // button_ujSor
            // 
            this.button_ujSor.Location = new System.Drawing.Point(7, 223);
            this.button_ujSor.Name = "button_ujSor";
            this.button_ujSor.Size = new System.Drawing.Size(163, 23);
            this.button_ujSor.TabIndex = 26;
            this.button_ujSor.Text = "Új Sorház";
            this.button_ujSor.UseVisualStyleBackColor = true;
            this.button_ujSor.Click += new System.EventHandler(this.button_ujSor_Click);
            // 
            // numeric_GarazsSor
            // 
            this.numeric_GarazsSor.Location = new System.Drawing.Point(174, 186);
            this.numeric_GarazsSor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_GarazsSor.Name = "numeric_GarazsSor";
            this.numeric_GarazsSor.Size = new System.Drawing.Size(120, 20);
            this.numeric_GarazsSor.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Garázs";
            // 
            // numeric_TelekSor
            // 
            this.numeric_TelekSor.Location = new System.Drawing.Point(174, 157);
            this.numeric_TelekSor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_TelekSor.Name = "numeric_TelekSor";
            this.numeric_TelekSor.Size = new System.Drawing.Size(120, 20);
            this.numeric_TelekSor.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Telek terület";
            // 
            // numeric_BerletiSor
            // 
            this.numeric_BerletiSor.Location = new System.Drawing.Point(174, 125);
            this.numeric_BerletiSor.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numeric_BerletiSor.Name = "numeric_BerletiSor";
            this.numeric_BerletiSor.ReadOnly = true;
            this.numeric_BerletiSor.Size = new System.Drawing.Size(120, 20);
            this.numeric_BerletiSor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Bérleti díj";
            // 
            // numeric_alapteruletSor
            // 
            this.numeric_alapteruletSor.Location = new System.Drawing.Point(174, 90);
            this.numeric_alapteruletSor.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_alapteruletSor.Name = "numeric_alapteruletSor";
            this.numeric_alapteruletSor.Size = new System.Drawing.Size(120, 20);
            this.numeric_alapteruletSor.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Alapterület";
            // 
            // numeric_IranyarSor
            // 
            this.numeric_IranyarSor.Location = new System.Drawing.Point(174, 58);
            this.numeric_IranyarSor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_IranyarSor.Name = "numeric_IranyarSor";
            this.numeric_IranyarSor.Size = new System.Drawing.Size(120, 20);
            this.numeric_IranyarSor.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Irány ár";
            // 
            // textBox_SorCim
            // 
            this.textBox_SorCim.Location = new System.Drawing.Point(174, 27);
            this.textBox_SorCim.Name = "textBox_SorCim";
            this.textBox_SorCim.Size = new System.Drawing.Size(120, 20);
            this.textBox_SorCim.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cím";
            // 
            // Form_Sorhaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 328);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Sorhaz";
            this.Text = "Form_Sorhaz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_GarazsSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_TelekSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BerletiSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alapteruletSor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IranyarSor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_MentesSor;
        private System.Windows.Forms.Button button_ujSor;
        private System.Windows.Forms.NumericUpDown numeric_GarazsSor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_TelekSor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_BerletiSor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_alapteruletSor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_IranyarSor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SorCim;
        private System.Windows.Forms.Label label1;
    }
}