using System;
using System.Collections.Generic;

namespace CarConsole
{
    public class Car
    {
        public Car(string color, string licenseNumber, string make, int year)
        {
            Color = color;
            LicenseNumber = licenseNumber;
            Year = year;
            Make = make;
            CarEngine = new Engine();
            FuelTank = new FuelTank(50);

        }
            
        public string Make { get; set; }
        public int Year { get; set; }
        public string LicenseNumber { get; set; }
        public string Color { get; set; }
        public Engine CarEngine { get; set; }
        public FuelTank FuelTank { get; set; }
        
        public void Drive(int distance)
        {
            Console.WriteLine($"{distance} km driven.");
        }
      
    }
    
    
    public class Engine
    {
        public bool IsRunning { get; private set; }

        public void Start()
        {
            IsRunning = true;
            Console.WriteLine("Engine started.");
        }

        public void Stop()
        {
            IsRunning = false;
            Console.WriteLine("Engine stopped.");
        }
    }
    
    public class FuelTank
    {
        public double Capacity { get; set; }
        public double CurrentLevel { get; set; }

        public FuelTank(double capacity)
        {
            Capacity = capacity;
            CurrentLevel = 0; 
        }

        public void Fill(double amount)
        {
            if (CurrentLevel + amount <= Capacity)
            {
                CurrentLevel += amount;
                Console.WriteLine($"{amount} liters of fuel added.");
            }
            else
            {
                Console.WriteLine("Fuel tank is full.");
            }
        }
    }
}