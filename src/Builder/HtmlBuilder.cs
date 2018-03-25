using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DesignPatterns
{
  public class HtmlBuilder
  {
    private readonly string RootName;
    HtmlElement root = new HtmlElement();

    public HtmlBuilder(string rootName)
    {
      RootName = rootName;
      root.Name = rootName;
    }
    
    // not fluent
    public void AddChild(string childName, string childText)
    {
      var e = new HtmlElement(childName, childText);
      root.Elements.Add(e);
    }

    public HtmlBuilder AddChildFluent(string childName, string childText)
    {
      var e = new HtmlElement(childName, childText);
      root.Elements.Add(e);
      return this;
    }

    public override string ToString()
    {
      return root.ToString();
    }

    public void Clear()
    {
      root = new HtmlElement{Name = RootName};
    }
  }    
}