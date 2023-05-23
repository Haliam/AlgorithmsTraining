namespace Algorithms.Test
{
    public class BinaryGapTest 
    {
        [Theory]
        [MemberData(nameof(BinaryGapData.BinaryGapSuccess), MemberType = typeof(BinaryGapData))]
        public void CountZerosSuccess(string number, int expected) => 
            BinaryGap.MaxZerosBetweenOnes(number).Should().Be(expected);

        [Theory]
        [MemberData(nameof(BinaryGapData.BinaryGapSuccess), MemberType = typeof(BinaryGapData))]
        public void CountZerosGptSucces(string number, int expected) => 
            BinaryGapGpt.MaxZerosBetweenOnes(number).Should().Be(expected);

        [Theory]
        [MemberData(nameof(BinaryGapData.BinaryNumberValidationFail), MemberType = typeof(BinaryGapData))]
        public void BinaryNumberValidationFail(string number, bool expected) => 
            BinaryGapValidation.IsValid(number).Should().Be(expected);
    }
}