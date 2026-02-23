using System;
class LINQProgram1 {
  static void Main() {
      Console.Write("Values of array\n");
      int[] arr = {1,2,3,7,5,6,4}; 
      foreach(int i in arr) {
          Console.Write(i+ " ");
      }
      var brr = from i in arr where i > 4 orderby i descending select i;
      Console.Write("\nValues of array > 4 \n");
      foreach(int x in brr) {
          Console.Write(x+ " ");
      }
  }
}
