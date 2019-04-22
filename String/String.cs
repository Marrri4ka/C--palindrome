using System;

namespace PalindromeCheck {

  class PallindromeChecker
  {
    private string Word; //Fiels

    public PallindromeChecker (string word) //constructor
    {
      Word = word;
    }
    public bool IsPalindrome()
    {
      for (int i=0; i<Word.Length; i++)
      {
        if (Word[i]!= Word [Word.Length -1 -i])
        {
        return false;
      }

      }
      return true;
    }
  }
}
