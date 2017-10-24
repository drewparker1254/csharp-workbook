using System;

public class Program
{
    public static string playerTurn = "X";
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    public static void Main()
    {
        // Your code here
        int i = 0;
        do
        {
            DrawBoard();
            GetInput();
            i++;
            
                
        } while (i <= 9);

        // do while loop 
        Console.ReadLine();

    }


    public static void GetInput()
    {
        Console.WriteLine("Player " + playerTurn);
        Console.WriteLine("Enter Row:");
        int row = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter Column:");
        int column = Int32.Parse(Console.ReadLine());
        PlaceMark(row, column);

        
        CheckForWin(); // returns a bool- need to do something with this value

      
        playerTurn = (playerTurn == "X") ? "O" : "X";

        
        return;
    }

    public static void PlaceMark(int row, int column)
    {
        // Your code here
        if (playerTurn == "X")
        {
            

        }
        

        return;
    }

    public static bool CheckForWin()
    {
        
        
        bool hasPlayerWon = HorizontalWin() || VerticalWin() || DiagonalWin();

        if (hasPlayerWon)
        {
            Console.WriteLine("Player " + playerTurn + " Won!");
        }
       
        return hasPlayerWon;
    }

    public static bool HorizontalWin()
    {
        bool horizontalWin = false;

        if (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn)
        {
            horizontalWin = true;
        }

        if (board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn)
        {
            horizontalWin = true;
        }

        if (board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn)
        {
            horizontalWin = true;
        }
        return horizontalWin;
    }

    public static bool VerticalWin()
    {
        bool verticallWin = false;

        if (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn)
        {
            verticallWin = true;
        }

        if (board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn)
        {
            verticallWin = true;
        }

        if (board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn)
        {
            verticallWin = true;
        }
        return verticallWin;
    }

    public static bool DiagonalWin()
    {
        bool diagonalWin = false;

        if (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn)
        {
            diagonalWin = true;
        }

        if (board[2][0] == playerTurn && board[1][1] == playerTurn && board[0][2] == playerTurn)
        {
            diagonalWin = true;
        }
        return diagonalWin;
    }

    public static void DrawBoard()
    {
        Console.WriteLine("  0 1 2");
        Console.WriteLine("0 " + String.Join("|", board[0]));
        Console.WriteLine("  -----");
        Console.WriteLine("1 " + String.Join("|", board[1]));
        Console.WriteLine("  -----");
        Console.WriteLine("2 " + String.Join("|", board[2]));
        return;
    }
}
