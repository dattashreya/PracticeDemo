using System;
class HelloWorld {
    public void myMethod(out int r) {
        r=2;
    }
   static void Main() {
       HelloWorld myClass = new HelloWorld();
       int a;
		  myClass.myMethod(out a);
		  Console.WriteLine(a);
  }
}