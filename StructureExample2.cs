using System;
class StructureExample2 {
    struct MyStruct {
        public void fun() {
            Console.WriteLine("funny struct");
        }
    }
    static void Main() {
        MyStruct obj;
        obj.fun();
  }
}
