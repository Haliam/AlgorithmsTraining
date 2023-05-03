namespace Algorithms.Test.CyclicRotation
{
    public class CyclicRotationTest
    {
        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationSuccess), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationSuccess(int k, int[] array, int[] expected)
        {
            var result = CyclicRotationArray.GetRotatedArray(k, array);

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationSuccess), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationGptSuccess(int k, int[] array, int[] expected)
        {
            var result = CyclicRotationArrayGpt.GetRotatedArray(k, array);

            result.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationFail), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationFail(int k, int[] array, int[] expected)
        {
            var result = CyclicRotationArray.GetRotatedArray(k, array);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
