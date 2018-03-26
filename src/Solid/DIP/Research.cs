using System;
using System.Linq;

namespace DesignPatterns.Solid.DIP
{
  public class Research
  {
    // public Research(Relationships relationships)
    // {
    //   var relations = relationships.Relations;
    //   foreach(var r in relations.Where(
    //     x => x.Item1.Name == "John" &&
    //     x.Item2 == Relationship.Parent
    //   ))
    //   {
    //     Console.WriteLine($"John has a child called {r.Item3.Name}");
    //   }
    // }

    public Research(IRelationshipBrowser browser)
    {
      foreach(var p in browser.FindAllChildrenOf("John"))        
        Console.WriteLine($"John has a child called {p.Name}");
    }
  }
}