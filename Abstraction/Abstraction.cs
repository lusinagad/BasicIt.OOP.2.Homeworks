using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    abstract class Transport
    {      
        public  string Name { get; } 
        public Transport(string name)  
        {
            Name = name;
        }
        public abstract void Move();   // абстрактный метод
        public abstract int Speed { get; set; }  // абстрактное свойство
    }
    class Ship : Transport
    {
        public  Ship(string name) : base(name){} 
        public override void Move()
        {
            Console.WriteLine($"{Name}  is swim");
        }

        int speed;
        public override int Speed 
        {
            get => speed;
            set => speed = value;
            
        }
    }   
    class Aircraft : Transport 
    {
        public Aircraft(string name) : base(name) { }
        public override void Move()
        {
            Console.WriteLine($"{Name} is fly");
        }      
        public override int Speed
        {
            get; set;
        }
    }
   
    class Car : Transport
    {
        public Car(string name) : base(name) { }
        public override void Move()
        {
            Console.WriteLine($"{Name} car is move");
        }

        int speed;
        public override int Speed
        {
            get => speed;
            set => speed = value;
        }
    }
}
