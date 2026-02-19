using System;
class DivideByZeroExceptionProgram {
  static void Main() 
  {
        try
        {
            int numerator = 10;
            int denominator = 0;
            int result = numerator / denominator;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An unexpected error occurred: {e.Message}");
        }
        finally
        {
            Console.WriteLine("Execution of try-catch block finished.");
        }

  }
}

