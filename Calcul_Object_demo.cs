using System;
namespace HelloWorld {
    internal class HelloWorldP {
        int a,b,c;
        void Accept() {
            Console.WriteLine("a?");
             a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b?");
             b=Convert.ToInt32(Console.ReadLine());
        }
        void Add() {
            c=a+b;
            Console.Write("Addition: ");
            Console.WriteLine(c);
        }
        void Sub() {
            c=a-b;
            Console.Write("Subt: ");
            Console.WriteLine(c);
        }
        void mul() {
            c=a*b;
            Console.Write("mult: ");
            Console.WriteLine(c);
        }
        void div() {
            c=a-b;
            Console.Write("div: ");
            Console.WriteLine(c);
        }
      static void Main(string[] args) {
        HelloWorldP obj = new HelloWorldP();
        obj.Accept();
        obj.Add();
        obj.Sub();
        obj.mul();
        obj.div();
      }
    }
}
