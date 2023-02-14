namespace Algorithms.Easy.CountZeros;

public class CountZerosV4
{
    public static int CalculateMaxZerosBetweenTwoOne(string number)
    {

        if (!IsValid(number))
            return 0;

        int maxZeros = 0;
        int countZeros = 0;
        int countOnes = 0;
        int n = 0;
        int[] array = new int[2];

        //010100011
        for (int i = n; i < number.Length; i++)
        {

            if (number[i] == '1')
                countOnes++;

            if (countOnes == 1 && number[i] != '0')
                array[0] = i;

            if (countOnes == 2)
            {
                array[1] = i;
                n = i - 1;
                countOnes = 0;
                countZeros = (array[1] - array[0]) - 1;
                maxZeros = countZeros;
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
        int countOnes = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] != '0' && number[i] != '1')
                return false;

            if (number[i] == '1')
                countOnes++;
        }

        if (countOnes == 0 ||
            countOnes == 1)
            return false;

        return true;
    }
}
