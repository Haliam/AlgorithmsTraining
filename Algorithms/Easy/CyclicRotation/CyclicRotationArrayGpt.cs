namespace Algorithms.Easy.CyclicRotation
{
    public static class CyclicRotationArrayGpt
    {
        public static int[] GetRotatedArray(int k, int[] array )
        {
            if (!CyclicRotationValidation.IsValid(k, array))
                return Array.Empty<int>();

            int n = array.Length;

            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                int j = (i + k) % n;

                rotated[j] = array[i];
            }

            return rotated;
        }
    }
}
