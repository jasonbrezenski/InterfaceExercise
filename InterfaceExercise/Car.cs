using System;

namespace InterfaceExercise;

public class Car : ICompany, IVehicle
{
    //In each of your Car, Truck, and SUV classes

    /* DONE - Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    
    public bool HasTrunk { get; set; }
    public bool EngineInFront { get; set; }

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public void Drive()
    {
        Console.WriteLine($"The company car is a {Color} {Year} {Make} {Model} & the company logo {Logo} is on the hood. " 
                          + $"It is housed at our headquarters in {OfficeLocation}.");
    }

    public string Logo { get; set; }
    public string OfficeLocation { get; set; }
}