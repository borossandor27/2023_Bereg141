using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin
{
    public partial class Form_Termek : Form
    {
        string mod = null;
        public Form_Termek(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void Form_Termek_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.mod);

        }
    }
}
