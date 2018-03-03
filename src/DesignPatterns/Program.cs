using System;
using System.Diagnostics;

namespace DesignPatterns
{
  class Program
  {
    static void Main(string[] args)
    {
      // Single Responsibility Principle
      var j = new Journal();
      j.AddEntry("I cried today");
      j.AddEntry("I ate a bug");
      // Console.WriteLine(j);

      var p = new Persistence();
      var filename = @"/path/Temp/journal.txt";
      p.SaveToFile(j, filename, true);
      // Process.Start(filename);

      // Open-Closed Principle
      var apple = new Product("Apple", Color.Green, Size.Small);
      var tree = new Product("Tree", Color.Green, Size.Large);
      var house = new Product("House", Color.Blue, Size.Large);

      Product[] products = {apple, tree, house};

      var pf = new ProductFilter();
      Console.WriteLine("Green products (old):");
      foreach(var pfColor in pf.FilterByColor(products, Color.Green))
      {
        Console.WriteLine($" - {pfColor.Name} is green");
      }

      var bf = new BetterFilter();
      Console.WriteLine("Green products (new):");
      foreach(var f in bf.Filter(products, new ColorSpecification(Color.Green)))
      {
        Console.WriteLine($" - {f.Name} is green");
      }

      Console.WriteLine("Large blue items:");
      foreach(var bl in bf.Filter(products, 
      new AndSpecification<Product>(
        new ColorSpecification(Color.Blue),
        new SizeSpecification(Size.Large)        
      )))
      {
        Console.WriteLine($" - {bl.Name} is big and blue");
      }
    }
  }
}
