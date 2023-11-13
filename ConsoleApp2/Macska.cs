using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Macska : Emlosok
    {
        public Macska(string nev, double suly, string nem) 
            : base(nev, "macska", 4, suly, nem, "miaúúú")
        {

        }

    }
}
