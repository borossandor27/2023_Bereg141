using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppLogin
{
    internal class Termek
    {
        public int termekid;
        public string termeknev;
        public int ar;
        public int db;

        public Termek(int termekid, string termeknev, int ar, int db)
        {
            this.termekid = termekid;
            this.termeknev = termeknev;
            this.ar = ar;
            this.db = db;
        }
        public override string ToString()
        {
            return $"{termeknev} ({db} db)";
        }
    }
}
