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
    public partial class Form_Termek : Form
    {
        string mod = null;
        Termek kivalasztottTermek = null;
        public Form_Termek(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Form_Termek_Load(object sender, EventArgs e)
        {
            if(Program.formVasarlas.listBoxTermekek.SelectedIndex>=0)
            {
                kivalasztottTermek = (Termek)Program.formVasarlas.listBoxTermekek.SelectedItem;
            }
            switch (this.mod)
            {
                case "új":
                    this.Text = "Új termék felvitele";
                    button_muvelet.Text = "Új termék felvitele";
                    break;
                case "módosítás":
                    this.Text = "termék adatainak a módosítása";
                    button_muvelet.Text = "termék adatainak a módosítása";
                    adatokBetolteseMezokbe();
                    break;
                case "törlés":
                    this.Text = "termék törlése";
                    button_muvelet.Text = "termék törlése";
                    adatokBetolteseMezokbe();
                    break;
                default:
                    break;
            }

        }

        private void adatokBetolteseMezokbe()
        {
            textBox_termekid.Text = kivalasztottTermek.termekid.ToString();
            textBox_termeknev.Text = kivalasztottTermek.termeknev;
            numericUpDown_egysegar.Value = kivalasztottTermek.ar;
            numericUpDown_raktarkeszlet.Value = kivalasztottTermek.db;
        }
    }
}
