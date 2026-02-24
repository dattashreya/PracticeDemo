// multi cast delegates
// anonymous method
using System;
namespace HelloDelegateAnonymous {
public delegate void fun(int x,int y);
class HelloDelegate {
  static void Main() {
    Console.WriteLine("x and y?");
    int  x = Convert.ToInt16(Console.ReadLine());
    int  y= Convert.ToInt16(Console.ReadLine());
   
    fun dobj = delegate (int x,int y) {
        Console.Write("Get Area: ");
        Console.WriteLine(x*y);
    };
    dobj.Invoke(x,y);
  }
 }
}
