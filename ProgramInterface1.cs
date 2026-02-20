using System;
public class ProgramInterface1 {
    static void Main() 
    {
        IAnimal obj = new Dog();
        obj.bark();
        obj.run();
    }
}
