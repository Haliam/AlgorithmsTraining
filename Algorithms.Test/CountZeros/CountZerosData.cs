namespace Algorithms.Test;

public class CountZerosData
{
    public static IEnumerable<object[]> BinaryNumber =>
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
                "111111",
                0
            },

            new object[]
            {
                "00000",
                0
            },
            new object[]
            {
                "100000",
                0
            },
            new object[]
            {
                "00001",
                0
            },
            new object[]
            {
                "01",
                0
            },
            new object[]
            {
                "10",
                0
            },
            new object[]
            {
                "1",
                0
            },
            new object[]
            {
                "0",
                0
            },
            new object[]
            {
                "-10",
                0
            },
            new object[]
            {
                "-1a0-1",
                0
            },
            new object[]
            {
                "-10-1",
                0
            },
            new object[]
            {
                "010100011",
                3
            }
        };

}