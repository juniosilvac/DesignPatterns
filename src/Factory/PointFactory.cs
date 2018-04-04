using System;
namespace DesignPatterns.Factory
{
  public static class PointFactory
  {
    // fatory method
    public static Point NewCartesianPoint(double x, double y)
    {
      return new Point(x, y);
    }
    public static Point NewPolarPoint(double rho, double theta)
    {
      return new Point(rho * Math.Cos(theta), rho*Math.Sin(theta));
    }
  }
}