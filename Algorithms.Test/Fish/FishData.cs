namespace Algorithms.Test.Fish
{
    public class FishData
    {
        public static IEnumerable<object[]> DataToSuccess =>
        new List<object[]>
        {
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 0, 1, 0, 0, 0 },
                2
            },
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 1, 0, 1, 0, 1 },
                3
            },
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 0, 0, 1, 0, 1 },
                4
            },
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 0, 0, 0, 0, 0 },
                5
            },
        };

        public static IEnumerable<object[]> DataToFail =>
        new List<object[]>
        {
           new object[]
           {
               new int[]{ 5, -3, 2, 7, 0},
               new int[]{ 0, 1, 0, 0, 0 },
               -1
           },
           new object[]
           {
               new int[]{},
               new int[]{ 0, 1, 0, 0, 0 },
               -1
           },
           new object[]
           {
               new int[]{ 1 },
               new int[]{ 0, 1, 0, 0, 0 },
               -1
           },
        };     
    }
}
