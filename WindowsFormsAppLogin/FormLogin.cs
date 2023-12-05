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

            if (Program.db.validUser(textBox_nev.Text,textBox_jelszo.Text)>=0)
            {
                Program.formVasarlas.Show();
            }

        }
    }
}
