using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Kutya : Emlosok
    {
        public Kutya(string nev, double suly, string nem) 
            : base(nev, "kutya", 4, suly, nem, "vaúúú-vaúúú")
        {
        }
    }
}
