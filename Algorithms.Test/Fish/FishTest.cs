namespace Algorithms.Test.Fish
{
    public class FishTest 
    {
        public FishFightStak FishFightStak { get; set; }

        public FishFightQueue FishFightQueue { get; set; }

        public FishTest()
        {
            FishFightStak = new FishFightStak();

            FishFightQueue = new FishFightQueue();
        }

        [Theory]
        [MemberData(nameof(FishData.HungryFishSuccess), MemberType = typeof(FishData))]
        public void HungryStackFishSuccess(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightStak.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.HungryFishFail), MemberType = typeof(FishData))]
        public void HungryStackFishFail(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightStak.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected); 
        }

        [Theory]
        [MemberData(nameof(FishData.HungryFishSuccess), MemberType = typeof(FishData))]
        public void HungryQueueFishSuccess(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightQueue.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.HungryFishFail), MemberType = typeof(FishData))]
        public void HungryQueueFishFail(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightQueue.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }
    }
}
