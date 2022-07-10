
namespace Ingatlanok
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
            this.Ingatlanok = new System.Windows.Forms.GroupBox();
            this.button_export = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.button_penthouse = new System.Windows.Forms.Button();
            this.button_ujsorhaz = new System.Windows.Forms.Button();
            this.button_ujcsaladi = new System.Windows.Forms.Button();
            this.listBox_ingatlanok = new System.Windows.Forms.ListBox();
            this.Ingatlanok.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ingatlanok
            // 
            this.Ingatlanok.Controls.Add(this.button_export);
            this.Ingatlanok.Controls.Add(this.button_torles);
            this.Ingatlanok.Controls.Add(this.button_penthouse);
            this.Ingatlanok.Controls.Add(this.button_ujsorhaz);
            this.Ingatlanok.Controls.Add(this.button_ujcsaladi);
            this.Ingatlanok.Controls.Add(this.listBox_ingatlanok);
            this.Ingatlanok.Location = new System.Drawing.Point(13, 13);
            this.Ingatlanok.Name = "Ingatlanok";
            this.Ingatlanok.Size = new System.Drawing.Size(374, 349);
            this.Ingatlanok.TabIndex = 0;
            this.Ingatlanok.TabStop = false;
            this.Ingatlanok.Text = "Ingatlanok";
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(7, 305);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(184, 23);
            this.button_export.TabIndex = 6;
            this.button_export.Text = "Exportálás";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_torles
            // 
            this.button_torles.Location = new System.Drawing.Point(7, 276);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(184, 23);
            this.button_torles.TabIndex = 5;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // button_penthouse
            // 
            this.button_penthouse.Location = new System.Drawing.Point(7, 247);
            this.button_penthouse.Name = "button_penthouse";
            this.button_penthouse.Size = new System.Drawing.Size(361, 23);
            this.button_penthouse.TabIndex = 3;
            this.button_penthouse.Text = "Új Penthouse";
            this.button_penthouse.UseVisualStyleBackColor = true;
            this.button_penthouse.Click += new System.EventHandler(this.button_penthouse_Click);
            // 
            // button_ujsorhaz
            // 
            this.button_ujsorhaz.Location = new System.Drawing.Point(7, 217);
            this.button_ujsorhaz.Name = "button_ujsorhaz";
            this.button_ujsorhaz.Size = new System.Drawing.Size(361, 23);
            this.button_ujsorhaz.TabIndex = 2;
            this.button_ujsorhaz.Text = "Új Sorház";
            this.button_ujsorhaz.UseVisualStyleBackColor = true;
            this.button_ujsorhaz.Click += new System.EventHandler(this.button_ujsorhaz_Click);
            // 
            // button_ujcsaladi
            // 
            this.button_ujcsaladi.Location = new System.Drawing.Point(7, 187);
            this.button_ujcsaladi.Name = "button_ujcsaladi";
            this.button_ujcsaladi.Size = new System.Drawing.Size(361, 23);
            this.button_ujcsaladi.TabIndex = 1;
            this.button_ujcsaladi.Text = "Új Családiház";
            this.button_ujcsaladi.UseVisualStyleBackColor = true;
            this.button_ujcsaladi.Click += new System.EventHandler(this.button_ujcsaladi_Click);
            // 
            // listBox_ingatlanok
            // 
            this.listBox_ingatlanok.FormattingEnabled = true;
            this.listBox_ingatlanok.Location = new System.Drawing.Point(7, 20);
            this.listBox_ingatlanok.Name = "listBox_ingatlanok";
            this.listBox_ingatlanok.Size = new System.Drawing.Size(361, 160);
            this.listBox_ingatlanok.TabIndex = 0;
            this.listBox_ingatlanok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_ingatlanok_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 383);
            this.Controls.Add(this.Ingatlanok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Ingatlanok.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Ingatlanok;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.Button button_penthouse;
        private System.Windows.Forms.Button button_ujsorhaz;
        private System.Windows.Forms.Button button_ujcsaladi;
        public System.Windows.Forms.ListBox listBox_ingatlanok;
    }
}

