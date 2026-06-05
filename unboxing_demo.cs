using System;
class HelloWorld {
  static void Main() {
    int n=9000;
    object box = n;
    Console.WriteLine("boxing - value to object "+box);
    
    int unbox = (int)box;
    Console.WriteLine("unboxing - object to value "+ unbox);
  }
}
