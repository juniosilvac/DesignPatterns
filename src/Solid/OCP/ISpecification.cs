namespace DesignPatterns.Solid.OCP
{
  public interface ISpecification<T>
  {
    bool IsSatisfied(T t);
  }
}