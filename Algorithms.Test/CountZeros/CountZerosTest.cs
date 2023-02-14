using Algorithms.Easy.CountZeros;
using FluentAssertions;

namespace Algorithms.Test
{
    public class CountZerosTest : IDisposable
    {
        [Theory]
        [MemberData(nameof(CountZerosData.BinaryNumber), MemberType = typeof(CountZerosData))]
        public void CountZerosSuccessV1(string number, int expected)
        {
            var result = CountZerosV1.CalculateMaxZerosBetweenTwoOne(number);
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(CountZerosData.BinaryNumber), MemberType = typeof(CountZerosData))]
        public void CountZerosSuccessV2(string number, int expected)
        {
            var result = CountZerosV2.CalculateMaxZerosBetweenTwoOne(number);
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(CountZerosData.BinaryNumber), MemberType = typeof(CountZerosData))]
        public void CountZerosSuccessV3(string number, int expected)
        {
            var result = CountZerosV3.CalculateMaxZerosBetweenTwoOne(number);
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(CountZerosData.BinaryNumber), MemberType = typeof(CountZerosData))]
        public void CountZerosSuccessV4(string number, int expected)
        {
            var result = CountZerosV4.CalculateMaxZerosBetweenTwoOne(number);
            result.Should().Be(expected);
        }

        public void Dispose()
        {
            
        }
    }
}