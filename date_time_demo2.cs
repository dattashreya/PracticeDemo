using System;
namespace HelloWorld {
    internal class HelloWorldP {
        void Accept() {
            var date = DateTime.Now;
            Console.Write("Date Time is: ");
            Console.Write(date);
            
            Console.Write("\nUtc is: ");
            var date1 = DateTime.UtcNow;
            Console.Write(date1);
            
            
            Console.Write("\nToday Date Time is: ");
            var date2 = DateTime.Today;
            Console.Write(date2);
        }
      static void Main(string[] args) {
        HelloWorldP o = new HelloWorldP();
        o.Accept();
      }
    }
}
