namespace Algorithms.Easy.BinaryGap
{
    public static class BinaryGapValidation
    {
        public static bool IsValid(string number)
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
                countOnes == 1 ||
                countOnes == number.Length)
                return false;

            return true;
        }
    }
}