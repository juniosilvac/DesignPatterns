using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using MoreLinq;

namespace DesignPatterns.Creational.Singleton
{
  public interface IDatabase
  {
    int GetPopulation(string name);
  }

  public class SingletonDatabase : IDatabase
  {
    private Dictionary<string, int> capitals;
    private static int instanceCount;
    public static int Count => instanceCount;

    private SingletonDatabase()
    {
      WriteLine("Initializing database");

      capitals = File.ReadAllLines(
        Path.Combine(
          new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "capitals.txt")
        )
        .Batch(2)
        .ToDictionary(
          list => list.ElementAt(0).Trim(),
          list => int.Parse(list.ElementAt(1)));
    }

    public int GetPopulation(string name)
    {
      return capitals[name];
    }

    // laziness + thread safety
    private static Lazy<SingletonDatabase> instance = new Lazy<SingletonDatabase>(() =>
    {
      instanceCount++;
      return new SingletonDatabase();
    });

    public static IDatabase Instance => instance.Value;
  }
}