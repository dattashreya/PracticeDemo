using System;
struct MyStructDemo2 {
    int i;
    public MyStructDemo2(int i) {
        this.i = i;
    }
    public void fun() {
        Console.WriteLine("funny struct: "+i);
    }
    static void Main() {
        MyStructDemo2 obj;
        obj.i = 10;
        obj.fun(); // i = 10 
        
        MyStructDemo2 obj1 = new MyStructDemo2();;
        obj1.fun(); // i = 0 
        
        MyStructDemo2 obj2 = new MyStructDemo2(12);
        obj2.fun(); // i = 12 
  }
}
