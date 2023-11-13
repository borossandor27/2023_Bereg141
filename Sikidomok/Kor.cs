using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Kor : Sikidom, IAtmeretez, IRajzolas
    {
        double sugar;
        double atmero;

        public Kor(double sugar) : base("kör")
        {
            this.sugar = sugar;
            this.atmero = 2*sugar;
        }

        public double Sugar { get => sugar; }
        public double Atmero { get => atmero; }

        public override double Kerulet()
        {
            return 2 * sugar * Math.PI;
        }

        public void kisebb()
        {
            Console.WriteLine("kisebb");
        }

        public void nagyobb()
        {
            Console.WriteLine("Nagyobb");
        }

        public override double Terulet()
        {
            return sugar * sugar * Math.PI;
        }

        public void vonalvastagsag()
        {
            throw new NotImplementedException();
        }
    }
}
