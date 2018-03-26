using System.IO;

namespace DesignPatterns.Solid.SRP
{ 
  // handles the responsibility of persisting objects
  public class Persistence
  {
    public void SaveToFile(Journal j, string filename, bool overwrite = false)
    {
      if(overwrite || !File.Exists(filename))
        File.WriteAllText(filename, j.ToString());
    }
  }
}