namespace Algorithms.Easy.CyclicRotation
{
    public static class CyclicRotationArray
    {
        public static int[] GetRotatedArray(int k, int[] array)
        {
            if (!CyclicRotationValidation.IsValid(k, array))
                return Array.Empty<int>();

            for (int i = 0; i < k; i++)
                array = Rotating(array);

            return array;
        }

        private static int[] Rotating(int[] array)
        {
            int[] firstArray = new int[2];

            int[] secondArray = new int[array.Length - 2];

            firstArray[0] = array[array.Length -1];

            firstArray[1] = array[0];

            for (int i = 0; i < secondArray.Length; i++)
                secondArray[i] = array[i + 1];

            return firstArray.Concat(secondArray).ToArray();
        }
    }
}
