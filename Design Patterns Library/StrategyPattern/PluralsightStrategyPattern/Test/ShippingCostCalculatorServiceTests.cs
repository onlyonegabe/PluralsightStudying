using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StrategyPattern
{
    [TestClass]
    public class ShippingCostCalculatorServiceTests
    {
        [TestMethod]
        public void When_shipping_via_UPS_The_shipping_cost_is_425()
        {
            var strategy = new UPSShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = Mother.CreateOrder_UPS();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(4.25d, cost);
        }

        [TestMethod]
        public void When_shipping_via_USPS_The_shipping_cost_is_300()
        {
            var strategy = new USPSShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = Mother.CreateOrder_USPS();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(3.00d, cost);
        }

        [TestMethod]
        public void When_shipping_via_FedEx_The_shipping_cost_is_5()
        {
            var strategy = new FedExShippingCostStrategy();
            var shippingCalculatorService = new ShippingCostCalculatorService(strategy);
            var order = Mother.CreateOrder_FedEx();
            var cost = shippingCalculatorService.CalculateShippingCost(order);
            Assert.AreEqual(5.00d, cost);
        }
    }
}
