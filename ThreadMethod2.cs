using System;
using System.Threading;
class HelloWorld {
  static void Main() {
      Thread o = new Thread(ThreadMethod);
      o.Start();
      Thread o1 = new Thread(ThreadMethod2);
      o1.Start();
  }
  static void ThreadMethod()
  {
      Console.WriteLine("Hello World ThreadMethod");
  }

    static void ThreadMethod2()
  {
      Console.WriteLine("Hello World ThreadMethod 2");
  }
}
