using System;
class ForEachSimple {
    static void Main() {
        int[] arr = {1,5,7,6,2};
        Console.Write("ForEach loop\n");
        foreach(int i in arr) {
            Console.Write(i+ " ");
        }
    }
}
