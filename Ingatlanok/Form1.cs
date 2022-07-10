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
using System.IO;

namespace Ingatlanok
{
    public partial class Form1 : Form
    {
        public MySqlConnection connection = null;
        public MySqlCommand sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frissit();
        }

        public void frissit()
        {
            listBox_ingatlanok.Items.Clear();

            string csaladiSQL = "SELECT ingatlan.id_ingatlan, ingatlan.cim, ingatlan.iranyar, ingatlan.alapterulet, csaladi.id_csaladi,csaladi.telek_terulet,csaladi.garazs FROM ingatlan JOIN csaladi ON ingatlan.id_ingatlan = csaladi.id_csaladi";
            string sorhazSQL = "SELECT ingatlan.id_ingatlan, ingatlan.cim, ingatlan.iranyar, ingatlan.alapterulet, sorhaz.id_sorhaz,sorhaz.telek_terulet,sorhaz.garazs FROM ingatlan JOIN sorhaz ON ingatlan.id_ingatlan = sorhaz.id_sorhaz";
            string penthouseSQL = "SELECT ingatlan.id_ingatlan, ingatlan.cim, ingatlan.iranyar, ingatlan.alapterulet, penthouse.id_penthouse,penthouse.emelet, penthouse.erkely_merete FROM ingatlan JOIN penthouse ON ingatlan.id_ingatlan = penthouse.id_penthouse";


            MySqlConnectionStringBuilder sw = new MySqlConnectionStringBuilder();
            sw.Server = "localhost";
            sw.UserID = "root";
            sw.Password = "";
            sw.Database = "ingatlanok";
            connection = new MySqlConnection(sw.ConnectionString);
            try
            {
                connection.Open();
                sql = connection.CreateCommand();
                sql.CommandText = csaladiSQL;
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idingatlan = dr.GetInt32("id_ingatlan");
                        string cim = dr.GetString("cim");
                        int iranyar = dr.GetInt32("iranyar");
                        int alapterulet = dr.GetInt32("alapterulet");
                        int telekterulet = dr.GetInt32("telek_terulet");
                        int garazs = dr.GetInt32("garazs");

                        Csaladi csaladi = new Csaladi(dr.GetInt32("id_ingatlan"),cim,iranyar,alapterulet,0, dr.GetInt32("id_csaladi"),telekterulet,garazs);
                        listBox_ingatlanok.Items.Add(csaladi);
                    }
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            try
            {
                sql = connection.CreateCommand();
                sql.CommandText = sorhazSQL;
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idingatlan = dr.GetInt32("id_ingatlan");
                        string cim = dr.GetString("cim");
                        int iranyar = dr.GetInt32("iranyar");
                        int alapterulet = dr.GetInt32("alapterulet");
                        int telekterulet = dr.GetInt32("telek_terulet");
                        int garazs = dr.GetInt32("garazs");

                        Sorhaz sorhaz = new Sorhaz(dr.GetInt32("id_ingatlan"), cim, iranyar, alapterulet, 0, dr.GetInt32("id_sorhaz"), telekterulet, garazs);
                        listBox_ingatlanok.Items.Add(sorhaz);
                    }
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            try
            {
                sql = connection.CreateCommand();
                sql.CommandText = penthouseSQL;
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int idingatlan = dr.GetInt32("id_ingatlan");
                        string cim = dr.GetString("cim");
                        int iranyar = dr.GetInt32("iranyar");
                        int alapterulet = dr.GetInt32("alapterulet");
                        int emelet = dr.GetInt32("emelet");
                        int erkely = dr.GetInt32("erkely_merete");

                        Penthouse penthouse = new Penthouse(dr.GetInt32("id_ingatlan"), cim, iranyar, alapterulet, 0, dr.GetInt32("id_penthouse"), emelet, erkely);
                        listBox_ingatlanok.Items.Add(penthouse);
                    }
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretne lépni?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                // a kilépési folyamatot lehet vele megszakítni! A Form closing event-et indítottam el, és a Cancel = true ezt megszakítja.
                e.Cancel = true;
            }
            else
            {
                
            }   
        }

        private void button_ujcsaladi_Click(object sender, EventArgs e)
        {
            Form_Csaladi form_csaladi = new Form_Csaladi("new");
            form_csaladi.ShowDialog();
        }

        private void button_ujsorhaz_Click(object sender, EventArgs e)
        {
            Form_Sorhaz form_sorhaz = new Form_Sorhaz("new");
            form_sorhaz.ShowDialog();
        }

        private void button_penthouse_Click(object sender, EventArgs e)
        {
            Form_Penthouse form_penthouse = new Form_Penthouse("new");
            form_penthouse.ShowDialog();
        }

        private void button_torles_Click(object sender, EventArgs e)
        {
            DialogResult torles = MessageBox.Show("Biztosan törli?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (torles == DialogResult.No)
            {
                return;
            }

            if (listBox_ingatlanok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kiválasztott ingatlan!");
                return;
            }
            var ingatlan = listBox_ingatlanok.SelectedItem;
            int id;
            if (ingatlan.GetType() == typeof(Csaladi))
            {
                Csaladi rekord = (Csaladi)listBox_ingatlanok.SelectedItem;
                id = rekord.Idcsaladi;
                sql.CommandText = $"DELETE FROM `csaladi` WHERE `csaladi`.`id_csaladi` = {id}";
                sql.ExecuteNonQuery();
                sql.CommandText = $"DELETE FROM `ingatlan` WHERE `ingatlan`.`id_ingatlan` = {id}";
                sql.ExecuteNonQuery();
                
            }
            else if (ingatlan.GetType() == typeof(Sorhaz))
            {
                Sorhaz rekord = (Sorhaz)listBox_ingatlanok.SelectedItem;
                id = rekord.Idsorhaz;
                sql.CommandText = $"DELETE FROM `sorhaz` WHERE `sorhaz`.`id_sorhaz` = {id}";
                sql.ExecuteNonQuery();
                sql.CommandText = $"DELETE FROM `ingatlan` WHERE `ingatlan`.`id_ingatlan` = {id}";
                sql.ExecuteNonQuery();

            }
            else if (ingatlan.GetType() == typeof(Penthouse))
            {
                Penthouse rekord = (Penthouse)listBox_ingatlanok.SelectedItem;
                id = rekord.Idpenthouse;
                sql.CommandText = $"DELETE FROM `penthouse` WHERE `penthouse`.`id_penthouse` = {id}";
                sql.ExecuteNonQuery();
                sql.CommandText = $"DELETE FROM `ingatlan` WHERE `ingatlan`.`id_ingatlan` = {id}";
                sql.ExecuteNonQuery();
            }
            frissit();
        }

        private void listBox_ingatlanok_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox_ingatlanok.SelectedIndex < 0)
            {
                return;
            }
            var ingatlan = listBox_ingatlanok.SelectedItem;
            if (ingatlan.GetType() == typeof(Csaladi))
            {
                Csaladi rekord = (Csaladi)listBox_ingatlanok.SelectedItem;
                string text = "ingatlan címe: " + rekord.Cim;
                text += Environment.NewLine + "Valóban menteni akarja?";
                rekord_mentes(rekord.tocsv());
                
            }
            else if (ingatlan.GetType() == typeof(Sorhaz))
            {
                Sorhaz rekord = (Sorhaz)listBox_ingatlanok.SelectedItem;
                string text = "ingatlan címe: " + rekord.Cim;
                text += Environment.NewLine + "Valóban menteni akarja?";
                rekord_mentes(rekord.tocsv());
            }
            else if (ingatlan.GetType() == typeof(Penthouse))
            {
                Penthouse rekord = (Penthouse)listBox_ingatlanok.SelectedItem;
                string text = "ingatlan címe: " + rekord.Cim;
                text += Environment.NewLine + "Valóban menteni akarja?";
                rekord_mentes(rekord.tocsv());
            }
            else
            {
                MessageBox.Show("Egyik sem!");
            }
        }

        private void rekord_mentes(string text)
        {
            if (MessageBox.Show(text,"Ingatlan mentése",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                SaveFileDialog savefileDialog = new SaveFileDialog();
                savefileDialog.Filter = "CSV file|*.csv"; //megadaja az operációs rendszernek hogy mi legyen a kiterjesztés (csv,html)
                savefileDialog.ShowDialog();
                if (savefileDialog.FileName!= "")
                {
                    //Érvényes fájlnév! Kezdődhet a mentés
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(savefileDialog.FileName))
                        {
                            sw.WriteLine(text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Sikeres mentés!");
                }
                else
                {
                    MessageBox.Show("A mentés sikertelen!");
                }
            
            }
           
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nincs kész!");

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Title = "adatok mentése";
            //saveFileDialog.Filter = "HTML file|*.html";
            //if (saveFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog.FileName))
            //{
            //    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
            //    {
            //        sw.WriteLine(Csaladi.toHTML());
            //    }

            //    MessageBox.Show("Sikeres mentés!");
            //}
            //else
            //{
            //    MessageBox.Show("Nem történt mentés!");
            //}
        }
    }
}
