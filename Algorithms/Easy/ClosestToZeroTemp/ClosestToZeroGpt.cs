namespace Algorithms.Easy.ClosestToZeroTemp;

public class ClosestToZeroGpt
{
    public static int ComputeClosestToZero(int[] ts)
    {
        if (!ClosestToZeroValidation.IsValid(ts))
            return 0;

        int closestNum = int.MaxValue;

        foreach (int num in ts)
        {
            if (Math.Abs(num) < Math.Abs(closestNum) || (Math.Abs(num) == Math.Abs(closestNum) && num > closestNum))
            {
                closestNum = num;
            }
        }

        return closestNum;
    }
}
