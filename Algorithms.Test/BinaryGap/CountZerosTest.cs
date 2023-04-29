

namespace Algorithms.Test
{
    public class CountZerosTest 
    {
        [Theory]
        [MemberData(nameof(CountZerosData.CountZerosSuccess), MemberType = typeof(CountZerosData))]
        public void CountZerosSuccess(string number, int expected)
        {
            var result = CountZeros.MaxZerosBetweenOnes(number);
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(CountZerosData.CountZerosSuccess), MemberType = typeof(CountZerosData))]
        public void CountZerosGptSucces(string number, int expected)
        {
            var result = CountZerosGpt.MaxZerosBetweenOnes(number);
            result.Should().Be(expected);
        }

        [Theory]
        [MemberData(nameof(CountZerosData.BinaryNumberValidationFail), MemberType = typeof(CountZerosData))]
        public void BinaryNumberValidationFail(string number, bool expected)
        {
            var result = BinaryNumberValidation.IsValid(number);
            result.Should().Be(expected);
        }
    }
}