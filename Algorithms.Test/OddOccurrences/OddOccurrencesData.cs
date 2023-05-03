namespace Algorithms.Test
{
    public static class OddOccurrencesData
    {
        public static IEnumerable<object[]> OddOccurrencesSuccess =>
        new List<object[]>
        {
            new object[]
            {
                new int[] { 4, 3, 2, 1, 5 },
                new int[] { 0, 1, 0, 0, 0 },
            },
            new object[]
            {
                new int[] { 11, 4, 3, 2, 1, 5, 6, 7, 8, 10},
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 1, 0},
            }
        };

        public static IEnumerable<object[]> OddOccurrencesFail =>
        new List<object[]>
        {
            new object[]
            {
                new int[] { 11, 4, 3, 2, 1, 5, 6, 7, 8, 10},
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1},
            }
        };
    }
}
