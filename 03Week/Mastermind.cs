using System;

public class Program
{
    // possible letters in code
    public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
    
    // size of code
    public static int codeSize = 4;
    
    // number of allowed attempts to crack the code
    public static int allowedAttempts = 10;
    
    // number of tried guesses
    public static int numTry = 0;
    
    // test solution
    public static char[] solution = new char[] {'a', 'b', 'c', 'd'};
    
    // game board
    public static string[][] board = new string[allowedAttempts][];
    
    
    public static void Main()
    {
        CreateBoard();
        DrawBoard();
        char[] guess = new char[4];
        Console.WriteLine("Enter Guess:");
        guess = Console.ReadLine().ToCharArray();
        return;
    }
    
    public static bool CheckSolution(char[] guess)
    {

        //bring together into single string
        // Your code here

        // guess
        string guessString = String.Join("", guess);
        
        //solution
        string solutionString = String.Join(string.Empty, solution);

        if (guessString == solutionString)
        {

        }
        return false;
    }
    
    public static string GenerateHint(char[] guess)
    {
        // Your code here
        

        //clone solution
        char[]solutionClone = (char[]) solution.Clone();
    

        // Determine correct letter location
        int correctLetterLocations = 0;

        //iterate over solutionClone
        for (var i = 0; i < solutionClone.Length; i++);
        {
            //comapare soulutionClone against guess
            // for each index
            if(solutionClone[i] == guess[i])
            {
                correctLetterLocations++;
                solutionClone[i] = ' ';
            }
        }

        int correctLetters = 0;

        for (var i = 0; i < solutionClone.Length i++) ;
        {
            // check if any letter is inside solutionClone
            char character = guess[i];
            string clonedSolutionString = String.Join("", solutionClone);

           int index = clonedSolutionString.IndexOf(character);
            // what value index when there is no match
            //what value index gets when there is a match 

            //if you found the character 
                //increase correctLetter 
                // replace with ' ' the character from solutionClone -array

            //return hint
            //combo of the correctLetterLocation and correctLetter
            //hyphenated - 
        }
        return " ";
    }
    
    public static void InsertCode(char[] guess)
    {
        // Your code here
        return;
    }
    
    public static void CreateBoard()
    {
        for (var i = 0; i < allowedAttempts; i++)
        {
            board[i] = new string[codeSize + 1]; // string [5]
            for (var j = 0; j < codeSize + 1; j++)
            {
                board[i][j] = " ";
            }
        }
        return;
    }
    
    public static void DrawBoard()
    {
        for (var i = 0; i < board.Length; i++)
        {
            Console.WriteLine("|" + String.Join("|", board[i]));
        }
        
        return;
    }
    
    public static void GenerateRandomCode() {
        Random rnd = new Random();
        for(var i = 0; i < codeSize; i++)
        {
            solution[i] = letters[rnd.Next(0, letters.Length)];
        }
        return;
    }
}
