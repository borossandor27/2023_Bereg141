using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmuvek
{
     class Program
    {
        static void Main()
        {
            // Autó példa
            Car myCar = new Car();
            myCar.Start();
            myCar.Speed = 60;
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine();

            // Motor példa
            Motorcycle myMotorcycle = new Motorcycle();
            myMotorcycle.Start();
            myMotorcycle.Speed = 80;
            Console.WriteLine($"Motorcycle speed: {myMotorcycle.Speed} km/h");
            myMotorcycle.Stop();
            Console.WriteLine("\nProgram vége!");
        }
    }

}
