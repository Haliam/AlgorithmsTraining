using Algorithms.Easy.Fish;
using FluentAssertions;

namespace Algorithms.Test.Fish
{
    public class FishTest : IDisposable
    {
        [Theory]
        [MemberData(nameof(FishData.Data), MemberType = typeof(FishData))]
        public void CountLiveFish(int[] a, int[] b, int expected)
        {
            var result = FishSolution.GetNumberOfLiveFish(a, b);
            result.Should().Be(expected);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
