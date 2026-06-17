
using System;
class Person
{
    public int age=10;
}
class Employee : Person
{
    public int age=11;
    public void PrintAge()
    {
        int age = 12;
        Console.WriteLine(base.age);
        Console.WriteLine(age);
        Console.WriteLine(this.age);
    }
}
class HelloWorld {
  static void Main() {
    Employee o = new Employee();
    o.PrintAge();
  }
}
