namespace Algorithms.Test
{
    public static class SummerSalesData
    {
        public static IEnumerable<object[]> SummerSalesSuccess =>
        new List<object[]>
        {
            new object[]
            { 
                new decimal[] { 19.99m, 10m, 9.99m },
                50,
                29
            }
        };

        public static IEnumerable<object[]> SummerSalesFail =>
        new List<object[]>
        {
            new object[]
            {
                new decimal[] { },
                50,
                -1
            },
            new object[]
            {
                new decimal[] { 19.99m, 10m, 9.99m },
                -1,
                -1
            },
            new object[]
            {
                new decimal[] { 19.99m, 10m, 9.99m },
                120,
                -1
            },
            new object[]
            {
                new decimal[] { 100000, 10m, 9.99m },
                120,
                -1
            },
            new object[]
            {
                new decimal[] { 99999, -10, 9.99m },
                120,
                -1
            }
        };
    }
}
