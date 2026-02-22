using System;
class HelloRectangle {
  static void Main() {
      Console.WriteLine("Enter length? ");
      double len = Convert.ToInt16(Console.ReadLine());
      Console.WriteLine("Enter breadth? ");
      double bre = Convert.ToInt16(Console.ReadLine());
      Rectangle obj = new Rectangle(len, bre);
      Console.WriteLine("Area: "+obj.area());
  }
}
