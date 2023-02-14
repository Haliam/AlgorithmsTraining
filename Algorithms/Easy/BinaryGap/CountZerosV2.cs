namespace Algorithms.Easy.CountZeros;

public class CountZerosV2
{
    public static int CalculateMaxZerosBetweenTwoOne(string number)
    {
        int numberOfZeros = 0;
        List<int> indexOfOneList = new List<int>();
        List<int> numberOfZerosList = new List<int>();

        if (!IsValid(number))
            return 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
            {
                indexOfOneList.Add(i);
            }
        }

        for (int i = indexOfOneList.Count - 1; i > 0; i--)
        {
            var j = i - 1;
            numberOfZeros = indexOfOneList[i] - indexOfOneList[j] - 1;
            numberOfZerosList.Add(numberOfZeros);
        }

        return numberOfZerosList.Max();
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
