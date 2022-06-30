
namespace Ingatlanok
{
    partial class Form_Penthouse
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
            this.button_MentesPenthouse = new System.Windows.Forms.Button();
            this.button_ujPenthouse = new System.Windows.Forms.Button();
            this.numeric_ErkelyPenthouse = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_EmeletPenthouse = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numeric_BerletiPenthouse = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric_alapteruletPenthouse = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numeric_IranyarPenthouse = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_PenthouseCim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ErkelyPenthouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EmeletPenthouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BerletiPenthouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alapteruletPenthouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IranyarPenthouse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_MentesPenthouse);
            this.groupBox1.Controls.Add(this.button_ujPenthouse);
            this.groupBox1.Controls.Add(this.numeric_ErkelyPenthouse);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numeric_EmeletPenthouse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numeric_BerletiPenthouse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numeric_alapteruletPenthouse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numeric_IranyarPenthouse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_PenthouseCim);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új Penthouse";
            // 
            // button_MentesPenthouse
            // 
            this.button_MentesPenthouse.Location = new System.Drawing.Point(7, 249);
            this.button_MentesPenthouse.Name = "button_MentesPenthouse";
            this.button_MentesPenthouse.Size = new System.Drawing.Size(163, 23);
            this.button_MentesPenthouse.TabIndex = 41;
            this.button_MentesPenthouse.Text = "Mentés CSV be";
            this.button_MentesPenthouse.UseVisualStyleBackColor = true;
            // 
            // button_ujPenthouse
            // 
            this.button_ujPenthouse.Location = new System.Drawing.Point(7, 219);
            this.button_ujPenthouse.Name = "button_ujPenthouse";
            this.button_ujPenthouse.Size = new System.Drawing.Size(163, 23);
            this.button_ujPenthouse.TabIndex = 40;
            this.button_ujPenthouse.Text = "Új Penthouse";
            this.button_ujPenthouse.UseVisualStyleBackColor = true;
            this.button_ujPenthouse.Click += new System.EventHandler(this.button_ujPenthouse_Click);
            // 
            // numeric_ErkelyPenthouse
            // 
            this.numeric_ErkelyPenthouse.Location = new System.Drawing.Point(174, 182);
            this.numeric_ErkelyPenthouse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_ErkelyPenthouse.Name = "numeric_ErkelyPenthouse";
            this.numeric_ErkelyPenthouse.Size = new System.Drawing.Size(120, 20);
            this.numeric_ErkelyPenthouse.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Erkély";
            // 
            // numeric_EmeletPenthouse
            // 
            this.numeric_EmeletPenthouse.Location = new System.Drawing.Point(174, 153);
            this.numeric_EmeletPenthouse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_EmeletPenthouse.Name = "numeric_EmeletPenthouse";
            this.numeric_EmeletPenthouse.Size = new System.Drawing.Size(120, 20);
            this.numeric_EmeletPenthouse.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Emelet";
            // 
            // numeric_BerletiPenthouse
            // 
            this.numeric_BerletiPenthouse.Location = new System.Drawing.Point(174, 121);
            this.numeric_BerletiPenthouse.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numeric_BerletiPenthouse.Name = "numeric_BerletiPenthouse";
            this.numeric_BerletiPenthouse.ReadOnly = true;
            this.numeric_BerletiPenthouse.Size = new System.Drawing.Size(120, 20);
            this.numeric_BerletiPenthouse.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Bérleti díj";
            // 
            // numeric_alapteruletPenthouse
            // 
            this.numeric_alapteruletPenthouse.Location = new System.Drawing.Point(174, 86);
            this.numeric_alapteruletPenthouse.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numeric_alapteruletPenthouse.Name = "numeric_alapteruletPenthouse";
            this.numeric_alapteruletPenthouse.Size = new System.Drawing.Size(120, 20);
            this.numeric_alapteruletPenthouse.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Alapterület";
            // 
            // numeric_IranyarPenthouse
            // 
            this.numeric_IranyarPenthouse.Location = new System.Drawing.Point(174, 54);
            this.numeric_IranyarPenthouse.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numeric_IranyarPenthouse.Name = "numeric_IranyarPenthouse";
            this.numeric_IranyarPenthouse.Size = new System.Drawing.Size(120, 20);
            this.numeric_IranyarPenthouse.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Irány ár";
            // 
            // textBox_PenthouseCim
            // 
            this.textBox_PenthouseCim.Location = new System.Drawing.Point(174, 23);
            this.textBox_PenthouseCim.Name = "textBox_PenthouseCim";
            this.textBox_PenthouseCim.Size = new System.Drawing.Size(120, 20);
            this.textBox_PenthouseCim.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cím";
            // 
            // Form_Penthouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 314);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Penthouse";
            this.Text = "Form_Penthouse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_ErkelyPenthouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_EmeletPenthouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_BerletiPenthouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_alapteruletPenthouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_IranyarPenthouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_MentesPenthouse;
        private System.Windows.Forms.Button button_ujPenthouse;
        private System.Windows.Forms.NumericUpDown numeric_ErkelyPenthouse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numeric_EmeletPenthouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_BerletiPenthouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric_alapteruletPenthouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numeric_IranyarPenthouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_PenthouseCim;
        private System.Windows.Forms.Label label1;
    }
}