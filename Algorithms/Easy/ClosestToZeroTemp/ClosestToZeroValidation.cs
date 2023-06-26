namespace Algorithms.Easy.ClosestToZeroTemp;

public static class ClosestToZeroValidation
{
    public static bool IsValid(int[] ts)
    {
        if (ts.Length == 0)
            return false;

        if (ts.Length is not (>= 0 and <= 10000))
            return false;

        return true;
    }
}
