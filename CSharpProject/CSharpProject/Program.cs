using System;

public class Program

{
	public static void Main()
	{
        Console.WriteLine("What's the first number?");

        int firstNumber;

        var didItParse = int.TryParse(Console.ReadLine(), out firstNumber);

        if (!didItParse)
        {
            firstNumber = 0;
        }

        Console.WriteLine("What's the second number?");

        int secondNumber;

        didItParse = int.TryParse(Console.ReadLine(), out secondNumber);

        if (!didItParse)
        {
            secondNumber = 0;
        }

        int result = firstNumber + secondNumber;

        Console.WriteLine("The result is: " + result);

        Console.ReadLine();

        //Console.WriteLine("How many yards?");

        //int numYards = int.Parse(Console.ReadLine());

        //int conversion = numYards * 36;

        //Console.WriteLine("there are" + " " + conversion + " " + "inches in a yard");

        //Console.ReadLine();

        //bool people = true;

        //decimal num = 2.5m;

        //decimal total = num * num;

        //Console.WriteLine(total);

        // Console.ReadLine();

    }


}
