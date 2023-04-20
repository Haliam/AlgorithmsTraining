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

//public class StreamFish
//{
//    public static List<Fish> HungryFish(int[] sizes, int[] directions)
//    {
//        var aliveFishes = new List<Fish>();

//        var downFishes = new Stack<Fish>();

//        Fish fish;

//        for (int i = 0; i < directions.Length; i++)
//        {
//            fish = new Fish(i, sizes[i], (StreamDirection)directions[i]);

//            if (fish.StreamDirection == StreamDirection.Down)
//                downFishes.Push(fish);
//            else
//                TryFishBattle(fish, ref downFishes, ref aliveFishes);
//        }

//        MergeAliveFishes(downFishes, ref aliveFishes);

//        return aliveFishes;
//    }

//    private static void TryFishBattle(Fish fish, ref Stack<Fish> downFishes, ref List<Fish> aliveFishes)
//    {
//        while (downFishes.Any())
//        {
//            if (downFishes.Peek().Weight > fish.Weight) return;

//            downFishes.Pop();
//        }

//        aliveFishes.Add(fish);
//    }

//    private static void MergeAliveFishes(Stack<Fish> downFishes, ref List<Fish> aliveFishes)
//    {
//        var fishes = downFishes.ToArray();

//        var length = fishes.Length;

//        for (int i = length - 1; i >= 0; i--)
//            aliveFishes.Add(fishes[i]);
//    }

//}
