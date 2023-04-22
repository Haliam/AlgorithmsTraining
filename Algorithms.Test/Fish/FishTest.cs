namespace Algorithms.Test
{
    public class FishTest 
    {
        public FishFight FishFight { get; set; }

        public FishFightStak FishFightStak { get; set; }

        public FishFightQueue FishFightQueue { get; set; }

        public FishTest()
        {
            FishFight = new FishFight();

            FishFightStak = new FishFightStak();

            FishFightQueue = new FishFightQueue();
        }

        [Theory]
        [MemberData(nameof(FishData.FishFightSuccess), MemberType = typeof(FishData))]
        public void FishFightSuccess(int[] arrayA, int[] arrayB, int expected)
        {
            FishFight.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.FishFightFail), MemberType = typeof(FishData))]
        public void FishFightFail(int[] arrayA, int[] arrayB, int expected)
        {
            FishFight.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.FishFightSuccess), MemberType = typeof(FishData))]
        public void FishFightStakSuccess(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightStak.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.FishFightFail), MemberType = typeof(FishData))]
        public void FishFightStakFail(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightStak.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected); 
        }

        [Theory]
        [MemberData(nameof(FishData.FishFightSuccess), MemberType = typeof(FishData))]
        public void FishFightQueueSuccess(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightQueue.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.FishFightFail), MemberType = typeof(FishData))]
        public void FishFightQueueFishFail(int[] arrayA, int[] arrayB, int expected)
        {
            FishFightQueue.CalculateLifeFishOnRiver(arrayA, arrayB).Should().Be(expected);
        }
    }
}
