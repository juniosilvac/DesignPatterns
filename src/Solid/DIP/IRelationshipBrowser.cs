using System.Collections.Generic;

namespace DesignPatterns.Solid.DIP
{
  public interface IRelationshipBrowser
  {
    IEnumerable<Person> FindAllChildrenOf(string name);
  }
}