using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    // Motor osztály, amely implementál két interfészt
    public class Motorcycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motorcycle is starting.");
        }

        public void Stop()
        {
            Console.WriteLine("Motorcycle is stopping.");
        }

        public int Speed { get; set; }
    }

}
