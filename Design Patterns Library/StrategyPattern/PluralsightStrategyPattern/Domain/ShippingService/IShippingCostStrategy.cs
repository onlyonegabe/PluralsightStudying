namespace StrategyPattern
{
    internal interface IShippingCostStrategy
    {
        double Calculate(Order order);
    }
}