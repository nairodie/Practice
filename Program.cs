﻿using System.Collections;
using System.IO.Pipes;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using Practice;

public class Program
{
    private static void Main(string[] args)
    {
        //Duckbear();
        //VariableShop();
        //Kings();

        ParkingBillCalc billCalc = new ParkingBillCalc();
        Console.WriteLine(billCalc.Solution("10:00", "11:42"));


        // int number = 529;
        // int gap = BinaryGap(number);
        // Console.WriteLine($"Binary Gap of {number} is {gap}");

        // Console.WriteLine("Enter 5 space seperated integers");
        // string? line = Console.ReadLine();

        // if (string.IsNullOrEmpty(line))
        // {
        //     Console.WriteLine("No input");
        //     return;
        // }

        // string[] input = line.Split(' ');
        // if (input.Length != 5)
        // {
        //     Console.WriteLine("Please enter 5 integers only");
        //     return;
        // }
        // int[] arr = new int[5];
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     if (!int.TryParse(input[i], out arr[i]))
        //     {
        //         Console.WriteLine($"Invalid number: {input[i]}");
        //         return;
        //     }
        // }

        Console.WriteLine(ReverseString("hello"));

        Console.WriteLine(IsBalanced("({[]})")); //true
        Console.WriteLine(IsBalanced("([)]")); //false

    }

    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach(char c in input)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == '}' || c == '[')
            {
                if (stack.Count == 0)
                    return false;

                char topOfStack = stack.Pop(); //get the last - remember LIFO
                if (c == ')' && topOfStack != '(')
                    return false;
                if (c == '}' && topOfStack != '{')
                    return false;
                if (c == ']' && topOfStack != '[')
                    return false;
            }
        }        
        //if stack is empty, it's balanced
        return stack.Count == 0;
    }

    static string ReverseString(string input)
    {
        Stack<char> stack = new Stack<char>();

        //push all chars into stack
        //use for loop when you want control otherwise use foreach as its easier to read
        foreach(char c in input)
        {
            stack.Push(c);
            Console.WriteLine(c);
        }

        string reversed = "";
        while (stack.Count > 0)
        {
            reversed = reversed + stack.Pop();
        }
        return reversed;
    }

    private void Stacks()
    {
        //LIFO - think of a plates as they stack
        //constant time O(1) - very fast for all operations
        Stack<string> stackString = new Stack<string>();
        stackString.Push("A"); // push = add
        stackString.Push("B");
        stackString.Push("C");

        Console.WriteLine(stackString.Peek()); //peek returns object at the top of the stack without removing it.

        Console.WriteLine(stackString.Pop()); //pop = remove
        Console.WriteLine(stackString.Pop());

        Console.WriteLine($"String count is {stackString.Count}");

    }

    private static void DataStrucs()
    {
        //O(1) not resizing
        int[] numberArray = [1, 2, 3, 4, 5];
        Console.WriteLine(numberArray[0]);

        //Dynamic array (think of ArrayList but has Type Safety)
        List<string> nameString = new List<string>() {"Alice", "Bob"};
        nameString.Add("Charlie");
        nameString.Remove("Bob");

        //doubly linked list - fast insert/remove but slow search
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(10);
        list.AddFirst(5);

        //LIFO - Push, Pop Peek
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.Pop());

        //FIFO - Enqueue, Dequeue, Peek
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        Console.WriteLine(queue.Dequeue());

        //KVP(think Hashmap) - gold standard of generics
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs["Alice"] = 25;
        Console.WriteLine(keyValuePairs["Alice"]); //will print out 25 - Dictionary<Tkey, TValue>

    }

    public static void Texas(int[] arr)
    {
        //sum of all 5 numbers
        long totalSum = 0;
        //track the smallest number
        int min = arr[0];
        //track the largest number
        int max = arr[0];

        //loop through each number in array
        for (int i = 0; i < arr.Length; i++)
        {
            //adds current number to the total
            totalSum = totalSum + arr[i];

            //updates min if current number is smaller
            if (arr[i] < min)
            {
                min = arr[i];
            }
            //updates max if current number is larger
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
            //sum of 4 smallest numbers
            long minSum = totalSum - max;
            //sum of 4 largest numbers
            long maxSum = totalSum - min;

            Console.WriteLine(minSum + " " + maxSum);
    }

    static int BinaryGap(int N)
    {
        string binary = Convert.ToString(N, 2);
        Console.WriteLine($"Binary Representation of {N} is {binary}");

        int maxGap = 0;
        int currentGap = 0;
        bool counting = false;

        for (int i = 0; i < binary.Length; i++)
        {
            char bit = binary[i];
            Console.WriteLine($"Bit {i} : {bit}");

            if (bit == 1)
            {
                if (counting)
                {
                    Console.WriteLine($" Found closing '1' -> CurrentGap = {currentGap}");
                    if (currentGap > maxGap)
                    {
                        Console.WriteLine($"Updating maxGap: {maxGap} -> {currentGap}");
                        maxGap = currentGap;
                    }
                }
                counting = true;
                currentGap = 0;
            }
            else if (counting)
            {
                currentGap++;
                Console.WriteLine($"Counting Zeros -> currentGap = {currentGap}");
            }
        }
        return maxGap;
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
    }}