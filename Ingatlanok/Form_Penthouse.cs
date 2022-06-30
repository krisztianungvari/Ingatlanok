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
    public partial class Form_Penthouse : Form
    {
        string funkcio;
        public Form_Penthouse(string funkcio)
        {
            InitializeComponent();
        }

        private void button_ujPenthouse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_PenthouseCim.Text))
            {
                MessageBox.Show("A cím megadása kötelező!");
                textBox_PenthouseCim.Focus();
                return;
            }
            try
            {
                Program.formnyito.sql.CommandText = $"INSERT INTO `ingatlan` (`id_ingatlan`, `cim`, `iranyar`, `alapterulet`) VALUES (NULL, '{textBox_PenthouseCim.Text}', '{numeric_IranyarPenthouse.Value}', '{numeric_alapteruletPenthouse.Value}');";
                Program.formnyito.sql.ExecuteNonQuery();

                long progid = Program.formnyito.sql.LastInsertedId;
                Program.formnyito.sql.CommandText = $"INSERT INTO `penthouse` (`id_penthouse`, `emelet`, `erkely_merete`) VALUES ('{progid}', '{numeric_EmeletPenthouse.Value}', '{numeric_ErkelyPenthouse.Value}');";
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
