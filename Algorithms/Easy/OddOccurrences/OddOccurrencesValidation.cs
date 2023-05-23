namespace Algorithms.Easy.OddOccurrences
{
    public static class OddOccurrencesValidation
    {
        public static bool IsValid(int[] array)
        {
            var n = array.Length;

            var nRange = new Range(1, 1000000);

            var arrayItemMinValue = 1;

            var arrayItemMaxValue = 1000000000;

            if (n % 2 == 0)
                return false;

            if (n < nRange.Start.Value || n > nRange.End.Value)
                return false;

            if (array.Min() < arrayItemMinValue || array.Max() > arrayItemMaxValue)
                return false;

            return true;
        }
    }
}
