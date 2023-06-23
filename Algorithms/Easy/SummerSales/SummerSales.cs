namespace Algorithms.Easy.SummerSales
{
    public class SummerSales
    {
        public static int CalculateTotalPrice(decimal[] prices, int discount)
        {
            if (!SummerSalesValidation.IsValid(prices, discount))
                return -1;

            return GetTotalDiscountApplied(prices, discount);
        }

        private static int GetTotalDiscountApplied(decimal[] prices, int discount)
        {
            decimal totalPrice = GetTotalPrice(prices);

            decimal highestPrice = GetHighestPrice(prices);

            decimal discountedPrice = GetDiscountedPrice(highestPrice, discount);

            decimal totalDiscountApplied = totalPrice - highestPrice + discountedPrice;

            return (int)(totalDiscountApplied);
        }

        private static decimal GetHighestPrice(decimal[] prices)
        {
            decimal highestPrice = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                highestPrice = highestPrice > prices[i] ? highestPrice : prices[i];
            }

            return highestPrice;
        }

        private static decimal GetDiscountedPrice(decimal highestPrice, int discount)
        {
            decimal discountAmount = highestPrice * discount / 100;

            return highestPrice - discountAmount;
        }

        private static decimal GetTotalPrice(decimal[] prices)
        {
            decimal totalPrice = 0;

            foreach (decimal price in prices)
            {
                totalPrice += price;
            }

            return totalPrice;
        }
    }
}
