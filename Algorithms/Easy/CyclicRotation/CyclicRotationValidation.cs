namespace Algorithms.Easy.CyclicRotation
{
    public static class CyclicRotationValidation
    {
        public static bool IsValid(int k, int[] array)
        {
            var n = array.Length;

            var nRange = new Range(0, 100);

            var kRange = new Range(0, 100);

            var arrayItemMinValue = -1000;

            var arrayItemMaxValue = 1000;


            if (n < nRange.Start.Value || n > nRange.End.Value)
                return false;

            if (k < kRange.Start.Value || k > kRange.End.Value)
                return false;

            if (array.Min() < arrayItemMinValue || array.Max() > arrayItemMaxValue)
                return false;

            return true;
        }
    }
}
