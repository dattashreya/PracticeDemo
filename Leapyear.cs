using System;
class HelloWorld {
  static void Main() {
    Console.Write("year? ");
    int y = Convert.ToInt32(Console.ReadLine());
    if (y%400 == 0)
            Console.WriteLine("Leap year");
    else {
        if (y%4 == 0) {
            if(y%100 != 0) 
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("non - Leap year");
        }
        Console.WriteLine("non - Leap year");
    }
  }
}
