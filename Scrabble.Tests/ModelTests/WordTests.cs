using Microsoft.VisualStudio.TestTools.UnitTesting;
using Word;
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
  }
}