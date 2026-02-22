using System;
struct MyStruct {
    int i;
    public void fun() {
        Console.WriteLine("funny struct: "+i);
    }
    static void Main() {
        MyStruct obj;
        obj.i = 10;
        obj.fun();   
    }  
}
