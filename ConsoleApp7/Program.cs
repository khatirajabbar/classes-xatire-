namespace ConsoleApp7;

class Program
{
    static void Main()
    {
        Vehicle product1 = new Vehicle(2025, "Porsche 911", "black", 345, 55, 
            120);
        // product1.GetInfo();
        Vehicle product2 = new Vehicle(2009);
        // product2.GetInfo();
        Vehicle product3 = new Vehicle(2003, "kia", "red" ,  345, 23, 5);
        product3.GetInfo();
    }
    


}