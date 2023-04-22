namespace Algorithms.Test
{
    public class FishTest 
    {
        public FishesFight FishesFight { get; set; }

        public FishesFightStak FishesFightStak { get; set; }

        public FishesFightQueue FishesFightQueue { get; set; }

        public FishTest()
        {
            FishesFight = new FishesFight();

            FishesFightStak = new FishesFightStak();

            FishesFightQueue = new FishesFightQueue();
        }

        [Theory]
        [MemberData(nameof(FishData.FishesFightSuccess), MemberType = typeof(FishData))]
        public void FishesFightSuccess(int[] sizes, int[] directions, List<Fish> expected) =>
            FishesFight.CalculateLifeFishOnRiver(sizes, directions).Should().BeEquivalentTo(expected);


        [Theory]
        [MemberData(nameof(FishData.FishesFightFail), MemberType = typeof(FishData))]
        public void FishesFightFail(int[] sizes, int[] directions, List<Fish> expected) =>
            FishesFight.CalculateLifeFishOnRiver(sizes, directions).Should().BeEquivalentTo(expected);

        [Theory]
        [MemberData(nameof(FishData.FishFightSuccess), MemberType = typeof(FishData))]
        public void FishFightStakSuccess(int[] sizes, int[] directions, int expected) =>
            FishesFightStak.CalculateLifeFishOnRiver(sizes, directions).Should().Be(expected);

        [Theory]
        [MemberData(nameof(FishData.FishFightFail), MemberType = typeof(FishData))]
        public void FishFightStakFail(int[] sizes, int[] directions, int expected) =>
            FishesFightStak.CalculateLifeFishOnRiver(sizes, directions).Should().Be(expected);

        [Theory]
        [MemberData(nameof(FishData.FishFightSuccess), MemberType = typeof(FishData))]
        public void FishFightQueueSuccess(int[] sizes, int[] directions, int expected) => 
            FishesFightQueue.CalculateLifeFishOnRiver(sizes, directions).Should().Be(expected);

        [Theory]
        [MemberData(nameof(FishData.FishFightFail), MemberType = typeof(FishData))]
        public void FishFightQueueFishFail(int[] sizes, int[] directions, int expected) => 
            FishesFightQueue.CalculateLifeFishOnRiver(sizes, directions).Should().Be(expected);
    }
}
