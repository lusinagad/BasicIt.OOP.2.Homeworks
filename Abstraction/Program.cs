using System;

namespace abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship("Titanic");
            Aircraft aircraft = new Aircraft("Eagle");
            Car car = new Car("Bmw");
         
            ship.Move();
            aircraft.Move();
            car.Move();
         
            Console.WriteLine( ship.Speed = 125);
            Console.WriteLine (aircraft.Speed = 250) ;
            Console.WriteLine( car.Speed = 300);
          
        }
    }
}
