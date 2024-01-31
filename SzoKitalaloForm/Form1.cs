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
        Panel panel_Kijelzo = new Panel();
        int tippIndex = 0;

        public Form_Jatek()
        {
            InitializeComponent();
        }

        private void Form_Jatek_Load(object sender, EventArgs e)
        {
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.ColumnCount = 3;
                        tableLayoutPanel.RowCount = 4;
            tableLayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Percent,15);
            tableLayoutPanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent,65);
            tableLayoutPanel.ColumnStyles[2] = new ColumnStyle(SizeType.Percent,20);


            //-- 3. oszlopban az eddigi tippek 3 sor magasságban ---
            ListBox listBoxEddigiTippek = controlEddigiTippek();
            tableLayoutPanel.SetRowSpan(listBoxEddigiTippek, 3);
            tableLayoutPanel.Controls.Add(listBoxEddigiTippek,2,0);

            //-- legfelső sorban a kitalálandó szó ---
            tableLayoutPanel.Controls.Add(feliratGondoltSzo(), 0, 0);
            tableLayoutPanel.Controls.Add(panel_KitalaltSzo,1,0);
            //-- 2. sorban a tippelés
            
            tableLayoutPanel.Controls.Add(feliratTipp(), 0,1);
            tableLayoutPanel.Controls.Add(panel_tipp, 1, 1);
            panel_Abc.Dock = DockStyle.Fill;
            //-- 3. sorban virtuális billentyű -----
            tableLayoutPanel.Controls.Add(panel_Abc, 1, 2);
            //-- 4. sorban egy kijelző -----
            tableLayoutPanel.Controls.Add(panel_Kijelzo, 0, 3);
            tableLayoutPanel.SetColumnSpan(panel_Kijelzo, 2);
            Kijelez("kezdődhet a játék!");
            SzavakBeolvasasa();
            gondolokEgySzora();
            abctKipakol();
            uresTippek();
        }

        private void Kijelez(string szoveg)
        {
            panel_Kijelzo.Controls.Clear();
            Label label=new Label();    
            label.Text=szoveg;
            label.Dock = DockStyle.Fill;
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;
            panel_Kijelzo.Controls.Add(label);
        }

        private Control feliratTipp()
        {
            Label feliratTipp = new Label();
            feliratTipp.Text = "Az ön tippje:";
            feliratTipp.Dock = DockStyle.Fill;
            feliratTipp.TextAlign = ContentAlignment.TopRight;
            return feliratTipp;
        }

        private Control feliratGondoltSzo()
        {
            Label feliratGondoltSzo = new Label();
            feliratGondoltSzo.Text = "Gondolt szó: ";
            feliratGondoltSzo.Dock = DockStyle.Fill;
            feliratGondoltSzo.TextAlign = ContentAlignment.TopRight;
            return feliratGondoltSzo;
        }

        private ListBox controlEddigiTippek()
        {
            ListBox lb = new ListBox();
            lb.Enabled = false;
            //lb.ColumnWidth = 200;
            lb.Items.Clear();
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Items.Add("szó");
            lb.Dock = DockStyle.Fill;
            
            return lb;
        }

        private void uresTippek()
        {
             panel_tipp.Controls.Clear();
            for (int i = 0; i < kitalaltSzo.Length; i++)
            {
                Button betuButton = new Button();
                betuButton.Tag = string.Empty;
                betuButton.Enabled = false;
                betuButton.Text = "_";
                betuButton.SetBounds(i * buttonSize, 0, buttonSize, buttonSize);
                panel_tipp.Controls.Add(betuButton);
            }
            Button tippButton = new Button();
            tippButton.Tag = string.Empty;

            tippButton.Text = "Tippelek";
            tippButton.AutoSize = true;
            tippButton.Location = new Point(kitalaltSzo.Length * buttonSize+40, 0);
            tippButton.Size = new Size(100, buttonSize);
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
                betuButton.Click += betuButton_Click;
                panel_Abc.Controls.Add(betuButton);
            }
        }

        private void betuButton_Click(object sender, EventArgs e)
        {
            Button betuButton = (Button)sender;
            panel_tipp.Controls[tippIndex].Text = betuButton.Text;
            tippIndex = (tippIndex < kitalaltSzo.Length - 1 ? tippIndex+1 : 0);
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
            panel_KitalaltSzo.Dock= DockStyle.Fill;
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
