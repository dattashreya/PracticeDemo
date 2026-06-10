using System;
class HelloWorld {
  static void Main() {
    Console.Write("numb? ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (y%2 == 0)
            Console.WriteLine("ev");
    else {
        Console.WriteLine("odd");
    }
  }
}
