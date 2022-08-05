using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a Zero and a Four, to start working on your transport");

            int numberOfWheels;

            var input = int.TryParse(Console.ReadLine(), out numberOfWheels);

            VehicleFactory.GetVehicle(numberOfWheels);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);
            
            vehicle.Build();


            Console.ReadLine();
            
            
            

        }
    }
}

