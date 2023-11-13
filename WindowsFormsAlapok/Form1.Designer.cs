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
            this.listBox_Orszagoklista = new System.Windows.Forms.ListBox();
            this.button_TeruletekAtlaga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_LegfeljebbSzazEzer = new System.Windows.Forms.RadioButton();
            this.radioButton_szazezerFelett = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_EredmenyFajlNeve = new System.Windows.Forms.TextBox();
            this.button_Kiiras = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_Maximum_Minimum_Valasztas = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_talalatok_jelolese = new System.Windows.Forms.CheckBox();
            this.textBox_KeresettOrszag = new System.Windows.Forms.TextBox();
            this.button_Kereses = new System.Windows.Forms.Button();
            this.button_Megszamolas = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_Betoltes = new System.Windows.Forms.Button();
            this.textBox_Forrasfajl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Orszagoklista
            // 
            this.listBox_Orszagoklista.FormattingEnabled = true;
            this.listBox_Orszagoklista.ItemHeight = 24;
            this.listBox_Orszagoklista.Location = new System.Drawing.Point(8, 133);
            this.listBox_Orszagoklista.Name = "listBox_Orszagoklista";
            this.listBox_Orszagoklista.Size = new System.Drawing.Size(298, 412);
            this.listBox_Orszagoklista.TabIndex = 3;
            // 
            // button_TeruletekAtlaga
            // 
            this.button_TeruletekAtlaga.Location = new System.Drawing.Point(12, 584);
            this.button_TeruletekAtlaga.Name = "button_TeruletekAtlaga";
            this.button_TeruletekAtlaga.Size = new System.Drawing.Size(294, 40);
            this.button_TeruletekAtlaga.TabIndex = 2;
            this.button_TeruletekAtlaga.Text = "Területek átlaga";
            this.button_TeruletekAtlaga.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button_Megszamolas);
            this.groupBox1.Controls.Add(this.radioButton_LegfeljebbSzazEzer);
            this.groupBox1.Controls.Add(this.radioButton_szazezerFelett);
            this.groupBox1.Location = new System.Drawing.Point(337, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 157);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.textBox_EredmenyFajlNeve);
            this.groupBox2.Controls.Add(this.button_Kiiras);
            this.groupBox2.Location = new System.Drawing.Point(337, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 126);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eredményfájl neve";
            // 
            // textBox_EredmenyFajlNeve
            // 
            this.textBox_EredmenyFajlNeve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_EredmenyFajlNeve.Location = new System.Drawing.Point(20, 27);
            this.textBox_EredmenyFajlNeve.Name = "textBox_EredmenyFajlNeve";
            this.textBox_EredmenyFajlNeve.Size = new System.Drawing.Size(335, 29);
            this.textBox_EredmenyFajlNeve.TabIndex = 12;
            // 
            // button_Kiiras
            // 
            this.button_Kiiras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Kiiras.Location = new System.Drawing.Point(20, 66);
            this.button_Kiiras.Name = "button_Kiiras";
            this.button_Kiiras.Size = new System.Drawing.Size(335, 42);
            this.button_Kiiras.TabIndex = 11;
            this.button_Kiiras.Text = "Kiírás";
            this.button_Kiiras.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.button_Maximum_Minimum_Valasztas);
            this.groupBox3.Location = new System.Drawing.Point(337, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 132);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Maximum vagy minimum?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox1.Location = new System.Drawing.Point(20, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 32);
            this.comboBox1.TabIndex = 12;
            // 
            // button_Maximum_Minimum_Valasztas
            // 
            this.button_Maximum_Minimum_Valasztas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Maximum_Minimum_Valasztas.Location = new System.Drawing.Point(20, 78);
            this.button_Maximum_Minimum_Valasztas.Name = "button_Maximum_Minimum_Valasztas";
            this.button_Maximum_Minimum_Valasztas.Size = new System.Drawing.Size(335, 42);
            this.button_Maximum_Minimum_Valasztas.TabIndex = 10;
            this.button_Maximum_Minimum_Valasztas.Text = "Minimum/Maximum választás";
            this.button_Maximum_Minimum_Valasztas.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.checkBox_talalatok_jelolese);
            this.groupBox4.Controls.Add(this.textBox_KeresettOrszag);
            this.groupBox4.Controls.Add(this.button_Kereses);
            this.groupBox4.Location = new System.Drawing.Point(337, 464);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(375, 167);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ország keresése";
            // 
            // checkBox_talalatok_jelolese
            // 
            this.checkBox_talalatok_jelolese.AutoSize = true;
            this.checkBox_talalatok_jelolese.Location = new System.Drawing.Point(20, 80);
            this.checkBox_talalatok_jelolese.Name = "checkBox_talalatok_jelolese";
            this.checkBox_talalatok_jelolese.Size = new System.Drawing.Size(173, 28);
            this.checkBox_talalatok_jelolese.TabIndex = 16;
            this.checkBox_talalatok_jelolese.Text = "Találatok jelölése";
            this.checkBox_talalatok_jelolese.UseVisualStyleBackColor = true;
            // 
            // textBox_KeresettOrszag
            // 
            this.textBox_KeresettOrszag.Location = new System.Drawing.Point(20, 41);
            this.textBox_KeresettOrszag.Name = "textBox_KeresettOrszag";
            this.textBox_KeresettOrszag.Size = new System.Drawing.Size(335, 29);
            this.textBox_KeresettOrszag.TabIndex = 15;
            // 
            // button_Kereses
            // 
            this.button_Kereses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_Kereses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Kereses.Location = new System.Drawing.Point(20, 118);
            this.button_Kereses.Name = "button_Kereses";
            this.button_Kereses.Size = new System.Drawing.Size(335, 42);
            this.button_Kereses.TabIndex = 13;
            this.button_Kereses.Text = "Keresés";
            this.button_Kereses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Kereses.UseVisualStyleBackColor = false;
            // 
            // button_Megszamolas
            // 
            this.button_Megszamolas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Megszamolas.Location = new System.Drawing.Point(20, 104);
            this.button_Megszamolas.Name = "button_Megszamolas";
            this.button_Megszamolas.Size = new System.Drawing.Size(335, 42);
            this.button_Megszamolas.TabIndex = 6;
            this.button_Megszamolas.Text = "Megszámolás";
            this.button_Megszamolas.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.button_Betoltes);
            this.groupBox5.Controls.Add(this.textBox_Forrasfajl);
            this.groupBox5.Location = new System.Drawing.Point(8, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(298, 114);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Forrásfájl neve";
            // 
            // button_Betoltes
            // 
            this.button_Betoltes.Location = new System.Drawing.Point(16, 70);
            this.button_Betoltes.Name = "button_Betoltes";
            this.button_Betoltes.Size = new System.Drawing.Size(264, 34);
            this.button_Betoltes.TabIndex = 5;
            this.button_Betoltes.Text = "Betöltés";
            this.button_Betoltes.UseVisualStyleBackColor = true;
            // 
            // textBox_Forrasfajl
            // 
            this.textBox_Forrasfajl.Location = new System.Drawing.Point(16, 32);
            this.textBox_Forrasfajl.Name = "textBox_Forrasfajl";
            this.textBox_Forrasfajl.Size = new System.Drawing.Size(264, 29);
            this.textBox_Forrasfajl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 643);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_Orszagoklista);
            this.Controls.Add(this.button_TeruletekAtlaga);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Példa Windows Form alkalmazás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Orszagoklista;
        private System.Windows.Forms.Button button_TeruletekAtlaga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_LegfeljebbSzazEzer;
        private System.Windows.Forms.RadioButton radioButton_szazezerFelett;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_EredmenyFajlNeve;
        private System.Windows.Forms.Button button_Kiiras;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_Maximum_Minimum_Valasztas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_talalatok_jelolese;
        private System.Windows.Forms.TextBox textBox_KeresettOrszag;
        private System.Windows.Forms.Button button_Kereses;
        private System.Windows.Forms.Button button_Megszamolas;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button_Betoltes;
        private System.Windows.Forms.TextBox textBox_Forrasfajl;
    }
}

