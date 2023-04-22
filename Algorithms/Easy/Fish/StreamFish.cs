namespace Algorithms.Easy.Fish
{
    /// <summary>
    /// Marcel Solution
    /// </summary>
    public class StreamFish
    {
        public static List<Fish> HungryFish(int[] sizes, int[] directions)
        {
            var aliveFishes = new List<Fish>();

            var downFishes = new Stack<Fish>();

            Fish fish;

            for (int i = 0; i < directions.Length; i++)
            {
                fish = new Fish(i, sizes[i], (Direction)directions[i]);

                if (fish.Direction == Direction.Down)
                    downFishes.Push(fish);
                else
                    TryFishBattle(fish, ref downFishes, ref aliveFishes);
            }

            MergeAliveFishes(downFishes, ref aliveFishes);

            return aliveFishes;
        }

        private static void TryFishBattle(Fish fish, ref Stack<Fish> downFishes, ref List<Fish> aliveFishes)
        {
            while (downFishes.Any())
            {
                if (downFishes.Peek().Size > fish.Size) return;

                downFishes.Pop();
            }

            aliveFishes.Add(fish);
        }

        private static void MergeAliveFishes(Stack<Fish> downFishes, ref List<Fish> aliveFishes)
        {
            var fishes = downFishes.ToArray();

            var length = fishes.Length;

            for (int i = length - 1; i >= 0; i--)
                aliveFishes.Add(fishes[i]);
        }

    }
}
