namespace Algorithms.Easy.Fish
{
    public class FishesFight
    {
        public List<Fish> FishesAliveList { get; set; }

        public Stack<Fish> FishesStreamDown { get; set; }

        public FishesFight()
        {
            FishesAliveList = new List<Fish>();

            FishesStreamDown = new Stack<Fish>();
        }

        public List<Fish> CalculateLifeFishOnRiver(int[] sizes, int[] directions)
        {
            if (!ValidateInputs(sizes, directions))
            {
                return new List<Fish>();
            }

            for (int i = 0; i < sizes.Length; i++)
            {
                var fish = new Fish(i, sizes[i], (Direction)directions[i]);

                var currentFishSize = sizes[i];

                GetFishesStreamDown(fish);

                PutFishesToFight(currentFishSize);

                GetNonFightingFishes(fish);
            }

            GetTotalAliveFish();

            return FishesAliveList;
        }

        public bool ValidateInputs(int[] sizes, int[] directions) =>
            new FishFightValidation(sizes, directions).IsValid;

        private void GetFishesStreamDown(Fish fish)
        {
            if (fish.Direction == Direction.Down)
            {
                FishesStreamDown.Push(fish);
            }
        }

        private void PutFishesToFight(int currentFishSize)
        {
            if (FishesStreamDown.Count > 0 && currentFishSize > FishesStreamDown.Peek().Size)
            {
                FishesStreamDown.Pop();
            }
        }

        private void GetNonFightingFishes(Fish fish)
        {
            if (FishesStreamDown.Count == 0)
            {
                FishesAliveList.Add(fish);
            }
        }

        private void GetTotalAliveFish()
        {
            FishesAliveList.AddRange(FishesStreamDown);
        }
    }
}
