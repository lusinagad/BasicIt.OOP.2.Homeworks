using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPexamples
{
    public class Car
    {
        public string ManufacturerName;
        
        public int speed;
        public void PrintManufacturerName()
        {
            Console.WriteLine($"Car manufacturer Name is: {ManufacturerName} ");
        }
      
        public void PrintSpeed()
        {
            Console.WriteLine($"Speed is: {speed}");
        }

    }
}
