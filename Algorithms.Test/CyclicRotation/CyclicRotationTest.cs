namespace Algorithms.Test.CyclicRotation
{
    public class CyclicRotationTest
    {
        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationSuccess), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationSuccess(int k, int[] array, int[] expected)
        {
            var result = CyclicRotationArray.Rotate(k, array);

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationFail), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationFail(int k, int[] array, int[] expected)
        {
            var result = CyclicRotationArray.Rotate(k, array);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
