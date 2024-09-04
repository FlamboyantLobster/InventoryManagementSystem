using System.IO;
class Database
{
    public void CheckStock()
    {
        string line;
        try
        {
            StreamReader sr = new StreamReader("E:/.NetProject/InventoryManagementSystem/InventoryManagementSystem/Stock.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }

    public void AddStock(string Stock)
    {
        try
        {
            StreamWriter sw = new StreamWriter("E:/.NetProject/InventoryManagementSystem/InventoryManagementSystem/Stock.txt", true);
            sw.WriteLine(Stock);
            sw.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
    }

    public Boolean CheckManagerCredentials(string email, string password)
    {
        string line;
        try
        {
            StreamReader sr = new StreamReader("E:/.NetProject/InventoryManagementSystem/InventoryManagementSystem/Managers.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                if (line == email + " " + password)
                {
                    return true;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            return false;
        }
    }

    public Boolean CheckCustomerCredentials(string email, string password)
    {
        string line;
        try
        {
            StreamReader sr = new StreamReader("E:/.NetProject/InventoryManagementSystem/InventoryManagementSystem/Customer.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                if (line == email + " " + password)
                {
                    return true;
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
            return false;
        }
    }

}
