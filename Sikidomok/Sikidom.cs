using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    abstract class Sikidom
    {
        public string tipus;

        protected Sikidom(string tipus)
        {
            this.tipus = tipus;
        }

        public abstract double Kerulet();
        public abstract double Terulet();
        public override string ToString()
        {
            return tipus;
        }
    }
}
