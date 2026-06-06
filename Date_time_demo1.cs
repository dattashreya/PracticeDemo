using System;
namespace HelloWorld {
    internal class HelloWorldP {
        void Accept() {
            var date = DateTime.Now;
            Console.Write("Date Time is: ");
            Console.Write(date);
        }
      static void Main(string[] args) {
        HelloWorldP o = new HelloWorldP();
        o.Accept();
      }
    }
}
