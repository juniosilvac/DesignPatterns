using CreationalPatterns.Factories.Model;
using static System.Console;

namespace CreationalPatterns.Factories
{
    public class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            //var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            //drink.Consume();

            IHotDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}
