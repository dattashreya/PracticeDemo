using System;
namespace AnonymousDelegateLamdaExpression {
    public delegate void Multiplic(int x,int y);
class HelloDelegate {
  static void Main() {
    Console.WriteLine("x and y?");
    int  x = Convert.ToInt16(Console.ReadLine());
    int  y= Convert.ToInt16(Console.ReadLine());
    Multiplic dobj = (x, y) => {
        Console.Write("Get Area: ");
        Console.WriteLine(x*y);
    };
    dobj.Invoke(x,y);
  }
 }
}
