using System;
class ArraySimple {
    static void Main() {
        // integer array
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("numbers");
        for(int i=0; i < numbers.Length ; i++) {
            Console.WriteLine(numbers[i]);
        }
    }
}
