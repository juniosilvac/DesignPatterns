using System;
using static System.Console;
namespace DesignPatterns.Creational.Adapter
{
  public class WriterText
  {
    public void OutPutText(string text) => WriteLine(text);
   
    public string OutPutTextUpper(string text) => text.ToUpper();
   
  }

  public interface ITarget
  {
    void Operation();
  }

  public class AdapterText : WriterText, ITarget
  {
    public void Operation()
    {
      var text = OutPutTextUpper("Operation performed.");
      OutPutText(text);
    }
  }
}