// multi cast delegates
using System;
namespace MultiCastDelegate4 {
    public delegate void fun(int x,int y);
class HelloDelegate {
    public static void GetArea(int x,int y) {
        Console.Write("Get Area: ");
        Console.WriteLine(x*y);
    }
  static void Main() {
    Console.WriteLine("x and y?");
    int  x = Convert.ToInt16(Console.ReadLine());
    int  y= Convert.ToInt16(Console.ReadLine());
    fun dobj = new fun(GetArea);
    dobj.Invoke(x,y);
  }
 }
}
