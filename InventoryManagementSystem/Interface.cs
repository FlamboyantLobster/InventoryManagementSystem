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

        Database db = new Database();
        if (db.CheckCustomerCredentials(email, password) == true)
        {
            CustomerPortal();
        }
        else
        {
            Console.WriteLine("Incorrect Credentials!");
            LoadInterface();
        }
    }

    public void LoadManagerLogIn()
    {
        Console.WriteLine("************* Inventory Management System *************");
        Console.WriteLine("*************       Manager Portal        *************");
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        Database db = new Database();
        if (db.CheckManagerCredentials(email, password) == true)
        {
            ManagerPortal();
        }
        else
        {
            Console.WriteLine("Incorrect Credentials!");
            LoadInterface();
        }
    }

    // to do -------------------------------------------------------------------
    public void CustomerPortal()
    {
        Console.WriteLine("************* Inventory Management System *************");
        Console.WriteLine("*************      Customer Portal        *************");
        Console.WriteLine("");
        Console.WriteLine("a) Buy Items");
        Console.WriteLine("");
        Console.WriteLine("b) Return Items");
        Console.WriteLine("");
        Console.WriteLine("c) Exit");
        Console.WriteLine("");
        string response = Console.ReadLine();

        if (response == "A" | response == "a")
        {

        }
        else if (response == "B" | response == "b")
        {

        }
        else if (response == "C" | response == "c")
        {
            System.Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Invalid option!");
            CustomerPortal();
        }

    }

    // to do -------------------------------------------------------------------

    public void ManagerPortal()
    {
        Console.WriteLine("************* Inventory Management System *************");
        Console.WriteLine("*************       Manager Portal        *************");
        Console.WriteLine("");
        Console.WriteLine("a) Add Stock");
        Console.WriteLine("");
        Console.WriteLine("b) Add Items");
        Console.WriteLine("");
        Console.WriteLine("c) Remove Stock");
        Console.WriteLine("");
        Console.WriteLine("d) Remove Items");
        Console.WriteLine("");
        Console.WriteLine("e) Exit");
        Console.WriteLine("");
        string response = Console.ReadLine();

        if (response == "A" | response == "a")
        {

        }
        else if (response == "B" | response == "b")
        {

        }
        else if (response == "C" | response == "c")
        {

        }
        else if (response == "D" | response == "d")
        {

        }
        else if (response == "E" | response == "e")
        {
            System.Environment.Exit(1);
        }
        else
        {
            Console.WriteLine("Invalid option!");
            ManagerPortal();
        }

    }

    // to do --------------------------------------------------------------

    public void ManagerAddStock()
    {
        Console.WriteLine("************* Inventory Management System *************");
        Console.WriteLine("*************       Manager Portal        *************");
        Console.Write("Product Name: ");
        string email = Console.ReadLine();
        Console.Write("Amount: ");
        string password = Console.ReadLine();


    }
}
