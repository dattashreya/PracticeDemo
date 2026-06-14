using System;

class Geeks{
    static void Main(){
        // Declaration  
        int[][] jaggedArray = new int[3][];
      
      	// Initialization
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

      	// Iterating the elements
        for (int i = 0; i < jaggedArray.Length; i++) 
        {
            Console.Write("Row " + i + ": ");
            foreach(int num in jaggedArray[i])
                Console.Write(num + " ");
          
            Console.WriteLine();
        }
    }
}
