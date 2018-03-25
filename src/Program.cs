using System;
using System.Diagnostics;
using System.Text;
using static System.Console;

namespace DesignPatterns
{
  class Program
  {
    static int Area (Rectangle r) => r.Width * r.Height;
    static void Main(string[] args)
    {      
      #region Single Responsibility Principle
      // var j = new Journal();
      // j.AddEntry("I cried today");
      // j.AddEntry("I ate a bug");
      // Console.WriteLine(j);

      // var p = new Persistence();
      // var filename = @"/path/Temp/journal.txt";
      // p.SaveToFile(j, filename, true);
      // Process.Start(filename);
      #endregion
     
      #region Open-Closed Principle
      // var apple = new Product("Apple", Color.Green, Size.Small);
      // var tree = new Product("Tree", Color.Green, Size.Large);
      // var house = new Product("House", Color.Blue, Size.Large);

      // Product[] products = {apple, tree, house};

      // var pf = new ProductFilter();
      // Console.WriteLine("Green products (old):");
      // foreach(var pfColor in pf.FilterByColor(products, Color.Green))
      // {
      //   Console.WriteLine($" - {pfColor.Name} is green");
      // }

      // var bf = new BetterFilter();
      // Console.WriteLine("Green products (new):");
      // foreach(var f in bf.Filter(products, new ColorSpecification(Color.Green)))
      // {
      //   Console.WriteLine($" - {f.Name} is green");
      // }

      // Console.WriteLine("Large blue items:");
      // foreach(var bl in bf.Filter(products, 
      // new AndSpecification<Product>(
      //   new ColorSpecification(Color.Blue),
      //   new SizeSpecification(Size.Large)        
      // )))
      // {
      //   Console.WriteLine($" - {bl.Name} is big and blue");
      // }
      #endregion
    
      #region Liskov Substitution Principle
      // var rc = new Rectangle(2, 3);
      // Console.WriteLine($"{rc} has area {Area(rc)}");

      // var sq = new Square();
      // sq.Width = 4;
      // Console.WriteLine($"{sq} has area {Area(sq)}");
      #endregion    
      
      #region Dependency Inversion Principle
      // var parent = new Person{Name = "John"};
      // var child1 = new Person{Name = "Chris"};
      // var child2 = new Person{Name = "Mary"};

      // var relationships = new Relationships();
      // relationships.AddParentAndChild(parent, child1);
      // relationships.AddParentAndChild(parent, child2);

      // new Research(relationships);
      #endregion

       // if you want to build a simple HTML paragraph using StringBuilder
      var hello = "hello";
      var sb = new StringBuilder();
      sb.Append("<p>");
      sb.Append(hello);
      sb.Append("</p>");
      WriteLine(sb);

      // now I want an HTML list with 2 words in it
      var words = new[] {"hello", "world"};
      sb.Clear();
      sb.Append("<ul>");
      foreach (var word in words)
      {
        sb.AppendFormat("<li>{0}</li>", word);
      }
      sb.Append("</ul>");
      WriteLine(sb);

      // ordinary non-fluent builder
      var builder = new HtmlBuilder("ul");
      builder.AddChild("li", "hello");
      builder.AddChild("li", "world");
      WriteLine(builder.ToString());

      // fluent builder
      sb.Clear();
      builder.Clear(); // disengage builder from the object it's building, then...
      builder.AddChildFluent("li", "hello").AddChildFluent("li", "world");
      WriteLine(builder);
    }
  }
}
