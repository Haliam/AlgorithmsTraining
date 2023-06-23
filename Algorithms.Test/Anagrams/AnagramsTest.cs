using Algorithms.Easy.Anagrams;

namespace Algorithms.Test
{
    public class AnagramTest 
    {
        [Theory]
        [MemberData(nameof(AnagramsData.AnagramsSuccess), MemberType = typeof(AnagramsData))]
        public void AnagramsSuccess(string firstString, string secondString) =>
             AnagramsChecker.AreAnagrams(firstString, secondString).Should().BeTrue();

        [Theory]
        [MemberData(nameof(AnagramsData.AnagramsFail), MemberType = typeof(AnagramsData))]
        public void AnagramsFail(string firstString, string secondString) => 
            AnagramsChecker.AreAnagrams(firstString, secondString).Should().BeFalse();
    }
}