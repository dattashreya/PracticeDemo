class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 2, 9, 5 };
        
        // Find the highest number
        int highest = numbers.Max();
        
        Console.WriteLine($"Highest number: {highest}"); // Output: 9
    }
}
