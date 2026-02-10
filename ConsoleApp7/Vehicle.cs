namespace ConsoleApp7;

public class Vehicle
{
    public int Year;
    public string Model;
    public int FuelCapacity;
    public string Color;
    public double FuelFor1Km;
    public double CurrentFuel;

    public Vehicle(int year)
    {
        this.Year = year;
    }
    public Vehicle(int year, string model, string color, int fuelCapacity, double fuelFor1Km, double currentFuel) : this(year)
    {
        this.Model = model;
        this.FuelCapacity = fuelCapacity;
        this.Color = color;
        this.FuelFor1Km = fuelFor1Km;
        this.CurrentFuel = currentFuel;
        this.Year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Model: {Model} | Year: {Year} | Color: {Color} | Fuel: {CurrentFuel}/{FuelCapacity}");
    }
    public void Drive(int km)
    {
        double neededFuel = km * FuelFor1Km;
        if (CurrentFuel >= neededFuel)
            {
            CurrentFuel -= neededFuel;
            Console.WriteLine($"{km} km yol gedildi. qalan yanacaq: {CurrentFuel} litr.");
            }
        else
        {
            Console.WriteLine($"bu yolu getmək üçün kifayət qədər yanacaq yoxdur. lazım olan: " +
                              $"{neededFuel} L, mövcud: {CurrentFuel} L.");
        }
    }
  
}

