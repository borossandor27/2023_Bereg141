namespace WindowsFormsAppLogin
{
    partial class Form_Termek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_termekid = new System.Windows.Forms.TextBox();
            this.textBox_termeknev = new System.Windows.Forms.TextBox();
            this.numericUpDown_egysegar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_raktarkeszlet = new System.Windows.Forms.NumericUpDown();
            this.button_muvelet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarkeszlet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_raktarkeszlet);
            this.groupBox1.Controls.Add(this.numericUpDown_egysegar);
            this.groupBox1.Controls.Add(this.textBox_termeknev);
            this.groupBox1.Controls.Add(this.textBox_termekid);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Termék adatai";
            // 
            // textBox_termekid
            // 
            this.textBox_termekid.Location = new System.Drawing.Point(57, 40);
            this.textBox_termekid.Name = "textBox_termekid";
            this.textBox_termekid.Size = new System.Drawing.Size(100, 20);
            this.textBox_termekid.TabIndex = 0;
            // 
            // textBox_termeknev
            // 
            this.textBox_termeknev.Location = new System.Drawing.Point(57, 78);
            this.textBox_termeknev.Name = "textBox_termeknev";
            this.textBox_termeknev.Size = new System.Drawing.Size(165, 20);
            this.textBox_termeknev.TabIndex = 1;
            // 
            // numericUpDown_egysegar
            // 
            this.numericUpDown_egysegar.Location = new System.Drawing.Point(57, 119);
            this.numericUpDown_egysegar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_egysegar.Name = "numericUpDown_egysegar";
            this.numericUpDown_egysegar.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_egysegar.TabIndex = 2;
            // 
            // numericUpDown_raktarkeszlet
            // 
            this.numericUpDown_raktarkeszlet.Location = new System.Drawing.Point(57, 156);
            this.numericUpDown_raktarkeszlet.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_raktarkeszlet.Name = "numericUpDown_raktarkeszlet";
            this.numericUpDown_raktarkeszlet.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_raktarkeszlet.TabIndex = 3;
            // 
            // button_muvelet
            // 
            this.button_muvelet.Location = new System.Drawing.Point(35, 264);
            this.button_muvelet.Name = "button_muvelet";
            this.button_muvelet.Size = new System.Drawing.Size(371, 39);
            this.button_muvelet.TabIndex = 2;
            this.button_muvelet.Text = "button1";
            this.button_muvelet.UseVisualStyleBackColor = true;
            // 
            // Form_Termek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 333);
            this.Controls.Add(this.button_muvelet);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Termek";
            this.Text = "Form_Termek";
            this.Load += new System.EventHandler(this.Form_Termek_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_egysegar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarkeszlet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_egysegar;
        private System.Windows.Forms.TextBox textBox_termeknev;
        private System.Windows.Forms.TextBox textBox_termekid;
        private System.Windows.Forms.NumericUpDown numericUpDown_raktarkeszlet;
        private System.Windows.Forms.Button button_muvelet;
    }
}