using System.Collections.Generic;
using System.Threading;
using System;

namespace Hangman.Models
{
  public class Word
  {
    private static List<Word> _words = new List<Word> { "tuberculosis", "bulbous", "hullabaloo", "mukluk", "gabardine", "galoshes", "gazebo", "spatula", "bouffant", "macadamia", "plutonium", "blubber", "balooga", "plethora", "bamboozle", "shindig", "ploy", "foible", "Eskimo", "bus"};

    public string Words { get; set; }
    public int Id { get ; }
    //private static List<Word> _instances = new List<Word> { };
    //for (int i= = 0; i < _words.Count; i++)
    //  Math.random(_words[i])

    public static List<Word> GetAll()
    {
      return _words;
    }
  }
}