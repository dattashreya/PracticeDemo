using System;
    class DelegateProgram2 {
        public void add(int x,int y) {
            Console.Write("Addition of Two numbs using delegate: "); 
            Console.Write(x+y);
        }
      static void Main() {
          DelegateProgram2 d = new DelegateProgram2();
          d.add(4,5);
        }
}
