using System;

public class Program
{
    public static void Main()
    {
        // Number 1 count numbers divisable by 3

        //    int count = 0;
        //    for (int i = 0
        //        ; i <= 100; i++)
        //    {
        //        if (i % 3 == 0)
        //        {
        //            count++;

        //        }


        //    }
        //    Console.WriteLine(count);
        //    Console.ReadLine();


        // Number 2 add to a running total
        //int runningTotal = 0;

        //bool keepGoing = true;

        //while (keepGoing)
        //{
        //    Console.WriteLine("Enter a number or type \"OK\" to exit");
        //    string entry = Console.ReadLine();

        //    if (entry == "OK")
        //    {
        //        keepGoing = false;
        //    }

        //    else
        //    {
        //        int number = int.Parse(entry);

        //        runningTotal = runningTotal + number;

        //        Console.WriteLine("Your total is " + runningTotal);
        //    }

        //    Console.ReadLine();
        //}

        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
        Console.ReadLine();
    }       
}