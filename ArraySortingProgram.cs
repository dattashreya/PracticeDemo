using System;
class ArraySortingProgram {
  static void Main() {
    int[] arr = {1,2,3,8,7,6,4,5};
    Console.WriteLine("Old Array: ");
    foreach(int i in arr) {
        Console.Write(i+" ");
    }
    Array.Sort(arr);
    Console.WriteLine("\nSorted Array: ");
    foreach(int i in arr) {
        Console.Write(i+" ");
    }
  }
}
