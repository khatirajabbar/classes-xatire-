namespace ConsoleApp7;

class Program
{
    static void Main()
    {
        Vehicle product1 = new Vehicle(2025, "Porsche 911", "black", 345, 55, 
            120);
        // product1.ShowInfo();
        Vehicle product2 = new Vehicle(2009);
        // product2.ShowInfo();
        Vehicle product3 = new Vehicle(2025, "Porsche 911", "black", 345, 55.5, 
            120.9);;
        product3.Drive(10); 
        product3.ShowInfo();
        product3.Drive(100);
        Account myAccount = new Account();
        Console.Write("Enter your username: ");
        string user = Console.ReadLine();
        Console.Write("Enter your password: ");
        string pass = Console.ReadLine();
        myAccount.Login(user, pass);

    }
}

    