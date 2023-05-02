namespace Algorithms.Test.CyclicRotation
{
    public class CyclicRotationData
    {
        public static IEnumerable<object[]> CyclicRotationSuccess =>
          new List<object[]>
          {
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
