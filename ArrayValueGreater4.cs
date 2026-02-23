using System;
class ArrayValueGreater4 {
  static void Main() {
      int[] arr = {1,2,3,4,5,6};
      int Count = 0;
      for(int i=0; i < arr.Length; i++) {
          if(arr[i] > 4) {
              Count += 1;
          }
      }
      int[] brr = new int[Count];
      int index=0;
      for(int i=0; i < arr.Length; i++) {
          if(arr[i] > 4) {
              brr[index] = arr[i];
              index += 1;
          }
      }
    Array.Sort(brr);
    Console.WriteLine("Values when > 4 ");
    foreach(int i in brr) {
        Console.Write(i+ " ");
    }
  }
}
