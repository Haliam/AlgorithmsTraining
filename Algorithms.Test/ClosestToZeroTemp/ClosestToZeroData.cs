namespace Algorithms.Test.ClosestToZeroTemp;

public static class ClosestToZeroData
{
    public static IEnumerable<object[]> ClosestToZeroSuccess =>
    new List<object[]>
    {
        new object[]
        {
            new int[]{3, 7, 10, -1, -10, -4},
            -1
        },
        new object[]
        {
            new int[]{2, 7, 10, -3, -10, -4},
            2
        },
        new object[]
        {
            new int[]{2, 7, 10, -2, -10, -4},
            2
        }
    };

    public static IEnumerable<object[]> ClosestToZeroFail =>
    new List<object[]>
    {
        new object[]
        {
            new int[]{},
            0
        }
    };
}
