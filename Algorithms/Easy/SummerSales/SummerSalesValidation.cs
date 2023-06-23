namespace Algorithms.Easy.SummerSales
{
    public static class SummerSalesValidation
    {
        public static bool IsValid(decimal[] prices, int discount)
        {
            if (prices.Length is not (> 0 and < 100))
                return false;

            if (discount is not (>= 0 and <= 100))
                return false;

            foreach (decimal price in prices)
            {
                if(price is not (> 0 and < 10000))
                    return false;
            }

            return true;
        }
    }
}
