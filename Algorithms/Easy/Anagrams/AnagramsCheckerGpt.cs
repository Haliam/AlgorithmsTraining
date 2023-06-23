namespace Algorithms.Easy.Anagrams
{
    public class AnagramsCheckerGpt
    {
        public static bool AreAnagrams(string str1, string str2)
        {
            // Eliminar espacios en blanco y convertir a minúsculas
            string s1 = new string(str1.ToLower().Where(c => !Char.IsWhiteSpace(c)).ToArray());
            string s2 = new string(str2.ToLower().Where(c => !Char.IsWhiteSpace(c)).ToArray());

            // Verificar si tienen la misma longitud
            if (s1.Length != s2.Length)
                return false;

            // Ordenar los caracteres
            var sorted1 = s1.OrderBy(c => c).ToArray();
            var sorted2 = s2.OrderBy(c => c).ToArray();

            // Comparar los caracteres ordenados
            for (int i = 0; i < sorted1.Length; i++)
            {
                if (sorted1[i] != sorted2[i])
                    return false;
            }

            return true;
        }
    }
}
