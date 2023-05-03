using Algorithms.Easy.OddOccurrences;

namespace Algorithms.Test
{
    public class OddOccurrencesTest 
    {
        [Theory]
        [MemberData(nameof(OddOccurrencesData.OddOccurrencesSuccess), MemberType = typeof(OddOccurrencesData))]
        public void FishesFightSuccess(int[] array, int expected) => 
            OddOccurrences.GetUnpairElement(array).Should().Be(expected);
    }
}
