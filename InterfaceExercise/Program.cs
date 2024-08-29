using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE - Create 2 Interfaces called IVehicle & ICompany

            //DONE - Create 3 classes called Car , Truck , & SUV
            
            //DONE - Now, create objects of your 3 classes and give their members values.
            //DONE - Creatively display and organize their values
            
            var carOne = new Car();
            carOne.Year = 2023;
            carOne.Make = "Porsche";
            carOne.Model = "911";
            carOne.Color = "red";
            carOne.OfficeLocation = "Omaha NE";
            carOne.Logo = "'Star & Moon'";
            carOne.HasTrunk = true;
            carOne.EngineInFront = true;
            
            carOne.Drive();
            Console.WriteLine();

            var truckOne = new Truck();
            truckOne.Year = 2015;
            truckOne.Make = "Ford";
            truckOne.Model = "F150";
            truckOne.Color = "blue";
            truckOne.OfficeLocation = "Nashville TN";
            
            truckOne.Drive();
            Console.WriteLine();
            
            var suvOne = new Suv();
            suvOne.Year = 2020;
            suvOne.Make = "Chevrolet";
            suvOne.Model = "Traverse";
            suvOne.Color = "Silver";
            suvOne.NumberOfSeats = 7;
            suvOne.HasCargoArea = true;
            suvOne.Logo = "Maple Trees";
            suvOne.OfficeLocation = "Fargo ND";

            Console.WriteLine("Type of Vehicle:");
            Console.WriteLine($"{suvOne.Year} {suvOne.Make} {suvOne.Model} {suvOne.Color}");
            suvOne.Drive();
            Console.WriteLine("---------------");



            // DID NOT DO - Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
