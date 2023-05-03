namespace Algorithms.Test.CyclicRotation
{
    public static class CyclicRotationData
    {
        public static IEnumerable<object[]> CyclicRotationSuccess =>
          new List<object[]>
          {
            new object[]
            {
                2,
                new int[]{ 3, 8, 9 },
                new int[]{ 8, 9, 3 }
            },
            new object[]
            {
                3,
                new int[]{ 3, 8, 9, 7, 6 },
                new int[]{ 9, 7, 6, 3, 8 }
            },
            new object[]
            {
                4,
                new int[]{ 1, 2, 3, 4 },
                new int[]{ 1, 2, 3, 4 }
            },
            new object[]
            {
                1,
                new int[]{ 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0 }
            },
            new object[]
            {
                1,
                new int[]{ 1, 0, 0, 1 },
                new int[]{ 1, 1, 0, 0 }
            }
          };

        public static IEnumerable<object[]> CyclicRotationFail =>
          new List<object[]>
          {
            new object[]
            {

            },
          };
    }
}
