using System.IO.IsolatedStorage;

internal class Program
{
    private static void Main(string[] args)
    {
        Program p = new Program();
        p.Duckbear();

        var a  = "Stress";
        //Console.WriteLine(a[3]);

        foreach(char item in a)
        {
            if (item.ToString() == "s" || item.ToString() == "S")
            {
                Console.WriteLine(item);
            }
        }
    }

    public void Duckbear()
    {
        Console.WriteLine("How many eggs were gathered today?");
        string? input = Console.ReadLine();
        if (input != null && int.TryParse(input, out int totalEggs))
        {
              //sisters
            int numberOfSisters = 4;

            //how many eggs each sister gets and how many are leftover for the duckbear
            int sisterEggs = totalEggs / numberOfSisters;
            int duckbear = totalEggs % numberOfSisters;

            Console.WriteLine($"Each sister gets {sisterEggs} chocolate eggs.");
            Console.WriteLine($"The pet gets {duckbear} chocolate eggs as the remainder.");
        }
        else
        {
            Console.WriteLine($"Please enter a valid number");
        }
    }
}