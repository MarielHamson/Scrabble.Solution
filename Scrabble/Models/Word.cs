using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word.Models
{
  public class WordChecker
  {
    public string Input {get; set;}

    public WordChecker(string input)
    {
      Input = input;
    }

    public bool IsOnlyAlphaCharacters()
    {
      if (Regex.IsMatch(Input, "^[a-zA-Z]*$"))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
