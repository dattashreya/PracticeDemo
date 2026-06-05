using System;
class HelloWorld {
    static int y=9;
      static void Main() 
      {
            Console.WriteLine("input?");
            
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("output: "+a);
            
            Console.WriteLine("y: "+HelloWorld.y);
      }
}
