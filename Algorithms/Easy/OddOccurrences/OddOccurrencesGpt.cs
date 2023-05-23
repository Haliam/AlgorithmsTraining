namespace Algorithms.Easy.OddOccurrences
{
    public static class OddOccurrencesGpt
    {
        public static int GetUnpairElement(int[] array)
        {
            if (!OddOccurrencesValidation.IsValid(array))
                return -1;

            int unpairElement = 0;

            foreach (int value in array)
            {
                unpairElement ^= value;
            }

            return unpairElement;
        }
    }
}
