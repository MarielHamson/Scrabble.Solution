using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Word.Tests
{
  [TestClass]
  public class WordCheckerTests
  {
    [TestMethod]
    public void WordCheckerConstructor_ConstructAnInstanceOfAClass_Sparkle()
    {
      WordChecker testWordChecker = new WordChecker("Sparkle");
      Assert.AreEqual("Sparkle", testWordChecker.Input);
    }

    [TestMethod]
    public void IsOnlyAlphaCharacters_ChecksIfInputIsStringOfAlphaChars_False()
    {
      WordChecker testWordChecker = new WordChecker("R2D2");
      Assert.AreEqual(false, testWordChecker.IsOnlyAlphaCharacters());
    }

    [TestMethod]
    public void WordToList_ChecksIfWordIsInstantiatedAsList_True()
    {
      WordChecker testWordChecker = new WordChecker("Sparkle");
      List<string> myList = new List<string>(testWordChecker.Input.Split(""));
      Console.WriteLine(testWordChecker.Input);
      CollectionAssert.AreEqual(myList.GetType(), typeof(List<string>));
    }

    [TestMethod]
    
    public void MakeDictionary_CreatesDictionaryWithKeyValuePairs_Dictionary()
    {
      Dictionary<Int, List<string>> scrabbleDic = new Dictionary<Int, List<string>>() {};
    }
  }
}
