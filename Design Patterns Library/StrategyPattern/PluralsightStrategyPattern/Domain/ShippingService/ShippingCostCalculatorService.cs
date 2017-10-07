namespace StrategyPattern
{
    internal class ShippingCostCalculatorService
    {
        private readonly IShippingCostStrategy shippingCostStrategy;

        public ShippingCostCalculatorService(IShippingCostStrategy shippingCostStrategy)
        {
            this.shippingCostStrategy = shippingCostStrategy;
        }

        internal double CalculateShippingCost(Order order)
        {
            return this.shippingCostStrategy.Calculate(order);
        }
    }
}