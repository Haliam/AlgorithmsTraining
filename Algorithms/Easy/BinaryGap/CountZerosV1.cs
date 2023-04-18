namespace Algorithms.Easy.CountZeros;

public static class CountZerosV1
{
    static int result = 0;

    public static int CalculateMaxZerosBetweenTwoOne(string number)
    {
        if (!IsValid(number))
            return 0;

        int[] array = CreateNewArray(number);

        int[] arrayFiled = FillArray(array, number);

        int[] arrayIndexOfOne = FillArrayIndexOfOne(arrayFiled);

        int maxNumberOfZeros = GetMaxZeros(arrayIndexOfOne);

        return maxNumberOfZeros;
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

    private static int[] CreateNewArray(string number)
    {
        int count = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
            {
                count++;
            }
        }

        int[] array = new int[count];

        return array;
    }

    private static int[] FillArray(int[] array, string number)
    {
        int count = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '1')
            {
                count++;
                array[count - 1] = i;
            }
        }

        return array;
    }

    private static int[] FillArrayIndexOfOne(int[] arrayFiled)
    {
        int length = arrayFiled.Length - 1;
        int[] aux = new int[length];
        int count = -1;

        for (int i = length; i > 0; i--)
        {
            count++;
            result = arrayFiled[i] - arrayFiled[i - 1];

            aux[count] = result;
        }

        return aux;
    }

    private static int GetMaxZeros(int[] arrayIndexOfOne)
    {
        var maxNumberOfZeros = arrayIndexOfOne[0];

        for (int i = 0; i < arrayIndexOfOne.Length; i++)
        {
            if (arrayIndexOfOne[i] > maxNumberOfZeros)
            {
                maxNumberOfZeros = arrayIndexOfOne[i];
            }
        }

         return maxNumberOfZeros - 1;
    }
}
