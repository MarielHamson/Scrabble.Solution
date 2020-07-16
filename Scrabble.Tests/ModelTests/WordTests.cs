using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void WordCheckerConstructor_ConstructAnInstanceOfAClass_Sparkle()
    {
      WordChecker testWordChecker = new WordChecker("Sparkle");
      Assert.AreEqual("Sparkle", testWordChecker.Input);
    }

  }
}