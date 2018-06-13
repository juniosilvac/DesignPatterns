using System;
using CreationalPatterns.Builder.Model;
using static System.Console;

namespace  CreationalPatterns.Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var builder = new HtmlBuilder("ul");
           builder.AddChild("li", "hello");
           builder.AddChild("li", "word");
           WriteLine(builder.ToString());
        }
    }
}
