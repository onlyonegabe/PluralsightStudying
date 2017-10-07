namespace StrategyPattern
{
    internal class FedExShippingCostStrategy : IShippingCostStrategy
    {
        public FedExShippingCostStrategy()
        {
        }

        public double Calculate(Order order)
        {
            return 5.00d;
        }
    }
}