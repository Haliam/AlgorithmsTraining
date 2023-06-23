namespace Algorithms.Test.ClosestToZero;

public class ClosestToZeroTest
{
    [Theory]
    [MemberData(nameof(ClosestToZeroData.ClosestToZeroSuccess), MemberType = typeof(ClosestToZeroData))]
    public void ClosestToZeroSuccess(int[] ts, int expected) =>
        Algorithms.Easy.ClosestToZero.ClosestToZero.ComputeClosestToZero(ts).Should().Be(expected);


    [Theory]
    [MemberData(nameof(ClosestToZeroData.ClosestToZeroFail), MemberType = typeof(ClosestToZeroData))]
    public void ClosestToZeroFail(int[] ts, int expected) =>
        Algorithms.Easy.ClosestToZero.ClosestToZero.ComputeClosestToZero(ts).Should().Be(expected);
}
