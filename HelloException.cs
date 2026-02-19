using System;
class HelloException {
  static void Main() {
      try {
          int x=1;
          int y=0;
          int z=x/y;
      }
      catch(Exception e) {
          Console.WriteLine($"{e.Message}");
      }
  }
}