namespace Algorithms.Easy.Fish
{
    public class FishStakSolution
    {
        public int CalculateLifeFishOnRiver(int[] A, int[] B)
        {
            int count = 0;

            bool imputsAreValid = new FishImputsValidation().ValidateImputs(A, B);

            if (!imputsAreValid)
            {
                return -1;
            }

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    stack.Push(A[i]);
                }

                if (stack.Count > 0 && A[i] > stack.Peek())
                {
                    stack.Pop();
                }

                if (stack.Count == 0)
                {
                    count++;
                }
            }

            var result = count + stack.Count;

            return result;
        }
    }
}
