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

}
