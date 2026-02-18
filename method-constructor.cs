using System;
class HelloWorld {
    public void myMethod(int a) {
        a+=2;
    }
   static void Main() {
       
       HelloWorld myClass = new HelloWorld();
       var a= 1;
      
      myClass.myMethod(a);
      Console.WriteLine(a);
  }
}