using Algorithms.Easy.BinaryGap;

namespace Algorithms.Easy.CountZeros;

public static class CountZerosGpt
{
    public static int MaxZerosBetweenOnes(string binaryNumber)
    {
        if (!BinaryNumberValidation.IsValid(binaryNumber))
            return 0;

        int maxZeros = 0;
        int currentZeros = 0;
        bool foundOne = false;

        foreach (char c in binaryNumber)
        {
            if (c == '1')
            {
                if (foundOne)
                {
                    // Found a second one, so update maxZeros if currentZeros is greater
                    if (currentZeros > maxZeros)
                    {
                        maxZeros = currentZeros;
                    }
                    currentZeros = 0;
                }
                else
                {
                    // Found the first one
                    foundOne = true;
                }
            }
            else
            {
                // Found a zero
                if (foundOne)
                {
                    currentZeros++;
                }
            }
        }

        return maxZeros;
    }
}
