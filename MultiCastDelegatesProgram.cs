// multi cast delegates
// multi methods with same signatures
using System;
class MultiCastDelegatesProgram {
    public void GetArea(int x,int y) {
        Console.Write("Get Area: ");
        Console.WriteLine(x*y);
    }
    public void GetPerim(int x,int y) {
        Console.Write("Get Perimeters: ");
        Console.WriteLine(2*(x+y));
    }
  static void Main() {
    Console.WriteLine("x and y?");
    int  x = Convert.ToInt16(Console.ReadLine());
    int  y= Convert.ToInt16(Console.ReadLine());
    HelloDelegate obj = new HelloDelegate();
    obj.GetArea(x,y);
    obj.GetPerim(x,y);
  }
}
