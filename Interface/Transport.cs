using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
   public  class Transport : IMovable
    {
        public   void Type()
        {
            Console.WriteLine("General transport");
        }      
    }
    public class electrictransport : Transport, IMovable
    {
        public new  void Type()
        {
            Console.WriteLine("Types of electrical trasnport are cars, buses, trains, trams");
        }
    }
}
