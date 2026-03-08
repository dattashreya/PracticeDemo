using System;
class EvenOddCheck {
  static void Main() {
      int[] arr = {1,2,3,4,5,6};
      Console.Write("Array values:\n");
      foreach(int i in arr)
        Console.Write(i+" ");
      Console.Write("\nEven check in array: \n");
      for(int i=1; i<=arr.Length; i++) {
          if(i%2 ==0) {
              Console.WriteLine(i+" is even number");
          } else {
              Console.WriteLine(i+" is odd number");
          }
      }
  }
}
