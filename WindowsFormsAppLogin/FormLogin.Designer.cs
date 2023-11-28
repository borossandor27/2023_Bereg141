namespace WindowsFormsAppLogin
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Location = new System.Drawing.Point(20, 72);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(382, 31);
            this.textBox_nev.TabIndex = 1;
            this.textBox_nev.Text = "Lajos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jelszo";
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Location = new System.Drawing.Point(25, 182);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(377, 31);
            this.textBox_jelszo.TabIndex = 3;
            this.textBox_jelszo.Text = "1234";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(25, 263);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(377, 41);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Belépés";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 352);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_jelszo;
        private System.Windows.Forms.Button button_login;
    }
}

