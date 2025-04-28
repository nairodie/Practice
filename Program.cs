using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;

public class Program
{
    private static void Main(string[] args)
    {
        //Duckbear();
        //VariableShop();
        //Kings();

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

    public static void Duckbear()
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

    public static void Kings()
    {
        string player1 = "Melik";
        string player2 = "Casik";
        string player3 = "Balik";

        // Estate, Duchy, and Province points
        int estatePoints = 1;
        int duchyPoints = 3;
        int provincePoints = 6;

        // Declare variables to store holdings for each player
        int player1Estate, player2Estate, player3Estate;
        int player1Duchy, player2Duchy, player3Duchy;
        int player1Province, player2Province, player3Province;

        // Get the number of holdings for each player
        Console.WriteLine($"{player1}, Enter your Estate holdings (worth {estatePoints} point each):");
        player1Estate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{player2}, Enter your Estate holdings (worth {estatePoints} point each):");
        player2Estate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{player3}, Enter your Estate holdings (worth {estatePoints} point each):");
        player3Estate = Convert.ToInt32(Console.ReadLine());

        // Get Duchy holdings
        Console.WriteLine($"{player1}, Enter your Duchy holdings (worth {duchyPoints} points each):");
        player1Duchy = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{player2}, Enter your Duchy holdings (worth {duchyPoints} points each):");
        player2Duchy = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{player3}, Enter your Duchy holdings (worth {duchyPoints} points each):");
        player3Duchy = Convert.ToInt32(Console.ReadLine());

        // Get Province holdings
        Console.WriteLine($"{player1}, Enter your Province holdings (worth {provincePoints} points each):");
        player1Province = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{player2}, Enter your Province holdings (worth {provincePoints} points each):");
        player2Province = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"{player3}, Enter your Province holdings (worth {provincePoints} points each):");
        player3Province = Convert.ToInt32(Console.ReadLine());

        // Calculate total points for each player
        int totalPoints1 = (player1Estate * estatePoints) + (player1Duchy * duchyPoints) + (player1Province * provincePoints);
        int totalPoints2 = (player2Estate * estatePoints) + (player2Duchy * duchyPoints) + (player2Province * provincePoints);
        int totalPoints3 = (player3Estate * estatePoints) + (player3Duchy * duchyPoints) + (player3Province * provincePoints);

        // Output the total points for each player
        Console.WriteLine($"{player1} has {totalPoints1} points.");
        Console.WriteLine($"{player2} has {totalPoints2} points.");
        Console.WriteLine($"{player3} has {totalPoints3} points.");

        //Winner
        int highestPoints = Math.Max(totalPoints1, Math.Max(totalPoints2, totalPoints3));
        if (highestPoints == totalPoints1)
        {
            Console.WriteLine($"{player1} Wins!");
        }
        else if (highestPoints == totalPoints2)
        {
            Console.WriteLine($"{player2} Wins!");
        }
        else
        {
            Console.WriteLine($"{player3} wins!");
        }
    }
}