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

    }
  }
}
