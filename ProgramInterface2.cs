using System;
public class ProgramInterface2 {
    static void Main() 
    {
        ITaxCalculator obj = new OrderProcessor();
        obj.order();
    }
}
