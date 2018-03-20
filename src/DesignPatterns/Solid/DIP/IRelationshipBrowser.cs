using System.Collections.Generic;

namespace DesignPatterns 
{
  public interface IRelationshipBrowser
  {
    IEnumerable<Person> FindAllChildrenOf(string name);
  }
}