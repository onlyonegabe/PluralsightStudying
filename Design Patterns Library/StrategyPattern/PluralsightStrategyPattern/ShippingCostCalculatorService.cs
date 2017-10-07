namespace StrategyPattern
{
    internal class ShippingCostCalculatorService
    {
        public ShippingCostCalculatorService()
        {
        }

        internal double CalculateShippingCost(Order order)
        {
            switch (order.ShippingMethod)
            {
                case Order.ShippingOptions.UPS:
                    return CalculateForUPS();

                case Order.ShippingOptions.USPS:
                    return CalculateForUSPS();

                case Order.ShippingOptions.FedEx:
                    return CalculateForFedEx();

                default:
                    throw new UnknownOrderShippingAddressException();
            }
        }

        private static double CalculateForFedEx()
        {
            return 5.00d;
        }

        private static double CalculateForUSPS()
        {
            return 3.00d;
        }

        private static double CalculateForUPS()
        {
            return 4.25d;
        }
    }
}