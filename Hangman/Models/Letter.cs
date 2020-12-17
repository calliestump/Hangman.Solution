using System.Collections.Generic;
using System.Threading;
using System;

namespace Hangman.Models
{
  public class Letter
  {
    public string UsersLetter { get; set; }
    public int Id { get ; }
    private static List<Letter> _instances = new List<Letter> { };

    public Letter(string usersLetter)
    {
      UsersLetter = usersLetter;
      _instances.Add(this);
      Id = _instances.Count;
    }
  }

}