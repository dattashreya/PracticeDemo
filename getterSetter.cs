using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      var myObj = new Person();
      Console.Write("name string: ");
      myObj.Name = Console.ReadLine();
      
      Console.Write("id: ");
      myObj.ID = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Name "+myObj.Name);
      Console.Write("ID: ");
      Console.Write(myObj.ID);
    }
  }
}


Person.cs
using System;
namespace MyApplication
{
  class Person
  {
    private string _name;  // field
    public string Name    // property
    {
      get { return _name; }
      set { _name = value; }
    }  
    
    private int _id;
    public int ID 
    {
        get { return _id ;}
        set { _id = value ;}
    }
  }
}
