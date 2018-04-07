using System;
namespace DesignPatterns.Creational.Factory
{
  public class Point
  {
    private double x, y;

    public Point(double x, double y)
    {
      this.x = x;
      this.y = y;      
    }  
    public override string ToString() => $"{nameof(x)}: {x}, {nameof(y)}: {y}";   
  }  
}