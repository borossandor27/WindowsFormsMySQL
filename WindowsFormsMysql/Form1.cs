using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsMysql
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand sql = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "autok";
            sb.CharacterSet = "utf8";
            connection = new MySqlConnection(sb.ToString());
            sql = connection.CreateCommand();
            autokAdatinakBetolteseAdatbazisbol();
        }

        private void autokAdatinakBetolteseAdatbazisbol()
        {
            listBox_Autok.Items.Clear();
            try
            {
                connection.Open();
                sql.CommandText = "SELECT `id`,`rendszam`,`gyartmany`,`tipus` FROM `autok` WHERE 1;";
                using (MySqlDataReader dr = sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Auto uj = new Auto(dr.GetInt32("id"), dr.GetString("rendszam"), dr.GetString("gyartmany"), dr.GetString("tipus"));
                        listBox_Autok.Items.Add(uj);
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Rendszam.Text))
            {
                MessageBox.Show("Kötelező kitölteni");
                return;
            }
             if (string.IsNullOrEmpty(textBox_Gyartmany.Text))
            {
                MessageBox.Show("Kötelező kitölteni");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Tipus.Text))
            {
                MessageBox.Show("Kötelező kitölteni");
                return;
            }
            sql.CommandText = "INSERT INTO `autok` (`id`, `rendszam`, `gyartmany`, `tipus`) VALUES (@kod, @rendszam, @gyartmany, @tipus);";
            sql.Parameters.AddWithValue("@kod", textBox_Kod.Text);
            sql.Parameters.AddWithValue("@rendszam", textBox_Rendszam.Text);
            sql.Parameters.AddWithValue("@gyartmany", textBox_Gyartmany.Text);
            sql.Parameters.AddWithValue("@tipus", textBox_Tipus.Text);
            try
            {
                connection.Open();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            autokAdatinakBetolteseAdatbazisbol();
            textBox_Kod.Text = "";
            textBox_Gyartmany.Text = "";
            textBox_Rendszam.Text = "";
            textBox_Tipus.Text = "";
        }

        private void listBox_Autok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Auto kivalasztott = (Auto)listBox_Autok.SelectedItem;
            textBox_Kod.Text = kivalasztott.Kod.ToString();
            textBox_Gyartmany.Text = kivalasztott.Gyartmany;
            textBox_Rendszam.Text = kivalasztott.Rendszam;
            textBox_Tipus.Text = kivalasztott.Tipus;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Auto kiv = (Auto)listBox_Autok.SelectedItem;
            try
            {
                connection.Open();
                sql.CommandText = "DELETE FROM `autok` WHERE `id`=" + kiv.Kod;
                sql.ExecuteNonQuery();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            autokAdatinakBetolteseAdatbazisbol();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            //-- a listboxban van-e kiválasztott elem?
            if(listBox_Autok.SelectedIndex < 0)
            {
                return;
            }
            //- adatmezők tartalmának az ellenőrzése
            if (string.IsNullOrEmpty(textBox_Rendszam.Text))
            {
                MessageBox.Show("Kötelező kitölteni");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Gyartmany.Text))
            {
                MessageBox.Show("Kötelező kitölteni");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Tipus.Text))
            {
                MessageBox.Show("Kötelező kitölteni");
                return;
            }
 
            sql.CommandText = "UPDATE `autok` SET rendszam=@rendszam,`gyartmany`=@gyartmany,`tipus`=@tipus WHERE `id`= @id;";
            string kod = textBox_Kod.Text;
            string gyartmany = textBox_Gyartmany.Text;
            string rendszam = textBox_Rendszam.Text;
            string tipus = textBox_Tipus.Text;
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@rendszam", rendszam);
            sql.Parameters.AddWithValue("@gyartmany", gyartmany);
            sql.Parameters.AddWithValue("@tipus", tipus);
            sql.Parameters.AddWithValue("@id", kod);
            try
            {
                connection.Open();
                if (sql.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("A módosítás sikertelen!");
                    return;
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("A módosítás sikeres!");
                    autokAdatinakBetolteseAdatbazisbol();
                    textBox_Kod.Text = "";
                    textBox_Gyartmany.Text = "";
                    textBox_Rendszam.Text = "";
                    textBox_Tipus.Text = "";
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
