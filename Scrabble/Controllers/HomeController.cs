using Scrabble.Models;
using Microsoft.AspNetCore.Mvc;

namespace Scrabble.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public string Scrabble() { return "Your scrabble word will display here!"; }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/scrabble")]
    public ActionResult Scrabble(string word, int points)
    {
      ScrabbleVariables myScrabble = new ScrabbleVariables();
      myScrabble.Word = word;
      myScrabble.Points = points;
      return View(myScrabble);
    }
  }
}