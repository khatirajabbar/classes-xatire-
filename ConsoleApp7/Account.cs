namespace ConsoleApp7;

public class Account
{
    public void Login(string username, string password)
    { 
        if (username == "lorem123" && password == "123456*")
            Console.WriteLine($"Login is successful for {username}!" );
        else 
            Console.WriteLine($"Login is failed for {username}. Wrong password or email address :(" );
    }
    
}