namespace DesignPatterns
{
  public class OldFashionePrinter : IMachine
  {
    public void Fax(Document d)
    {
      //
    }

    public void Print(Document d)
    {
      throw new System.NotImplementedException();
    }

    public void Scan(Document d)
    {
      throw new System.NotImplementedException();
    }
  }
}