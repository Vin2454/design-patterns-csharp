using Factory.Models;

namespace Factory.Factory
{
    public interface ICardFactory
    {
        ICard GetCard(decimal annualSalary);
    }
}