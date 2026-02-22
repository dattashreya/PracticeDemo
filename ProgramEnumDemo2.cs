using System;
public enum Days {
    Monday, Tuesday, Wednesday
}
class ProgramEnumDemo2 {
    static void Main() {
        Days d = (Days)0;
        Console.WriteLine(d);
        
        Days e = (Days)1;
        Console.WriteLine(e);
        
        Days f = (Days)2;
        Console.WriteLine(f);
    }
}
