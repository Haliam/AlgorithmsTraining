namespace Algorithms.Easy.ClosestToZeroTemp;

public class ClosestToZero
{
    public static int ComputeClosestToZero(int[] ts)
    {
        if (!ClosestToZeroValidation.IsValid(ts))
            return 0;

        int temperature = GetClosestToZeroTemperature(ts);

        return temperature;
    }

    private static int GetClosestToZeroTemperature(int[] ts)
    {
        List<int> positiveTemperatures = new List<int>();

        List<int> negativeTemperatures = new List<int>();

        foreach (int t in ts)
        {
            if (t > 0)
            {
                positiveTemperatures.Add(t);
            }
            else
            {
                negativeTemperatures.Add(t);
            }
        }

        int minPositive = positiveTemperatures.Min();

        int maxNegative = negativeTemperatures.Max();

        if (minPositive == Math.Abs(maxNegative))
            return minPositive;

        int closestToZero = minPositive < Math.Abs(maxNegative) ? minPositive : maxNegative;

        return closestToZero;
    }       
}
