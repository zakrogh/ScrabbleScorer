using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScorerTest
  {
    [TestMethod]
    public void Scorer_IsWordStored()
    {
      Scorer myScorer = new Scorer("testword");
      Assert.AreEqual(myScorer.Word, "testword");
    }
    [TestMethod]
    public void Scorer_IsWordValid()
    {
      Scorer myScorer = new Scorer("testword");
      Assert.IsTrue(myScorer.IsWord());
    }
    [TestMethod]
    public void Scorer_IsScoreCorrect()
    {
      Scorer myScorer = new Scorer("testword");
      myScorer.CalculateScore();
      Assert.AreEqual(12, myScorer.Score);
    }
  }
}
