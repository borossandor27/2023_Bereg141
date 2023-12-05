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
            listBoxTermekek.Items.AddRange(Program.db.getTermekek().ToArray());
            
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
            if (Program.db.vasarlas(int.Parse(textBox_termekid.Text), numericUpDown_vasaroltDarab.Value))
            {
                MessageBox.Show("Sikeres vásárlás");
            }
            else
            {
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
