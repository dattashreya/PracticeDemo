using System;
class HelloWorld {
  static void Main() {
      string s , rev = "";
      Console.WriteLine("input string? ");
      s = Console.ReadLine();
      for(int i = s.Length - 1 ; i>=0; i--) {
          rev += s[i].ToString();
      }
      
      if(rev == s)
        Console.WriteLine("palindrome");
      else
        Console.WriteLine("no");
  }
}
