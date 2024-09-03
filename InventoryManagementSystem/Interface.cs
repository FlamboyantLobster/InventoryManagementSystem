class Interface()
{
    public void LoadInterface()
    {

        Console.WriteLine("************* Inventory Management System *************");
        Console.WriteLine("");
        Console.WriteLine("a) Customer Log In");
        Console.WriteLine("");
        Console.WriteLine("b) Manager Log in");
        Console.WriteLine("");
        Console.WriteLine("c) Exit");
        Console.WriteLine("");
        string response = Console.ReadLine();

        if (response == "A" | response == "a")
        {
            LoadCustomerLogIn();
        }
        else if (response == "B" | response == "b")
        {
            LoadManagerLogIn();
        }
        else if (response == "C" | response == "c")
        {
            System.Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Invalid option!");
            LoadInterface();
        }
    }

    public void LoadCustomerLogIn()
    {
        Console.WriteLine("************* Inventory Management System *************");
        Console.WriteLine("*************      Customer Portal        *************");
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
    }

    public void LoadManagerLogIn()
    {
        Console.WriteLine("************* Inventory Management System *************");
        Console.WriteLine("*************       Manager Portal        *************");
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
    }


}
