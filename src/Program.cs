using System;
using Autofac;
using System.Diagnostics;
using System.Text;
using System.Collections.Generic;
using DesignPatterns.Solid.SRP;
using DesignPatterns.Solid.OCP;
using DesignPatterns.Solid.LSP;
//using DesignPatterns.Solid.DIP;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Factory;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using static System.Console;

namespace DesignPatterns
{
  class Program
  {
    //static int Area (Rectangle r) => r.Width * r.Height;
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

      #region Builder pattern     
      // var pb = new PersonBuilder();
      // Person person = pb
      // .Lives.At("Rua Rezende")
      //       .In("Parana")
      //       .WithPostcode("32232-430")
      // .Works.At("Fabrica")
      //       .AsA("Engenheiro")
      //       .Earning(120000);
      
      // WriteLine(person);
      #endregion

      #region Factory pattern
      // var machine = new HotDrinkMachine();
      //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea,100);
      // var drink = machine.MakeDrink();
      // drink.Consume();
      #endregion
     
      #region Prototype pattern
      // Foo foo = new Foo {Stuff = 42, Whatever = "abc"};
      // Foo foo2 = foo.DeepCopy(); // crashes without [Serializable]
      // Foo foo2 = foo.DeepCopyXml();
      // foo2.Whatever = "xyz";
      // WriteLine(foo);
      // WriteLine(foo2);
      #endregion

      #region Singleton pattern
      //var db = SingletonDatabase.Instance;
      // works just fine while you're working with a real database.
      //var city = "Tokyo";
      //WriteLine($"{city} has population {db.GetPopulation(city)}");
      #endregion

      #region Adapter pattern
      //var targets = new List<ITarget>();
      //targets.Add(new AdapterText());
      //foreach(var target in targets)
      //{
      //  target.Operation();
      //}
      #endregion

      #region Bridge pattern
      //var raster = new RasterRenderer();
      //var vector = new VectorRenderer();
      //var circle = new Circle(vector, 5, 5, 5);
      //circle.Draw();
      //circle.Resize(2);
      //circle.Draw();
      var cb = new ContainerBuilder();
      cb.RegisterType<VectorRenderer>().As<IRenderer>();
      cb.Register((c, p) => new Circle(c.Resolve<IRenderer>(),
        p.Positional<float>(0)));
      using (var c = cb.Build())
      {
        var circle = c.Resolve<Circle>(
          new PositionalParameter(0, 5.0f)
        );
        circle.Draw();
        circle.Resize(2);
        circle.Draw();
      }
      #endregion

    }
  }
}
