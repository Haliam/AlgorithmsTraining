namespace Algorithms.Easy.BinaryGap
{
    public static class BinaryGap
    {
        public static int MaxZerosBetweenOnes(string binaryNumber)
        {
            if (!BinaryGapValidation.IsValid(binaryNumber))
                return 0;

            int countOne = 0;
            int countZeros = 0;
            int maxZeros = 0;
            int firstIndex = 0;
            int secondIndex = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == '1')
                {
                    countOne++;

                    if (countOne == 1)
                        firstIndex = i;

                    if (countOne == 2)
                    {
                        secondIndex = i;

                        countZeros = secondIndex - firstIndex - 1;

                        countOne = 1;

                        firstIndex = secondIndex;
                    }
                }

                maxZeros = countZeros > maxZeros? countZeros : maxZeros;
            }

            return maxZeros;
        }
    }
}
