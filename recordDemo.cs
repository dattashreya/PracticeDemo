public record Person(string Name, int Age);

Person p1 = new Person("Alice", 30);
Person p2 = new Person("Alice", 30);

Console.WriteLine(p1 == p2); // Output: True
