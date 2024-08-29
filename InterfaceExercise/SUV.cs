using System;

namespace InterfaceExercise;

public class Suv : ICompany, IVehicle
{
    //In each of your Car, Truck, and SUV classes

    /* DONE - Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * DONE - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */

    public int NumberOfSeats { get; set; }
    public bool HasCargoArea { get; set; }

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    public void Drive()
    {
        Console.WriteLine("The SUV is idling to cool off.");
    }

    public string Logo { get; set; }
    public string OfficeLocation { get; set; }
}