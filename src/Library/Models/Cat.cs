﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
  public class Cat : IPet
  {
    public string TalkToOwner() => "Meow!";
  }
}
