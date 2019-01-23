using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("-------------------------------------------------------");
    
    Console.WriteLine("Let's check if one or both of your numbers are in range.");

    Console.WriteLine("-------------------------------------------------------");
    
    Console.WriteLine("Gimme Int: ");

    int first = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Gimme Int second: ");

    int second = Convert.ToInt32(Console.ReadLine());

    // Check if one of them is in range. If not, display that both arent in range
    if ((first < 11 && first > -11) || (second < 11 && second > -11))
    {
      // Check if both numbers are in range
      if ((first < 11 && first > -11) && (second < 11 && second > -11))
      {
        Console.WriteLine("Both numbers are in range!");
      }
      // First in range, second not in range
      if ((first < 11 && first > -11) && !(second < 11 && second > -11))
      {
        Console.WriteLine("First number is in range! The second is not.");
      }
      // First not in range, second in range
      if (!(first < 11 && first > -11) && (second < 11 && second > -11))
      {
        Console.WriteLine("Second number is in range! The first one is not.");
      }
    }
    else
    {
      // None of them are in range
      Console.WriteLine("Both numbers are not in range!");
    }
  }
}
