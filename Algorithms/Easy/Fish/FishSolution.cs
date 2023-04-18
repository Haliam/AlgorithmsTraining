using System.IO;

namespace Algorithms.Easy.Fish
{
    public class FishSolution
    {
        public int CalculateLifeFishOnRiver(int[] A, int[] B)
        {
            int result = 0;

            bool imputsAreValid = new FishImputsValidation().ValidateImputs(A, B);

            if (!imputsAreValid)
            {
                return -1;
            }

            Stack<int> stream = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                var fish = A[i];

                if (B[i] == 1)
                {
                    stream.Push(fish);
                }

                if (stream.Count > 0 && fish > stream.Peek())
                {
                    stream.Pop();
                }

                if (stream.Count == 0)
                {
                    result++;
                }
            }

            return result + stream.Count;
        }
    }
}
