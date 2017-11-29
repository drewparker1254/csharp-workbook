using System;

public class Program
{
    public static void Main()
    { }
}

// Player class
public class Player
{
    // properties
    // define player 

    // methods 
    // determine player turn
}

// Board class
public class Board
{
    public static string[][] board = new string[][]
    {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
     };

    // methods 
    // draw and update board
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

// Game class
public class Game : Board
{
    //methods 
    // check if space is free
    // check for win conditions
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

    // check for tie
    //prompt player for move
}