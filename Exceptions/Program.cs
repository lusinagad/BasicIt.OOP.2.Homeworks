using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Square("12");
            Square("ab");   // System.Format exception
            void Square(string data)
            {
                if (int.TryParse(data, out var x))
                { Console.WriteLine($"kvadrat chisla {x} : {x * x}"); }
                else
                {
                    Console.WriteLine("Wrong input");
                }

                // ..........................................


            }
            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"result{y}");
            }
            catch
            {
                Console.WriteLine("exception DivideByZero");
            }

            finally
            {
                Console.WriteLine("finally block");
            }


            // ..........................................


            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"result{y}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("exception DivideByZero");
            }

            // ..........................................


            int x = 1;
            int y = 0;
            try
            {
                int result1 = x / y;
                int result2 = y / x;
            }
            catch (DivideByZeroException) when (y == 0)
            {
                Console.WriteLine("y is not equals to 0");
            }       
       
          }
        }
    }
}

