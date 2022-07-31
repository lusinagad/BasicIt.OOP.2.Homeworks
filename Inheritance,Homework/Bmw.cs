using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexamples
{
    public class Bmw : Car
    {

        public string engineType;
        public string transmission;
        public double Mileage;
        public string colors ;


        public void PrintEngineType()
        {
            Console.WriteLine($"Engine Type is: { engineType}");
        }
        public void PrintTransmission()
        {
            Console.WriteLine($"Transmission is {transmission}");
        }
        public void PrintMileage()
        {
            Console.WriteLine($"Fuel Efficiency / Mileage is: {Mileage} KM/L");
        }
        public void PrintColors()
        {
            Console.WriteLine($"Car series colors are: {colors}");
        }

       public class bmwSeries7 : Bmw
        {

        }

       public  class bmwContinental : Bmw
        {

        }
    }
}
