using System;
class HelloWorld {
  static void Main() {
     long r= Fact(5);
     Console.Write("factorial :");
     Console.Write(r);
  }
  static long Fact(int n) {
      if(n <= 1)
      {
          return 1;
      }
      return n*Fact(n-1);
  }
}
