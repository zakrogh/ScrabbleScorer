using System;
using System.Collections.Models;

namespace ScrabbleScore.Models
{
  public class Scorer
  {
    public char[] AlphaChar { get; set; }
    public string Word { get; set; }
    public int Score { get; set; }
    public  Scorer (string word)
    {
      AlphaChar = word.ToCharArray();
      Word = word;
      Score = 0;
    }

    public Methods( string AlphaChar, string Word)
    {
        IsWord();
        CalculateScore();
    }

    private bool IsWord()
    {

      for(int i = 0; i < AlphaChar.Length; i++)
      {
        if(!Char.IsLetter(AlphaChar[i]))
        {
          return false;
        }
      }
      return true;
    }
    private int CalculateScore()
    {
      int[] scores = new int[7] {1, 2, 3, 4, 5, 8, 10};
      char[][] scoreGrid = new char[7][]
      {
        new char[]{'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'},
        new char[]{'d', 'g'},
        new char[]{'b', 'c', 'm', 'p'},
        new char[]{'f', 'h', 'v', 'w', 'y'},
        new char[]{'k'},
        new char[]{'j', 'x'},
        new char[]{'q', 'z'}
      };
      for(int i = 0; i < AlphaChar.Length; i++)
      {
        for(int j = 0; j < scoreGrid.Length; j++)
        {

        }
      }
    }
  }
}
