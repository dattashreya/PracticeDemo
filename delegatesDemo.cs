using System;
delegate void MDel(string message);
class HelloWorld {
    static void Print(string m)
    {
        Console.WriteLine(m);
    }
  static void Main() {
      MDel obj = Print;
      obj("Hello");
  }
}
