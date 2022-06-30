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
    public partial class Form_Sorhaz : Form
    {
        string funkcio;
        public Form_Sorhaz(string funkcio)
        {
            InitializeComponent();
            this.funkcio = funkcio;
        }

        private void button_ujSor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_SorCim.Text))
            {
                MessageBox.Show("A cím megadása kötelező!");
                textBox_SorCim.Focus();
                return;
            }
            try
            {
                Program.formnyito.sql.CommandText = $"INSERT INTO `ingatlan` (`id_ingatlan`, `cim`, `iranyar`, `alapterulet`) VALUES (NULL, '{textBox_SorCim.Text}', '{numeric_IranyarSor.Value}', '{numeric_alapteruletSor.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();

                long progid = Program.formnyito.sql.LastInsertedId;    
                Program.formnyito.sql.CommandText = $"INSERT INTO `sorhaz` (`id_sorhaz`, `telek_terulet`, `garazs`) VALUES ('{progid}', '{numeric_TelekSor.Value}', '{numeric_GarazsSor.Value}');";
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
    }
}
