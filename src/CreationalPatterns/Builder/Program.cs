using CreationalPatterns.Builder.Model;
using static System.Console;

namespace CreationalPatterns.Builder
{
  public class Program
  {
      static void Main(string[] args)
      {
        // Example Builder
        //  var builder = new HtmlBuilder("ul");
        //  builder.AddChild("li", "hello");
        //  builder.AddChild("li", "word");
        //  WriteLine(builder.ToString());

          // Example Builder Fluent
          var pb = new PersonBuilder();
          Person person = pb
            .Lives
              .At("123 London Road")
              .In("London")
              .WithPostcode("SW12BC")
            .Works
              .At("Fabrikam")
              .AsA("Engineer")
              .Earning(123000);

          WriteLine(person);
      }
  }
}
