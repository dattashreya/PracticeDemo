using System;
namespace Methods {
    class HelloWorld {
       static void Main(string[] args) {
           var obj = new Point(10,20);
           obj.Move(new Point(40,60));
           Console.WriteLine("point is at {0}, {1}",obj.x,obj.y);
           
           obj.Move(new Point(400,600));
           Console.WriteLine("point is at {0}, {1}",obj.x,obj.y);
      }
    }
}