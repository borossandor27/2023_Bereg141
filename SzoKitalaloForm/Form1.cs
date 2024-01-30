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
using System.Windows;

namespace SzoKitalaloForm
{
    public partial class Form_Jatek : Form
    {
        string[] abc = { "A", "Á", "B", "C", "D", "E", "É", "F", "G", "H", "I", "Í", "J", "K", "L", "M", "N", "O", "Ó", "Ö", "Ő", "P", "R", "S", "T", "U", "Ú", "Ü", "Ű", "V", "Z" };
        string[] szavak;
        Random rand = new Random();
        int buttonSize = 30;
        string kitalaltSzo = string.Empty;
        Panel panel_tipp = new Panel();
        Panel panel_Abc = new Panel();
        Panel panel_KitalaltSzo = new Panel();
        public Form_Jatek()
        {
            InitializeComponent();
        }

        private void Form_Jatek_Load(object sender, EventArgs e)
        {
            tableLayoutPanel.AutoSize = true;
            
            Label feliratGondoltSzo = new Label();
            feliratGondoltSzo.Text = "Gondolt szó:";
            feliratGondoltSzo.Dock = DockStyle.Fill;
            feliratGondoltSzo.TextAlign=ContentAlignment.TopRight;
            tableLayoutPanel.Controls.Add(feliratGondoltSzo, 0, 0);
            tableLayoutPanel.Controls.Add(panel_KitalaltSzo);
            Label feliratTipp= new Label();
            feliratTipp.Text = "Az ön tippje:";
            feliratTipp.Dock = DockStyle.Fill;  
            feliratTipp.TextAlign=ContentAlignment.TopRight;
            tableLayoutPanel.Controls.Add(feliratTipp, 0,1);
            tableLayoutPanel.Controls.Add(panel_tipp, 1, 1);
            panel_Abc.Dock = DockStyle.Fill;

            tableLayoutPanel.Controls.Add(panel_Abc, 1, 2);
            
            SzavakBeolvasasa();
            gondolokEgySzora();
            abctKipakol();
            uresTippek();
        }

        private void uresTippek()
        {
             panel_tipp.Controls.Clear();
            for (int i = 0; i < kitalaltSzo.Length; i++)
            {
                Button betuButton = new Button();
                betuButton.Tag = string.Empty;
                betuButton.Text = "_";
                betuButton.SetBounds(i * buttonSize, 0, buttonSize, buttonSize);
                panel_tipp.Controls.Add(betuButton);
            }
            Button tippButton = new Button();
            tippButton.Tag = string.Empty;
            tippButton.Text = "Tippelek";
            tippButton.AutoSize = true;
            tippButton.Location = new Point(kitalaltSzo.Length * buttonSize+40, 0);
            tippButton.Size = new Size(200, buttonSize);
            panel_tipp.Controls.Add(tippButton);
            panel_tipp.Dock = DockStyle.Fill;
        }

        private void abctKipakol()
        {
            panel_Abc.Controls.Clear();
            int betuPerSor = 10;

            for (int i = 0; i < abc.Length; i++)
            {
                int sor = (int)i / betuPerSor;
                Button betuButton = new Button();
                betuButton.Tag = abc[i];
                betuButton.Text = abc[i];
                
                betuButton.SetBounds((i-sor*betuPerSor) * buttonSize, sor * buttonSize, buttonSize, buttonSize);
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
                System.Windows.Forms.MessageBox.Show("Nincsenek kitalálható szavak!");
                Environment.Exit(0);
            }
            using (StreamReader sr = new StreamReader(szavakFajl))
            {
                szavak = sr.ReadToEnd().Replace("\"", "").Replace(" ", "").Split(',');
            }
        }
    }
}
