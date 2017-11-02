using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static Dictionary<string, List<int>> stacks = new Dictionary<string, List<int>>()
    {
        { "a", new List<int>() {4, 3, 2, 1} },
        { "b", new List<int>() {} },
        { "c", new List<int>() {} }
    };
    
    public static void Main()
    {

        // Loop thrugh methods using do {..} while()
        // think when loop will end 
        // think what methods go inside the code block

        do {
            PrintStacks();
            //ask for start input - Console.WriteLine("...")
            Console.WriteLine("Choose start pillar");
            //capture that input using Console.ReadLine()
           string start = Console.ReadLine();
            //ask for finish input  using Console.ReadLine()
            Console.WriteLine("Choose finish pillar");
           string finish = Console.ReadLine();

            //check if move legal

            // only make move if move was legal

        } while (!CheckForWin()); /// when this will stop
        Console.ReadLine();


    }
    
    public static bool CheckForWin()
    {
        // We need to count the elements on
        // pillar "c"

        if (stacks["c"].Count == 4)
            return true;

        return false;
    }
    
    public static void MovePiece(string start, string finish)
    {
        // Your code here

       

        stacks[start].Last();

        int lastElement = stacks[start].Last();

        stacks[finish].Add(lastElement);

        stacks[start].Remove(lastElement);
    }
    
    public static bool IsLegal(string start, string finish)
    {
        // check for empty pillar - finish(List)
        if (stacks[finish].Count == 0)
            return true;

        // check for existing values on both pillars
        int lastNumberFromStart = stacks[start].Last();
        int lastNumberFromFinish = stacks[finish].Last();

        if (lastNumberFromStart < lastNumberFromFinish)
            return true;



        return false;
    }
    
    public static void PrintStacks ()
    {
        string[] letters = new string[] {"a", "b", "c"};
        for( var i = 0; i < letters.Length; i++ )
        {
            List<string> blocks = new List<string>();
            for( var j = 0; j < stacks[letters[i]].Count; j++ )
            {
                blocks.Add(stacks[letters[i]][j].ToString());
            }
            Console.WriteLine(letters[i] + ": " + String.Join("|", blocks));	
        }
    }
}
