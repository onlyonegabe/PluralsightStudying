namespace StrategyPattern
{
    internal class Mother
    {
        internal static Order CreateOrder_UPS()
        {
            return new Order
            {
                ShippingMethod = Order.ShippingOptions.UPS,
                Destination = Mother.CreateAddress_Destination(),
                Origin = Mother.CreateAddress_Origin()
            };
        }

        internal static Order CreateOrder_USPS()
        {
            return new Order
            {
                ShippingMethod = Order.ShippingOptions.USPS,
                Destination = Mother.CreateAddress_Destination(),
                Origin = Mother.CreateAddress_Origin()
            };
        }

        internal static Order CreateOrder_FedEx()
        {
            return new Order
            {
                ShippingMethod = Order.ShippingOptions.FedEx,
                Destination = Mother.CreateAddress_Destination(),
                Origin = Mother.CreateAddress_Origin()
            };
        }

        private static object CreateAddress_Origin()
        {
            return new Address
            {
                ContactName = "David Starr",
                AddressLine1 = "Something"
            };
        }

        private static object CreateAddress_Destination()
        {
            return new Address
            {
                ContactName = "David Starr",
                AddressLine1 = "Something"
            };
        }
    }
}