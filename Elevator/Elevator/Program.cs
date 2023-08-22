//Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Scenario
{


    static void Main(string[] args)
    {
        Console.WriteLine("Write the number of floors the building has");
        Console.WriteLine("Please enter only numbers");
        int number0fFloors = int.Parse(Console.ReadLine());
        Console.WriteLine("the number of options is: " + CountWays(number0fFloors));
        Console.WriteLine("press enter 2 times to exit");
        Console.ReadLine();
            Environment.Exit(0);
    }

    public static int CountWays(int A)
    {

        if (A <= 0)
        {
            return 0;
        }
        else if (A <= 2)
        {
            return A;
        }
        int[] optionList = new int[A + 1];
        optionList[2] = 2;
        for (int i = 3; i <= A; i++)
        {
            optionList[i] = optionList[i - 1] + optionList[i - 2];
        }
        return optionList[A];

    }

}
