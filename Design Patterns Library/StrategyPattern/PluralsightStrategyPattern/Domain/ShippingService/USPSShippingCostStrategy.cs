namespace StrategyPattern
{
    internal class USPSShippingCostStrategy : IShippingCostStrategy
    {
        public USPSShippingCostStrategy()
        {
        }

        public double Calculate(Order order)
        {
            return 3.00d;
        }
    }
}