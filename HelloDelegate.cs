using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HelloDelegate {
      public void AddNum(int a, int b) {
          Console.WriteLine(a+b);
      }
      public static string StringMeth(string s) {
          return "Shreya" + s;
      }
      static void Main() {
        HelloDelegate p = new HelloDelegate();
        p.AddNum(1,2);
        string str = HelloDelegate.StringMeth("Datta");
        Console.WriteLine(str);
  }
}


