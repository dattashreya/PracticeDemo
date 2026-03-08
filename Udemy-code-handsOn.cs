using System;
class Udemy-code-handsOn.cs {
  static void Main() {
      int a = 15;
        if((a > 10 )&&( a < 20) ){
            a = 20;
        }else if((a > 0 )&&( a < 200) ){
            a = 200;
        }else{
            a = 0;
        }
        Console.Write(a);
  }
}
