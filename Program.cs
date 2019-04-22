using System;
using System.Collections.Generic;

namespace PalindromeCheck {

  public class Words
  {
    public static void Main()
    {
      Console.WriteLine("Please enter your word");
      string userWord = Console.ReadLine();
      PallindromeChecker myWord = new PallindromeChecker(userWord);
      bool res = myWord.IsPalindrome();
      if (res == false)
      {
        Console.WriteLine ("Your word is not pallindrome");
      }
      if (res == true)
      {
        Console.WriteLine ("Your word is a pallindrome");
      }

    }
  }
}
