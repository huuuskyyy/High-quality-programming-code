using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Creature
{
  enum Gender { Male, Female };

  public class Human
  {
    public Gender gender { get; set; }
    public string name { get; set; }
    public int age { get; set; }
  }
  public void CreateHuman(int uniqueIdentifier)
  {
      Human human = new Human();
      human.age = uniqueIdentifier;
      if (uniqueIdentifier % 2 == 0)
      {
          human.name = "Batkata";
          human.gender = Gender.Male;
      }
      else
      {
          human.name = "Maceto";
          human.gender = Gender.Female;
      }
  }
}


