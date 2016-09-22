using System.Collections.Generic;
using Xunit;

namespace TestLibrary
{
  public class TestPet
  {
    [Fact]
    public void DogTalkToOwnerTest()
    {
      var dog = new Library.Models.Dog();

      Assert.Equal("Woof!", dog.TalkToOwner());
    }

    [Fact]
    public void CatTalkToOwnerTest()
    {
      var cat = new Library.Models.Cat();

      Assert.Equal("Meow!", cat.TalkToOwner());
    }
  }
}
