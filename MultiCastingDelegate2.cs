// multi cast delegates
// multi methods with same signatures
using System;
namespace MultiCastingDelegate2 {
    public delegate void fun(int x,int y);
class HelloDelegate {
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

    fun dobj = new fun(obj.GetArea);
    dobj.Invoke(x,y);
    
    fun dobj1 = new fun(obj.GetPerim);
    dobj1.Invoke(x,y);
  }
 }
}
