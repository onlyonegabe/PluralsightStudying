namespace StrategyPattern
{
    internal class UPSShippingCostStrategy : IShippingCostStrategy
    {
        public UPSShippingCostStrategy()
        {
        }

        public double Calculate(Order order)
        {
            return 4.25d;
        }
    }
}