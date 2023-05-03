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
            },
            new object[]
            {
                0,
                new int[]{ 1, 0, 0, 1 },
                new int[]{ 1, 0, 0, 1 }
            },
            new object[]
            {
                1,
                new int[]{ 1000, 8, 9 },
                new int[]{ 9, 1000, 8}
            },
            new object[]
            {
                2,
                new int[]{ -1000, 8, 9 },
                new int[]{ 8, 9, -1000 }
            },
            new object[]
            {
                1,
                Enumerable.Range(0, 100).ToArray(),
                new int[]{99, 0}.Concat(Enumerable.Range(1,98)).ToArray(),
            }
          };

        public static IEnumerable<object[]> CyclicRotationFail =>
          new List<object[]>
          {
            new object[]
            {
                -1,
                new int[]{ 3, 8, 9 },
                new int[]{}
            },
            new object[]
            {
                101,
                new int[]{ 3, 8, 9 },
                new int[]{}
            },
            new object[]
            {
                1,
                new int[]{ -1001, 8, 9 },
                new int[]{}
            },
            new object[]
            {
                1,
                new int[]{ 1001, 8, 9 },
                new int[]{}
            },
            new object[]
            {
                1,
                Enumerable.Range(0, 101).ToArray(),
                new int[]{}
            }
          };
    }
}
