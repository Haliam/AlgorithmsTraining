using Algorithms.Easy.OddOccurrences;

namespace Algorithms.Test
{
    public class OddOccurrencesTest 
    {
        [Theory]
        [MemberData(nameof(OddOccurrencesData.OddOccurrencesSuccess), MemberType = typeof(OddOccurrencesData))]
        public void OddOccurrencesSuccess(int[] array, int expected) => 
            OddOccurrences.GetUnpairElement(array).Should().Be(expected);
    }
}
