namespace Algorithms.Test;

public static class AnagramsData
{
    public static IEnumerable<object[]> AnagramsSuccess =>
        new List<object[]>
        {
            new object[]
            {"Valora","Alvaro"},

            new object[]
            {"Raza","Zara"},

            new object[]
            {"Fotolitografía","Litofotografía"},

            new object[]
            {"Ballena","Llenaba"},
        };

    public static IEnumerable<object[]> AnagramsFail =>
        new List<object[]>
        {
            new object[]    
            {"Ballena", "Llenabo"},
            
            new object[]
            {"Balleno", "Llenaba"},

            new object[]
            {"Ball", "Llenaba"},

            new object[]
            {"Roto", "Arto"},
        };
}
