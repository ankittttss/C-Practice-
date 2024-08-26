using System;

namespace MyApp
{
    // Base class
    public class Vehicle
    {
        public int No { get; set; }
        public int Mileage { get; set; }

        public int GetNo()
        {
            return No;
        }

        public int GetMileage()
        {
            return Mileage;
        }
    }

    // Derived class: Car
    public class Car : Vehicle
    {
        public string Type { get; set; }
        public string Company { get; set; }

        // Default constructor
        public Car()
        {
        }

        public string GetCompanyName()
        {
            return Company;
        }

        public string GetTypeOfCar()
        {
            return Type;
        }
    }

    // Derived class: Truck
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }

        // Default constructor
        public Truck()
        {
        }

        public int GetLoadCapacity()
        {
            return LoadCapacity;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the Car class
            Car myCar = new Car
            {
                No = 1234,
                Mileage = 25,
                Type = "Sedan",
                Company = "Toyota"
            };

            // Create an instance of the Truck class
            Truck myTruck = new Truck
            {
                No = 5678,
                Mileage = 15,
                LoadCapacity = 10000 // In kilograms
            };

            // Print Car details
            Console.WriteLine("Car Details:");
            Console.WriteLine("Company: " + myCar.GetCompanyName());
            Console.WriteLine("Type: " + myCar.GetTypeOfCar());
            Console.WriteLine("Number: " + myCar.GetNo());
            Console.WriteLine("Mileage: " + myCar.GetMileage() + " km/l");

            // Print Truck details
            Console.WriteLine("\nTruck Details:");
            Console.WriteLine("Number: " + myTruck.GetNo());
            Console.WriteLine("Mileage: " + myTruck.GetMileage() + " km/l");
            Console.WriteLine("Load Capacity: " + myTruck.GetLoadCapacity() + " kg");

            // Wait for user input before closing
            Console.ReadLine();
        }
    }
}
