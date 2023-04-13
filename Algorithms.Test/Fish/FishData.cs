namespace Algorithms.Test.Fish
{
    public class FishData
    {
        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 0, 1, 0, 0, 0 },
                2
            },
        };
    }
}
