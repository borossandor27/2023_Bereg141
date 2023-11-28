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

namespace WindowsFormsAppLogin
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = "SELECT vasarlo.jelszo FROM vasarlo WHERE vasarlo.nev=@nev";
            Program.command.Parameters.Clear();
            Program.command.Parameters.AddWithValue("@nev", textBox_nev.Text);
            MySqlDataReader reader = Program.command.ExecuteReader();
            if (reader.Read())
            {
                string taroltJelszo = reader.GetString("jelszo");
                reader.Close();
                if (taroltJelszo.Equals(textBox_jelszo.Text))
                {
                    //-- Megadott és tárolt jelszó megegyezik
                    this.Hide();
                    Program.formVasarlas.Show();
                }
                else
                {
                    MessageBox.Show("nem jó");
                }
            }
        }
    }
}
