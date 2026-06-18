using System;

class Square
{
    public int a, c;

    public Square(int x)
    {
        a = x;
    }

    public void Area(int x)
    {
        a = x;
        c = a * a;
        Console.WriteLine($"Area of Square = {c}");
    }
}

class Rectangle : Square
{
    public int b;

    public Rectangle(int x, int y) : base(x)
    {
        b = y;
    }

    public void Area(int x, int y)
    {
        a = x;
        b = y;
        c = a * b;
        Console.WriteLine($"Area of Rectangle = {c}");
    }
}

class Trigo : Rectangle
{
    public Trigo() : base(0, 0)
    {
    }

    public void trigo()
    {
        Console.WriteLine("trigo called");
    }
}

class HelloWorld
{
    static void Main()
    {
        Trigo t = new Trigo();
        t.trigo();

        Rectangle r = new Rectangle(11, 10);
        r.Area(11, 10);
    }
}
