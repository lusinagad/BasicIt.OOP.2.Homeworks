using System;

namespace OOPexamples
{
    class Program
    {

        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            bmw.ManufacturerName = "Bayerische Motoren Werke AG";
            bmw.PrintManufacturerName();

            Console.WriteLine("Bmw 7 series characteristics");

            Bmw.bmwSeries7 series7 = new Bmw.bmwSeries7();
            series7.speed = 250;
            series7.engineType = "TwinPower Turbo 6-cylinder Engine";
            series7.transmission = "N/A";
            series7.Mileage = 17.66;
            series7.colors = "11 available colors : dark blue, light blue, black, white, brown";
            series7.PrintSpeed();
            series7.PrintEngineType();
            series7.PrintTransmission();
            series7.PrintMileage();
            series7.PrintColors();

            Console.WriteLine("\n");
            Console.WriteLine("Bmw Continental characteristics");
            Bmw.bmwContinental bmwContinental = new Bmw.bmwContinental();
            bmwContinental.speed = 208;
            bmwContinental.engineType = "4.0 Litre Twin Turbo-charged V8 Engine";
            bmwContinental.transmission = "Dual Clutch";
            bmwContinental.Mileage = 10.62;
            bmwContinental.colors = "25 available colors : blue, white, black, green, dark yellow, purple, burgundy,papaya whip, tyrian purple ";
            bmwContinental.PrintSpeed();
            bmwContinental.PrintEngineType();
            bmwContinental.PrintTransmission();
            bmwContinental.PrintMileage();
            bmwContinental.PrintColors();

        }
       

    }
}       