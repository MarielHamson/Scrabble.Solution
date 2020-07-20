using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Word.Models
{
  public class WordChecker
  {
    public string Input { get; set; }
    public int Points { get; set; }
    private static Dictionary<int, List<string>> scrabbleDic = new Dictionary<int, List<string>>()
    {
      { 1, new List<string> {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"} },
      { 2, new List<string> {"d", "g"} },
      { 3, new List<string> {"b", "c", "m", "p"} },
      { 4, new List<string> {"f", "h", "v", "w", "y"} },
      { 5, new List<string> {"k"} },
      { 8, new List<string> {"j", "x"} },
      { 10, new List<string> {"q", "z"} }
    };

    public WordChecker(string input)
    {
      Input = input;
      Points = 0;
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

    public int AddLettersOfWord()
    {
      // forEach(letter in word)
      {
        if (scrabbleDic[])
        {
          this.Points += 1;
        }
      }
    }
  }
}

