namespace ConsoleApp7;

public class Vehicle
{
    public int Year;
    public string Model;
    public int FuelCapacity;
    public string Color;
    public int FuelFor1Km;
    public int CurrentFuel;

    public Vehicle(int year)
    {
        Year = year;
    }
    public Vehicle(int Year, string Model, string Color,int FuelCapacity, int FuelFor1Km, int CurrentFuel)
    {
        this.Model = Model;
        this.FuelCapacity = FuelCapacity;
        this.Color = Color;
        this.FuelFor1Km = FuelFor1Km;
        this.CurrentFuel = CurrentFuel;
        this.Year = Year;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Model: {this.Model}");
        Console.WriteLine($"Color: {this.Color}");
        Console.WriteLine($"Current Fuel: {this.CurrentFuel}");
        Console.WriteLine($"Year: {this.Year}");
        Console.WriteLine($"Fuel For 1 Km: {this.FuelFor1Km}");
        Console.WriteLine($"Fuel Capacity: {this.FuelCapacity}");
        
    }
}

