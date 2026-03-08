using System;
class MethodOverloadingProgram3 {
    public void fun() {
        Console.WriteLine("Hello fun");
    }
    public void fun(int x) {
        Console.Write("Hello fun int: ");
        Console.Write(x);
    }
    public void fun(string n) {
        Console.WriteLine("\nHello fun string: "+n);
    }
  static void Main() {
    MethodOverloadingProgram3 o = new MethodOverloadingProgram3();
    o.fun();
    o.fun(4);
    o.fun("shreya");
  }
}
