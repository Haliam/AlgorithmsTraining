namespace Algorithms.Easy.Anagrams
{
    public class AnagramsChecker
    {
        public static bool AreAnagrams(string s1, string s2)
        {
            if ((s1.Length != s2.Length) ||
                (s1 == s2))
                return false;

            string firstString = new string(s1.ToLower().Where(c => !Char.IsWhiteSpace(c)).OrderBy(c => c).ToArray());

            string secondString = new string(s2.ToLower().Where(c => !Char.IsWhiteSpace(c)).OrderBy(c => c).ToArray());

            if (!firstString.Equals(secondString))
                return false;

            return true;
        }
    }
}
