namespace WindowsFormsAlapok
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Forrasfajl = new System.Windows.Forms.TextBox();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.listBox_Orszagoklista = new System.Windows.Forms.ListBox();
            this.button_TeruletekAtlaga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_LegfeljebbSzazEzer = new System.Windows.Forms.RadioButton();
            this.radioButton_szazezerFelett = new System.Windows.Forms.RadioButton();
            this.button_Kiiras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_EredmenyFajlNeve = new System.Windows.Forms.TextBox();
            this.button_Megszamolas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Maximum_Minimum_Valasztas = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_KeresettOrszag = new System.Windows.Forms.TextBox();
            this.checkBox_talalatok_jelolese = new System.Windows.Forms.CheckBox();
            this.button_Kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forrásfájl neve:";
            // 
            // textBox_Forrasfajl
            // 
            this.textBox_Forrasfajl.Location = new System.Drawing.Point(8, 44);
            this.textBox_Forrasfajl.Name = "textBox_Forrasfajl";
            this.textBox_Forrasfajl.Size = new System.Drawing.Size(240, 29);
            this.textBox_Forrasfajl.TabIndex = 1;
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Location = new System.Drawing.Point(8, 86);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(240, 34);
            this.button_Betoltes.TabIndex = 2;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            this.button_Betoltes.Click += new System.EventHandler(this.button_Betoltes_Click);
            // 
            // listBox_Orszagoklista
            // 
            this.listBox_Orszagoklista.FormattingEnabled = true;
            this.listBox_Orszagoklista.ItemHeight = 24;
            this.listBox_Orszagoklista.Location = new System.Drawing.Point(8, 133);
            this.listBox_Orszagoklista.Name = "listBox_Orszagoklista";
            this.listBox_Orszagoklista.Size = new System.Drawing.Size(240, 412);
            this.listBox_Orszagoklista.TabIndex = 3;
            // 
            // button_TeruletekAtlaga
            // 
            this.button_TeruletekAtlaga.Location = new System.Drawing.Point(12, 558);
            this.button_TeruletekAtlaga.Name = "button_TeruletekAtlaga";
            this.button_TeruletekAtlaga.Size = new System.Drawing.Size(240, 34);
            this.button_TeruletekAtlaga.TabIndex = 2;
            this.button_TeruletekAtlaga.Text = "Területek átlaga";
            this.button_TeruletekAtlaga.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_LegfeljebbSzazEzer);
            this.groupBox1.Controls.Add(this.radioButton_szazezerFelett);
            this.groupBox1.Location = new System.Drawing.Point(298, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 114);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk?";
            // 
            // radioButton_LegfeljebbSzazEzer
            // 
            this.radioButton_LegfeljebbSzazEzer.AutoSize = true;
            this.radioButton_LegfeljebbSzazEzer.Location = new System.Drawing.Point(29, 70);
            this.radioButton_LegfeljebbSzazEzer.Name = "radioButton_LegfeljebbSzazEzer";
            this.radioButton_LegfeljebbSzazEzer.Size = new System.Drawing.Size(247, 28);
            this.radioButton_LegfeljebbSzazEzer.TabIndex = 1;
            this.radioButton_LegfeljebbSzazEzer.TabStop = true;
            this.radioButton_LegfeljebbSzazEzer.Text = "legfeljebb 100.000 területű";
            this.radioButton_LegfeljebbSzazEzer.UseVisualStyleBackColor = true;
            // 
            // radioButton_szazezerFelett
            // 
            this.radioButton_szazezerFelett.AutoSize = true;
            this.radioButton_szazezerFelett.Location = new System.Drawing.Point(29, 29);
            this.radioButton_szazezerFelett.Name = "radioButton_szazezerFelett";
            this.radioButton_szazezerFelett.Size = new System.Drawing.Size(271, 28);
            this.radioButton_szazezerFelett.TabIndex = 0;
            this.radioButton_szazezerFelett.TabStop = true;
            this.radioButton_szazezerFelett.Text = "100.000-nél nagyobb területű";
            this.radioButton_szazezerFelett.UseVisualStyleBackColor = true;
            // 
            // button_Kiiras
            // 
            this.button_Kiiras.Location = new System.Drawing.Point(298, 265);
            this.button_Kiiras.Name = "button_Kiiras";
            this.button_Kiiras.Size = new System.Drawing.Size(335, 42);
            this.button_Kiiras.TabIndex = 5;
            this.button_Kiiras.Text = "Kiírás";
            this.button_Kiiras.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Eredményfájl neve:";
            // 
            // textBox_EredmenyFajlNeve
            // 
            this.textBox_EredmenyFajlNeve.Location = new System.Drawing.Point(298, 226);
            this.textBox_EredmenyFajlNeve.Name = "textBox_EredmenyFajlNeve";
            this.textBox_EredmenyFajlNeve.Size = new System.Drawing.Size(328, 29);
            this.textBox_EredmenyFajlNeve.TabIndex = 7;
            // 
            // button_Megszamolas
            // 
            this.button_Megszamolas.Location = new System.Drawing.Point(298, 140);
            this.button_Megszamolas.Name = "button_Megszamolas";
            this.button_Megszamolas.Size = new System.Drawing.Size(335, 42);
            this.button_Megszamolas.TabIndex = 5;
            this.button_Megszamolas.Text = "Megszámolás";
            this.button_Megszamolas.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maximum vagy minimum?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox1.Location = new System.Drawing.Point(298, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 32);
            this.comboBox1.TabIndex = 9;
            // 
            // button_Maximum_Minimum_Valasztas
            // 
            this.button_Maximum_Minimum_Valasztas.Location = new System.Drawing.Point(298, 393);
            this.button_Maximum_Minimum_Valasztas.Name = "button_Maximum_Minimum_Valasztas";
            this.button_Maximum_Minimum_Valasztas.Size = new System.Drawing.Size(335, 42);
            this.button_Maximum_Minimum_Valasztas.TabIndex = 5;
            this.button_Maximum_Minimum_Valasztas.Text = "Minimum/Maximum választás";
            this.button_Maximum_Minimum_Valasztas.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ország keresése:";
            // 
            // textBox_KeresettOrszag
            // 
            this.textBox_KeresettOrszag.Location = new System.Drawing.Point(298, 479);
            this.textBox_KeresettOrszag.Name = "textBox_KeresettOrszag";
            this.textBox_KeresettOrszag.Size = new System.Drawing.Size(263, 29);
            this.textBox_KeresettOrszag.TabIndex = 11;
            // 
            // checkBox_talalatok_jelolese
            // 
            this.checkBox_talalatok_jelolese.AutoSize = true;
            this.checkBox_talalatok_jelolese.Location = new System.Drawing.Point(298, 518);
            this.checkBox_talalatok_jelolese.Name = "checkBox_talalatok_jelolese";
            this.checkBox_talalatok_jelolese.Size = new System.Drawing.Size(173, 28);
            this.checkBox_talalatok_jelolese.TabIndex = 12;
            this.checkBox_talalatok_jelolese.Text = "Találatok jelölése";
            this.checkBox_talalatok_jelolese.UseVisualStyleBackColor = true;
            // 
            // button_Kereses
            // 
            this.button_Kereses.Location = new System.Drawing.Point(298, 556);
            this.button_Kereses.Name = "button_Kereses";
            this.button_Kereses.Size = new System.Drawing.Size(335, 42);
            this.button_Kereses.TabIndex = 5;
            this.button_Kereses.Text = "Keresés";
            this.button_Kereses.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 831);
            this.Controls.Add(this.checkBox_talalatok_jelolese);
            this.Controls.Add(this.textBox_KeresettOrszag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_EredmenyFajlNeve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Megszamolas);
            this.Controls.Add(this.button_Kereses);
            this.Controls.Add(this.button_Maximum_Minimum_Valasztas);
            this.Controls.Add(this.button_Kiiras);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Orszagoklista);
            this.Controls.Add(this.button_TeruletekAtlaga);
            this.Controls.Add(this.button_Betoltes);
            this.Controls.Add(this.textBox_Forrasfajl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Példa Windows Form alkalmazás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Forrasfajl;
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.ListBox listBox_Orszagoklista;
        private System.Windows.Forms.Button button_TeruletekAtlaga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_LegfeljebbSzazEzer;
        private System.Windows.Forms.RadioButton radioButton_szazezerFelett;
        private System.Windows.Forms.Button button_Kiiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_EredmenyFajlNeve;
        private System.Windows.Forms.Button button_Megszamolas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Maximum_Minimum_Valasztas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_KeresettOrszag;
        private System.Windows.Forms.CheckBox checkBox_talalatok_jelolese;
        private System.Windows.Forms.Button button_Kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

