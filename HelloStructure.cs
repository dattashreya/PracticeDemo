using System;
class HelloStructure {
    struct hello {
        public void fun() {
            Console.WriteLine("funny struct");
        }
    }
  static void Main() {
      hello obj = new hello();
      obj.fun();
  }
}
