using System;
class ConstructorDemo {
    static int y; 
    int x;
    static  ConstructorDemo() {
        Console.WriteLine("static");
    }
    public ConstructorDemo() {
        Console.WriteLine("non / instance");
    }
  static void Main() {
    Console.ReadLine();
  }
}
