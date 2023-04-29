namespace Algorithms.Test;

public class CountZerosData
{
    public static IEnumerable<object[]> CountZerosSuccess =>
        new List<object[]>
        {
            new object[]
            {
                "10000010001100000000010000000000000000001",
                18
            },

            new object[]
            {
                "00110001000001",
                5
            },

            new object[]
            {
                "10000010001000000000000000100000000011",
                15
            },

            new object[]
            {
                "010100011",
                3
            },

            new object[]
            {
                "101001",
                2
            },

            new object[]
            {
                "00000000001010001",
                3
            },

            new object[]
            {
                "10100010000000000",
                3
            }
        };

    public static IEnumerable<object[]> BinaryNumberValidationFail =>
        new List<object[]>
        {
            new object[]
            {
                "111111",
                false
            },

            new object[]
            {
                "00000",
                false
            },
            new object[]
            {
                "100000",
                false
            },
            new object[]
            {
                "00001",
                false
            },
            new object[]
            {
                "01",
                false
            },
            new object[]
            {
                "10",
                false
            },
            new object[]
            {
                "1",
                false
            },
            new object[]
            {
                "0",
                false
            },
            new object[]
            {
                "-10",
                false
            },
            new object[]
            {
                "-1a0-1",
                false
            },
            new object[]
            {
                "-10-1",
                false
            }
        };
}