using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the Scrabble Scorer.");
      Console.WriteLine("Enter the word you want to have scored:");
      string word = Console.ReadLine();
      Scorer myScorer = new Scorer(word);
      if(myScorer.IsWord())
        myScorer.CalculateScore();
      else
        Console.WriteLine("That is not a valid word.");
      Console.WriteLine("Score: {0}", myScorer.Score);

    }
  }
}
