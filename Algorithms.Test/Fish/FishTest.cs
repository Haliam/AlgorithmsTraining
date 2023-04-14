using Algorithms.Easy.Fish;
using FluentAssertions;

namespace Algorithms.Test.Fish
{
    public class FishTest : IDisposable
    {
        [Theory]
        [MemberData(nameof(FishData.DataToSuccess), MemberType = typeof(FishData))]
        public void GetNumberOfLiveFish_ShouldReturnExpected(int[] arrayA, int[] arrayB, int expected)
        {
            var result = FishSolution.GetNumberOfLiveFish(arrayA, arrayB);

            result.Should().NotBe(null);

            result.Should().Be(expected);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
