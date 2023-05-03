namespace Algorithms.Easy.CyclicRotation
{
    public static class CyclicRotationArrayGpt
    {
        public static int[] GetRotatedArray(int K, int[] A )
        {
            int n = A.Length;

            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                int j = (i + K) % n;

                rotated[j] = A[i];
            }

            return rotated;
        }
    }
}
