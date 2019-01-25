using System;

class MainClass {

  static void NumberChecker(int first, int second)
  {
    // Check if one of them is in range. If not, display that both are out of range.
    if ((first < 11 && first > -11) || (second < 11 && second > -11))
    {
      // Check if both numbers are in range
      if ((first < 11 && first > -11) && (second < 11 && second > -11))
      {
        Console.WriteLine("Both numbers are in range!");
      }
      // First in range, second not in range
      else if ((first < 11 && first > -11) && !(second < 11 && second > -11))
      {
        Console.WriteLine("First number is in range! The second is not.");
      }
      // First not in range, second in range
      else if (!(first < 11 && first > -11) && (second < 11 && second > -11))
      {
        Console.WriteLine("Second number is in range! The first one is not.");
      }
    }
    else
    {
      // None of the two numbers are in range.
      Console.WriteLine("Both numbers are not in range!");
    }
  }

  public static void Main (string[] args) {
    
    // Write instructions on screen and take first and second number
    Console.WriteLine("-------------------------------------------------------");
    
    Console.WriteLine("Let's check if one or both of your numbers are in range.");

    Console.WriteLine("-------------------------------------------------------");
    
    Console.WriteLine("Give me the first number: ");

    int first = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Give me the second number: ");

    int second = Convert.ToInt32(Console.ReadLine());

    // Call NumberChecker-method
    NumberChecker(first, second);
  }
}
