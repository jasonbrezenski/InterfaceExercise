using System;

namespace InterfaceExercise;

public class Truck : ICompany, IVehicle
{
    //In each of your Car, Truck, and SUV classes

    /* DONE - Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    
    public bool HasLiftGate { get; set; }
    public bool HasTonneauCover { get; set; }

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public void Drive()
    {
        Console.WriteLine($"The {Color} {Year} {Make} {Model} is sitting at the airport in {OfficeLocation}. " 
                          + $"The company CEO Seth Bowman left it there after going on vacation to Europe.");
    }

    public string Logo { get; set; }
    public string OfficeLocation { get; set; }
}