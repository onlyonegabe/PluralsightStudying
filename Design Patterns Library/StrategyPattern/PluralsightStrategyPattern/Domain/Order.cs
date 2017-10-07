namespace StrategyPattern
{
    internal partial class Order
    {
        public object ShippingMethod { get; internal set; }
        public object Destination { get; internal set; }
        public object Origin { get; internal set; }
    }
}