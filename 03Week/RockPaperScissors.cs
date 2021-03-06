using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter hand 1:");
        string hand1 = Console.ReadLine().ToLower();
        Console.WriteLine("Enter hand 2:");
        string hand2 = Console.ReadLine().ToLower();
        Console.WriteLine(CompareHands(hand1, hand2));

        CompareHands(hand1, hand2);

        Console.ReadLine();
    }
    
    public static string CompareHands(string hand1, string hand2)
    {
        //check for tie
        if (hand1 == hand2)
        {
            return "It's a tie";
        }

        if(hand1 == "rock")
        {
            if(hand2 == "paper")
            {
                return "Hand2 Won!";

            }

            return "Hand1 Won1";

        }

        if (hand1 == "paper")
        {
            if(hand2 == "scissors")
            {
                return "Hand2 Won!";
            }

            return "Hand1 Won!";
        }

        if (hand1 == "scissors")
        {
            if (hand2 == "rock")
            {
                return "Hand2 Won!";
            }

            return "Hand1 Won!";
        }

        // Your code here
        return $"{hand1} played against {hand2}";
    }
}
