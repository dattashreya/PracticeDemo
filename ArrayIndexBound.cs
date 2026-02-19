using System;
class ArrayIndexBound {
  static void Main() 
  {
      try
      {
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }    
  }
}

// Output: index was outside the bounds of an array