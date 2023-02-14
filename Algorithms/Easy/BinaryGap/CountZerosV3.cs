namespace Algorithms.Easy.CountZeros;

public class CountZerosV3
{
    public static int CalculateMaxZerosBetweenTwoOne(string number)
    {
        //00000101000111
        if (!IsValid(number))
            return 0;

        int maxZeros = 0;
        int countZeros = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '0' && i == 0)
            {
                continue;
            }

            if (number[i] == '1')
            {
                countZeros = 0;
            }
            else
            {
                countZeros++;
            }

            if (countZeros > maxZeros)
            {
                maxZeros = countZeros;
            }
        }

        return maxZeros;
    }

    private static bool IsValid(string number)
    {
        int countOne = 0;
        int countZero = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
                countOne++;

            if (number[i] == '0')
                countZero++;

            if (number[i] != '0' && number[i] != '1')
            {
                return false;
            }
        }

        if (countOne == 0 ||
            countOne == 1 ||
            countZero == 0)
            return false;

        return true;
    }
}
