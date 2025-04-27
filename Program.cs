using System.IO.IsolatedStorage;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        VariableShop();

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

    public static void VariableShop()
    {
        // could use arraylist instead of List<obj>
        List<object> AllTypes =
        [
            "String!",
            1400000000,
            32,
            3.141592654f,
            3.1415M,
            2.718281828459,
            'A',
            true,
            123456789L,
            (short)16,
            (byte)255,
            (sbyte)-128,
            1234567890123456789UL,
            "This is an object!",
        ];
        
        Console.WriteLine($"This is all 14 different types inside of C#");
        
        foreach (var item in AllTypes)
        {
            Console.WriteLine(item);
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