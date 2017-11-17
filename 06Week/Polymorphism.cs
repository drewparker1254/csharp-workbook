using System;


public class Program
{
	public static void Main()
	{
        Shape r = new Rectangle(34, 12); // Upcasting
        Shape t = new Triangle(12, 45, 67);

        ShowPerimeter(t);
        ShowPerimeter(r);


        Console.ReadLine();
	}

    public static void ShowPerimeter(Shape s)
    {
        Console.WriteLine(s.Perimeter());
    }
}

public abstract class Shape
{
    //Properties
    // Hieght
    public int Height { get; set; }
    // Width
    public int Width { get; set; }

    //Constructor
    public Shape(int h , int w)
    {
        Height = h;
        Width = w;
    }

    // Methods
    public abstract int Area();    

    public abstract int Perimeter();

    

}

public class Rectangle : Shape
{
    public Rectangle(int h, int w) : base(h, w)
    {

    }

    public  int Angles() => 4;

    public override int Area() => Height * Width;
   
    public override int Perimeter() => (Height + Width) * 2;

}

public class Triangle : Shape
    
{
    public int Diagonal { get; set; }
    
    public Triangle(int h, int w, int d) : base(h, w)
    {
        Diagonal = d;
    }

    public  int Angles() => 3;
   
    public override int Area()
    {
        
        // Heron's formula
        var s = Perimeter() / 2;
        
       var result = Math.Sqrt(s * (s - Height) * (s - Diagonal) * (s - Width));

       return Convert.ToInt32( Math.Floor(result));
        
    }

    public override int Perimeter() => Height + Diagonal + Width;
  
}