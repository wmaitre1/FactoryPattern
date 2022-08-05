using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Boat : IVehicle
    {
        public void Build()
        {
            Console.WriteLine($"I am on the open sea");
        }
    }
}
