using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns
{
  public class Relationships : IRelationshipBrowser
  {
    private List<(Person, Relationship,Person)> relations
    = new List<(Person, Relationship, Person)>();

    public void AddParentAndChild(Person parent, Person child)
    {
      relations.Add((parent,Relationship.Parent,child));
      relations.Add((parent,Relationship.Child,child));
    }

    public IEnumerable<Person> FindAllChildrenOf(string name)
    {
      foreach(var r in relations.Where(
        x => x.Item1.Name == name &&
             x.Item2 == Relationship.Parent
      ))
      {
        yield return r.Item3;
      }
    }
    // public List<(Person, Relationship,Person)> Relations => relations;
  }
}