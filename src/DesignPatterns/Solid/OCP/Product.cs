using System;

namespace DesignPatterns
{
  public enum Color
  {
    Red,Green, Blue
  }

  public enum Size
  {
    Small, Medium, Large, Yuge
  }
  public class Product
  {
    public string Name;
    public Color Color;
    public Size Size;  

    public Product(string name, Color color, Size size)
    {
      if(name == null)
        throw new ArgumentNullException(paramName: nameof(name));
        
      Name = name;
      Color = color;
      Size = size;
    }
  }
}