using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
    // Autó osztály, amely örökli az absztrakt osztályt és implementál egy interfészt
    public class Car : Vehicle, IVehicle
    {
        public Car() : base("Car") { }

        public void Start()
        {
            Console.WriteLine($"{Type} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} is stopping.");
        }

        public int Speed { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Type: {Type}, Speed: {Speed} km/h");
        }
    }

}
