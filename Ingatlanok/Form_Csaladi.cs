using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingatlanok
{
    public partial class Form_Csaladi : Form
    {
        string funkcio;
        Form form;
        public Form_Csaladi(string funkcio)
        {
            InitializeComponent();
            this.funkcio = funkcio;
        }

        private void button_ujCsaladi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_CsaladiCim.Text))
            {
                MessageBox.Show("A cím megadása kötelező!");
                textBox_CsaladiCim.Focus();
                return;
            }
            try
            {
                //Először az Ingatlanba kell beszűrni
                // , `tipus` nem kell,mert az már adott!
                Program.formnyito.sql.CommandText = $"INSERT INTO `ingatlan` (`id_ingatlan`, `cim`, `iranyar`, `alapterulet`) VALUES (NULL, '{textBox_CsaladiCim.Text}', '{numeric_IranyarCsaladi.Value}', '{numeric_alapteruletCsaladi.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();
                long progid = Program.formnyito.sql.LastInsertedId;
                // majd a családiba is
                Program.formnyito.sql.CommandText = $"INSERT INTO `csaladi` (`id_csaladi`, `telek_terulet`, `garazs`) VALUES ('{progid}', '{numeric_TelekCsaladi.Value}', '{numeric_GarazsCsaladi.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();
                MessageBox.Show("Sikeres felvitel!");
                Program.formnyito.frissit();
                this.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form_Csaladi_Load(object sender, EventArgs e)
        {
            if (funkcio.Equals("Show"))
            {
                button_ujCsaladi.Hide();
                //csaladi  = (Form_Csaladi)Program.formnyito.listBox_ingatlanok.SelectedItem;
                //textBox_CsaladiCim.Text = csaladi.Cim;
                //textBox_CsaladiCim.ReadOnly = true;
                //numeric_IranyarCsaladi.Value = csaladi.
    
            }
        }
    }
}
