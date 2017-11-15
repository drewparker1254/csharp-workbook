using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
        // Instance of Stack Class
        Stack myStack = new Stack();

        try
        {
            myStack.Push("drew");
            myStack.Push(112889);
            myStack.Push(DateTime.Now);
            myStack.Push(true);
            myStack.Push(null); // exception 
        }
        catch(InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
                       
        Console.WriteLine(myStack.Pop());
        Console.WriteLine(myStack.Pop());
        Console.WriteLine(myStack.Pop());
        Console.WriteLine(myStack.Pop());
        

       
        Console.ReadLine();


    }
}



public class Stack
{
    // Properties 
    List<object> lifo { get; set; }


    // Constructor

        public Stack()
        {
        lifo = new List<object>();
        }

    // Methods

    //push 
    public void Push(object obj)   
    {
        if (obj == null)
        {
            throw new InvalidOperationException("Whoa! don't add null to the list.");
        }

        lifo.Add(obj);
    }
    //pop
    public object Pop()
    {
        if(lifo.Count == 0)
        {
            throw new InvalidOperationException("The list is already empty!");
        }

        int indexOfLast = lifo.Count - 1;

        object cloned = lifo[indexOfLast];

        lifo.RemoveAt(indexOfLast);

        return cloned;
    }

    //clear
    public void Clear()
    {
        lifo.Clear();
    }
}