namespace Algorithms.Test.AddDummy
{
    public class ClassNameTest
    {
        [Theory]
        [MemberData(nameof(ClassNameData.ClassNameSuccess), MemberType = typeof(ClassNameData))]
        public void ClassNameSuccess()
        {

        }

        [Theory]
        [MemberData(nameof(ClassNameData.ClassNameFail), MemberType = typeof(ClassNameData))]
        public void ClassNameFail()
        {

        }
    }
}
