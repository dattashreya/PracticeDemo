using System;
class ConstructorDemo2 {
    // static Constructor is called is only once
    static  ConstructorDemo2() {
        Console.WriteLine("static");
    }
    // non-static Constructor is called is nth times if instantiated
    public ConstructorDemo2() {
        Console.WriteLine("non / instance");
    }
    static void Main() {
        ConstructorDemo2 obj1 = new ConstructorDemo2();
        ConstructorDemo2 obj2 = new ConstructorDemo2();
    }
}
