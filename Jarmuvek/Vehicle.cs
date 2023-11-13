using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    // Absztrakt osztály a járművekhez
    public abstract class Vehicle
    {
        // Adattag a jármű típusának tárolásához
        protected string Type;

        // Konstruktor a jármű típusának beállításához
        protected Vehicle(string type)
        {
            Type = type;
        }

        // Absztrakt metódus az információ kiírásához
        public abstract void DisplayInfo();
    }
}
