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
    public partial class FormVasarlas : Form
    {

        public FormVasarlas()
        {
            InitializeComponent();
        }

        private void FormVasarlas_Load(object sender, EventArgs e)
        {
            updateTermekekLista();
        }

        private void updateTermekekLista()
        {
            listBoxTermekek.Items.Clear();
            Program.command.CommandText = "SELECT `termekid`,`termeknev`,`ar`,`db` FROM `termek` WHERE 1 ORDER BY termeknev";
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBoxTermekek.Items.Add(new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db")));
                    }
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxTermekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTermekek.SelectedIndex<0)
            {
                return;
            }
            Termek kivalasztottTermek = (Termek)listBoxTermekek.SelectedItem;
            textBox_termekid.Text=kivalasztottTermek.termekid.ToString();
            textBox_termeknev.Text = kivalasztottTermek.termeknev;
            numericUpDown_ar.Value = kivalasztottTermek.ar;
            numericUpDown_raktarKeszlet.Value = kivalasztottTermek.db;
            numericUpDown_vasaroltDarab.Maximum = kivalasztottTermek.db;
            numericUpDown_vasaroltDarab.Value = 1;
        }

        private void FormVasarlas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Valóban ki akar lépni?","kilépés",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //System.Windows.Forms.Application.Exit();
                //Environment.Exit(0);
                System.Windows.Forms.Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button_vasarlas_Click(object sender, EventArgs e)
        {
            //-- Erősítse meg a vásárlási szándékot
            string szoveg = $"Valóban meg akar vásárolni " +
                $"{numericUpDown_vasaroltDarab.Value} db " +
                $"{textBox_termeknev.Text} terméket " +
                $"{(numericUpDown_ar.Value * numericUpDown_vasaroltDarab.Value).ToString("#,##0")} Ft értékben?";
            if (MessageBox.Show(szoveg,"megerősítés",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)
            {
                return;
            }
            MySqlTransaction tr = null;

            try
            {
                tr = Program.connection.BeginTransaction();
                Program.command.Transaction = tr; //-- START TRANSACTION
                //-- vásárlás adatainak a rögzítése ------
                Program.command.CommandText = "INSERT INTO `vasarlas` (`vasarloId`, `termekid`,`vasaroltdb`) VALUES (@vasarloid, @termekid, @vasaroltdb);";
                Program.command.Parameters.Clear();
                Program.command.Parameters.AddWithValue("@vasarloid", Program.UserId);
                Program.command.Parameters.AddWithValue("@termekid", textBox_termekid.Text);
                Program.command.Parameters.AddWithValue("@vasaroltdb", numericUpDown_vasaroltDarab.Value);
                Program.command.ExecuteNonQuery();
                //-- a raktárkészlet aktualizálása az eladott mennyiséggel
                Program.command.CommandText = $"UPDATE `termek` SET `db`= db-{numericUpDown_vasaroltDarab.Value} WHERE `termekid`= {textBox_termekid.Text}";
                Program.command.ExecuteNonQuery();
                tr.Commit();
                textBox_termekid.Text = "";
                textBox_termeknev.Text = "";
                numericUpDown_ar.Value = numericUpDown_ar.Minimum;
                numericUpDown_raktarKeszlet.Value = 0;
                numericUpDown_vasaroltDarab.Value = numericUpDown_vasaroltDarab.Minimum;
                MessageBox.Show("Sikeres vásárlás!");
            }
            catch (MySqlException ex)
            {
                tr.Rollback();
                MessageBox.Show("Sikertelen vásárlás!");
            }
            updateTermekekLista();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Termek formTermekUj = new Form_Termek("új");
            formTermekUj.ShowDialog();
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Termek formUpdate = new Form_Termek("módosítás");
            formUpdate.ShowDialog();
        }

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Termek formDelete = new Form_Termek("törlés");
            formDelete.ShowDialog();
        }
    }
}
