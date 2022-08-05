using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
       public static IVehicle GetVehicle(int wheelCount)
        {
            switch (wheelCount)
            {
                case 0:
                    return new Boat();
                  
                case 4:
                    return new Car();

                default:
                    throw new ArgumentOutOfRangeException();
            }
                
            
        }
       
    }
}
