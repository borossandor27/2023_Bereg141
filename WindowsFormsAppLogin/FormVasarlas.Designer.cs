namespace WindowsFormsAppLogin
{
    partial class FormVasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVasarlas));
            this.listBoxTermekek = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_vasarlas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_vasaroltDarab = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_ar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_raktarKeszlet = new System.Windows.Forms.NumericUpDown();
            this.textBox_termeknev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_termekid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.terméToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jelszóVáltozásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vasaroltDarab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarKeszlet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTermekek
            // 
            this.listBoxTermekek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxTermekek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxTermekek.FormattingEnabled = true;
            this.listBoxTermekek.ItemHeight = 20;
            this.listBoxTermekek.Location = new System.Drawing.Point(0, 0);
            this.listBoxTermekek.Name = "listBoxTermekek";
            this.listBoxTermekek.Size = new System.Drawing.Size(166, 374);
            this.listBoxTermekek.TabIndex = 0;
            this.listBoxTermekek.SelectedIndexChanged += new System.EventHandler(this.listBoxTermekek_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_vasarlas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown_vasaroltDarab);
            this.groupBox1.Controls.Add(this.numericUpDown_ar);
            this.groupBox1.Controls.Add(this.numericUpDown_raktarKeszlet);
            this.groupBox1.Controls.Add(this.textBox_termeknev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_termekid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(194, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott termék";
            // 
            // button_vasarlas
            // 
            this.button_vasarlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_vasarlas.Image = global::WindowsFormsAppLogin.Properties.Resources.Fasticon_Shop_Cart_Shop_cart_24;
            this.button_vasarlas.Location = new System.Drawing.Point(16, 228);
            this.button_vasarlas.Name = "button_vasarlas";
            this.button_vasarlas.Size = new System.Drawing.Size(285, 48);
            this.button_vasarlas.TabIndex = 8;
            this.button_vasarlas.Text = "Vásárlás";
            this.button_vasarlas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_vasarlas.UseVisualStyleBackColor = true;
            this.button_vasarlas.Click += new System.EventHandler(this.button_vasarlas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vásárolt darab";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Raktár készlet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Egységár";
            // 
            // numericUpDown_vasaroltDarab
            // 
            this.numericUpDown_vasaroltDarab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_vasaroltDarab.Location = new System.Drawing.Point(149, 180);
            this.numericUpDown_vasaroltDarab.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_vasaroltDarab.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_vasaroltDarab.Name = "numericUpDown_vasaroltDarab";
            this.numericUpDown_vasaroltDarab.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_vasaroltDarab.TabIndex = 4;
            this.numericUpDown_vasaroltDarab.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_vasaroltDarab.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_ar
            // 
            this.numericUpDown_ar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_ar.Location = new System.Drawing.Point(149, 100);
            this.numericUpDown_ar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_ar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_ar.Name = "numericUpDown_ar";
            this.numericUpDown_ar.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_ar.TabIndex = 4;
            this.numericUpDown_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_ar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_raktarKeszlet
            // 
            this.numericUpDown_raktarKeszlet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_raktarKeszlet.Location = new System.Drawing.Point(149, 140);
            this.numericUpDown_raktarKeszlet.Name = "numericUpDown_raktarKeszlet";
            this.numericUpDown_raktarKeszlet.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_raktarKeszlet.TabIndex = 4;
            this.numericUpDown_raktarKeszlet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox_termeknev
            // 
            this.textBox_termeknev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_termeknev.Location = new System.Drawing.Point(149, 60);
            this.textBox_termeknev.Name = "textBox_termeknev";
            this.textBox_termeknev.Size = new System.Drawing.Size(152, 26);
            this.textBox_termeknev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Terméknév";
            // 
            // textBox_termekid
            // 
            this.textBox_termekid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_termekid.Location = new System.Drawing.Point(149, 20);
            this.textBox_termekid.Name = "textBox_termekid";
            this.textBox_termekid.ReadOnly = true;
            this.textBox_termekid.Size = new System.Drawing.Size(90, 26);
            this.textBox_termekid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék azonosító";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terméToolStripMenuItem,
            this.felhasználóToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(166, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // terméToolStripMenuItem
            // 
            this.terméToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.terméToolStripMenuItem.Name = "terméToolStripMenuItem";
            this.terméToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.terméToolStripMenuItem.Text = "Termé";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // felhasználóToolStripMenuItem1
            // 
            this.felhasználóToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jelszóVáltozásToolStripMenuItem});
            this.felhasználóToolStripMenuItem1.Name = "felhasználóToolStripMenuItem1";
            this.felhasználóToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.felhasználóToolStripMenuItem1.Text = "Felhasználó";
            // 
            // jelszóVáltozásToolStripMenuItem
            // 
            this.jelszóVáltozásToolStripMenuItem.Name = "jelszóVáltozásToolStripMenuItem";
            this.jelszóVáltozásToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.jelszóVáltozásToolStripMenuItem.Text = "Jelszó változás";
            // 
            // FormVasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 374);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxTermekek);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormVasarlas";
            this.Text = "FormVasarlas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVasarlas_FormClosing);
            this.Load += new System.EventHandler(this.FormVasarlas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_vasaroltDarab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarKeszlet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_ar;
        private System.Windows.Forms.NumericUpDown numericUpDown_raktarKeszlet;
        private System.Windows.Forms.TextBox textBox_termeknev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_termekid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_vasarlas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_vasaroltDarab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem terméToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jelszóVáltozásToolStripMenuItem;
        public System.Windows.Forms.ListBox listBoxTermekek;
    }
}