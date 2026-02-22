using System;
public enum Days {
    Monday, Tuesday, Wednesday, Thursday, Friday
}
class ProgramBgColorDaySelect {
    static void Main() {
        Days d = (Days)3;
        Console.BackgroundColor = ConsoleColor.DarkGray;   
        Console.WriteLine(d);  // Thursday with DarkGray BackgroundColor
    }
}
