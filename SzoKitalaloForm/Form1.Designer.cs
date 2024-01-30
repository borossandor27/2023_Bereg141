namespace SzoKitalaloForm
{
    partial class Form_Jatek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Jatek));
            this.panel_Abc = new System.Windows.Forms.Panel();
            this.panel_KitalaltSzo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_Abc
            // 
            this.panel_Abc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Abc.Location = new System.Drawing.Point(0, 263);
            this.panel_Abc.Name = "panel_Abc";
            this.panel_Abc.Size = new System.Drawing.Size(850, 192);
            this.panel_Abc.TabIndex = 0;
            // 
            // panel_KitalaltSzo
            // 
            this.panel_KitalaltSzo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_KitalaltSzo.Location = new System.Drawing.Point(0, 0);
            this.panel_KitalaltSzo.Name = "panel_KitalaltSzo";
            this.panel_KitalaltSzo.Size = new System.Drawing.Size(850, 86);
            this.panel_KitalaltSzo.TabIndex = 1;
            // 
            // Form_Jatek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 455);
            this.Controls.Add(this.panel_KitalaltSzo);
            this.Controls.Add(this.panel_Abc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Jatek";
            this.Text = "Szókitaláló játék";
            this.Load += new System.EventHandler(this.Form_Jatek_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Abc;
        private System.Windows.Forms.Panel panel_KitalaltSzo;
    }
}

