using Algorithms.Easy.SummerSales;

namespace Algorithms.Test
{
    public class SummerSalesTest 
    {
        [Theory]
        [MemberData(nameof(SummerSalesData.SummerSalesSuccess), MemberType = typeof(SummerSalesData))]
        public void SummerSalesSuccess(decimal[] prices, int discount, int expected) =>
            SummerSales.CalculateTotalPrice(prices, discount).Should().Be(expected);


        [Theory]
        [MemberData(nameof(SummerSalesData.SummerSalesFail), MemberType = typeof(SummerSalesData))]
        public void SummerSalesFail(decimal[] prices, int discount, int expected) =>
            SummerSales.CalculateTotalPrice(prices, discount).Should().Be(expected);
    }
}
