using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAlapok
{
    internal class Orszag
    {
        char[] forrasbolEltavolitandoKarakterek = new char[] { '\"', '\\',' ' };

        string orszagNev;
        double terulet;

        public Orszag(string line)
        {
            string[] sor = line.Split(';');
            orszagNev = sor[0].Trim().Replace("\"", string.Empty);
            Terulet = double.Parse(sor[1].Trim().Replace("\"",string.Empty).Replace('.',','));
        }

        public string OrszagNev { get => orszagNev; set => orszagNev = value; }
        public double Terulet { get => terulet; set => terulet = value; }
        public override string ToString()
        {
            return orszagNev;
        }
    }
}
