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

namespace WindowsFormsAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            Adatbetoltes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_Maximum_Minimum.SelectedIndex=0;
            Adatbetoltes();
        }

        private void Adatbetoltes()
        {
            openFileDialog1.Filter = "vesszővel tagolt csv|*.csv|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Title = "Adatfájl neve";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog1.FileName = "orszagok.csv";
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        listBox_Orszagoklista.Items.Add(new Orszag(sr.ReadLine()));
                    }
                }
            }
        }


        private void button_TeruletekAtlaga_Click(object sender, EventArgs e)
        {
            atlagszamitas2();
        }

        private void atlagszamitas2()
        {
            double atlag = listBox_Orszagoklista.Items.Cast<Orszag>().ToList().Average(a => a.Terulet);
        }

        private void atlagszamitas()
        {
        double atlag = 0;
        foreach (Orszag item in listBox_Orszagoklista.Items)
        {
            atlag += item.Terulet;
        }
        atlag = atlag / listBox_Orszagoklista.Items.Count;

        MessageBox.Show($"Az országok átlaga: {atlag.ToString("#,##0.00")}", "Az országok átlaga", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

        private void button_Megszamolas_Click(object sender, EventArgs e)
        {
            if (radioButton_LegfeljebbSzazEzer.Checked)
            {
                szamolLegfeljebbSzazezer();
            } else
            {
                szamolSzzezerFelett();
            }
        }

        private void szamolSzzezerFelett()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet > 100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"100.000 feletti {db} ", "adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void szamolLegfeljebbSzazezer()
        {
            int db = 0;
            foreach (Orszag item in listBox_Orszagoklista.Items)
            {
                if (item.Terulet<=100000)
                {
                    db++;
                }
            }
            MessageBox.Show($"Maximum 100.000 = {db} ", "adatok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
