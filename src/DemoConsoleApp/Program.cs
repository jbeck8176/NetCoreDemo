using System;
using System.Collections.Generic;
using Library.Models;

namespace DemoConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<IPet> pets = new List<IPet>()
      {
        new Dog(),
        new Cat()
      };

      foreach (var pet in pets)
      {
        Console.WriteLine(pet.TalkToOwner());
      }

      Console.ReadLine();
    }
  }
}
