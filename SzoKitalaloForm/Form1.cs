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

namespace SzoKitalaloForm
{
    public partial class Form_Jatek : Form
    {
        string[] abc = { "A", "Á", "B", "C", "D", "E", "É", "F", "G", "H", "I", "Í", "J", "K", "L", "M", "N", "O", "Ó", "Ö", "Ő", "P", "R", "S", "T", "U", "Ú", "Ü", "Ű", "V", "Z" };
        string[] szavak;
        Random rand = new Random();
        int buttonSize = 30;
        string kitalaltSzo = string.Empty;
        public Form_Jatek()
        {
            InitializeComponent();
        }

        private void Form_Jatek_Load(object sender, EventArgs e)
        {
            SzavakBeolvasasa();
            gondolokEgySzora();
            abctKipakol();
        }

        private void abctKipakol()
        {
            panel_Abc.Controls.Clear();
            int betuPerSor = 4;

            for (int i = 0; i < abc.Length; i++)
            {
                Button betuButton = new Button();
                betuButton.Tag = abc[i];
                betuButton.Text = abc[i];
                
                if (i%betuPerSor == 0)
                {
                    j = 0;
                }
                else
                {
                    j++;
                }
                betuButton.SetBounds(i * buttonSize, j * buttonSize, buttonSize, buttonSize);
                panel_Abc.Controls.Add(betuButton);
            }
        }

        private void gondolokEgySzora()
        {
            int index = rand.Next(0, szavak.Length);
            kitalaltSzo = szavak[index];
            //-- kirakjuk a panelre betűnként ---
            panel_KitalaltSzo.Controls.Clear();
            for (int i = 0; i < kitalaltSzo.Length; i++)
            {
                Button betuButton = new Button();
                betuButton.Tag = kitalaltSzo[i];
                betuButton.Text = "_";
                betuButton.SetBounds(i * buttonSize, 0, buttonSize, buttonSize);
                panel_KitalaltSzo.Controls.Add(betuButton);
            }
        }

        private void SzavakBeolvasasa()
        {
            string szavakFajl = "szavak.txt";
            if (!File.Exists(szavakFajl))
            {
                MessageBox.Show("Nincsenek kitalálható szavak!");
                Environment.Exit(0);
            }
            using (StreamReader sr = new StreamReader(szavakFajl))
            {
                szavak = sr.ReadToEnd().Replace("\"", "").Replace(" ", "").Split(',');
            }
        }
    }
}
