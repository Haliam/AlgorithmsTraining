namespace Algorithms.Test.CyclicRotation
{
    public class CyclicRotationTest
    {
        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationSuccess), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationSuccess(int k, int[] array, int[] expected) =>
            CyclicRotationArray.GetRotatedArray(k, array).Should().BeEquivalentTo(expected);

        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationSuccess), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationGptSuccess(int k, int[] array, int[] expected) =>
            CyclicRotationArrayGpt.GetRotatedArray(k, array).Should().BeEquivalentTo(expected);

        [Theory]
        [MemberData(nameof(CyclicRotationData.CyclicRotationFail), MemberType = typeof(CyclicRotationData))]
        public void CyclicRotationFail(int k, int[] array, int[] expected) => 
            CyclicRotationArray.GetRotatedArray(k, array).Should().BeEquivalentTo(expected);
    }
}
