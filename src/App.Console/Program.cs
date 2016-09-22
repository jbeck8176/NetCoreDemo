using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;

namespace App.ConsoleApp
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var petList = new List<IPet>(){
        new Dog(),
        new Cat()
      };

      foreach(var pet in petList)
      {
        Console.WriteLine(pet.TalkToOwner());
      }

      Console.ReadLine();
    }
  }
}
