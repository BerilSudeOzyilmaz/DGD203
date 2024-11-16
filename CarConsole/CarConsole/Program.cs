using System;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new Car( "Black", "34BRL34", "Audi", 2024);
            
            Console.WriteLine(theCar.Color);
            Console.WriteLine(theCar.LicenseNumber);
            Console.WriteLine(theCar.Make);
            Console.WriteLine(theCar.Year);
            
            theCar.FuelTank.Fill(20);
            theCar.CarEngine.Start();
            theCar.Drive(10);
            theCar.CarEngine.Stop();
            
            Console.ReadLine();
        }
    }
}