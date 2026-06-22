using System;
using System.Threading;
class HelloWorld {
  static void Main() {
      Thread o = new Thread(ThreadMethod);
      o.Start();
  }
  static void ThreadMethod()
  {
      Console.WriteLine("Hello World ThreadMethod");
  }
}
