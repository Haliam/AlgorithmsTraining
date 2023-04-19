using Algorithms.Easy.Fish;
using FluentAssertions;

namespace Algorithms.Test.Fish
{
    public class FishTest 
    {
        [Theory]
        [MemberData(nameof(FishData.DataToSuccess), MemberType = typeof(FishData))]
        public void FishStakSolution_ShouldReturnExpected(int[] arrayA, int[] arrayB, int expected)
        {
            var result = new FishStakSolution().CalculateLifeFishOnRiver(arrayA, arrayB);

            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.DataToFail), MemberType = typeof(FishData))]
        public void FishStakSolution_ShouldReturnNegativeValue(int[] arrayA, int[] arrayB, int expected)
        {
            var result = new FishStakSolution().CalculateLifeFishOnRiver(arrayA, arrayB);

            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.DataToSuccess), MemberType = typeof(FishData))]
        public void FishQueueSolution_ShouldReturnExpected(int[] arrayA, int[] arrayB, int expected)
        {
            var result = new FishQueueSolution().CalculateLifeFishOnRiver(arrayA, arrayB);

            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(FishData.DataToFail), MemberType = typeof(FishData))]
        public void FishQueueSolution_ShouldReturnNegativeValue(int[] arrayA, int[] arrayB, int expected)
        {
            var result = new FishQueueSolution().CalculateLifeFishOnRiver(arrayA, arrayB);

            result.Should().Be(expected);
        }
    }
}
