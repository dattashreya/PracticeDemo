using System;
class GetSetProgram {
    public class Person {
        private string name;  // field
        public string Name    // property
        {
          get 
          { 
            return name; 
          }
          set 
          { 
            name = value; 
          }
        } 
    }
    static void Main(string[] args) 
    {
       Person myObj = new Person();
       Console.WriteLine("input? ");
       myObj.Name = Console.ReadLine();
       Console.WriteLine("my name is: "+myObj.Name);
    }
}

