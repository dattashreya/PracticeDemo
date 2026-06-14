// C# program to illustrate the ArrayList
using System;
using System.Collections;

class ArrayListDemo {

    // Main Method
    public static void Main(string[] args)
    {

        // Create a list of strings
        ArrayList al = new ArrayList();
        al.Add("Ajay");
        al.Add("Ankit");
        al.Add(10);
        al.Add(10.10);

        // Iterate list element using foreach loop
        foreach(var names in al)
        {
            Console.WriteLine(names);
        }
    }
}
