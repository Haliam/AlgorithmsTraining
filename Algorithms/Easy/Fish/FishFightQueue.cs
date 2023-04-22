namespace Algorithms.Easy.Fish
{
    public class FishFightQueue
    {
        public int CalculateLifeFishOnRiver(int[] A, int[] B)
        {
            int count = 0;

            bool imputsAreValid = new FishInputsValidation().ValidateInputs(A, B);

            if (!imputsAreValid)
            {
                return -1;
            }

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    queue.Enqueue(A[i]);
                }

                if (queue.Count > 0 && queue.First() < A[i])
                {
                    queue.Dequeue();
                    queue.Enqueue(A[i]);
                }

                if (queue.Count == 0)
                {
                    count++;
                }
            }

            var result = count + queue.Count;

            return result;
        }
    }
}