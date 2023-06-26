namespace Algorithms.Test.ClosestToZeroTemp;

public class ClosestToZeroTest
{
    [Theory]
    [MemberData(nameof(ClosestToZeroData.ClosestToZeroSuccess), MemberType = typeof(ClosestToZeroData))]
    public void ClosestToZeroSuccess(int[] ts, int expected) =>
    Easy.ClosestToZeroTemp.ClosestToZero.ComputeClosestToZero(ts).Should().Be(expected);


    [Theory]
    [MemberData(nameof(ClosestToZeroData.ClosestToZeroFail), MemberType = typeof(ClosestToZeroData))]
    public void ClosestToZeroFail(int[] ts, int expected) =>
    Easy.ClosestToZeroTemp.ClosestToZero.ComputeClosestToZero(ts).Should().Be(expected);

    [Theory]
    [MemberData(nameof(ClosestToZeroData.ClosestToZeroSuccess), MemberType = typeof(ClosestToZeroData))]
    public void ClosestToZeroGptSuccess(int[] ts, int expected) =>
    Easy.ClosestToZeroTemp.ClosestToZeroGpt.ComputeClosestToZero(ts).Should().Be(expected);

    [Theory]
    [MemberData(nameof(ClosestToZeroData.ClosestToZeroFail), MemberType = typeof(ClosestToZeroData))]
    public void ClosestToZeroGptFail(int[] ts, int expected) =>
    Easy.ClosestToZeroTemp.ClosestToZeroGpt.ComputeClosestToZero(ts).Should().Be(expected);
}
