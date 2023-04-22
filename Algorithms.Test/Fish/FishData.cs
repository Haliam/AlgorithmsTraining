﻿namespace Algorithms.Test
{
    public class FishData
    {
        public static IEnumerable<object[]> FishFightSuccess =>
        new List<object[]>
        {
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 0, 1, 0, 0, 0 },
                2
            },
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 1, 0, 1, 0, 1 },
                3
            },
            new object[]
            {
                new int[]{ 4, 3, 2, 1, 5 },
                new int[]{ 0, 0, 1, 0, 1 },
                4
            },
            new object[]
            {
                new int[] { 11, 4, 3, 2, 1, 5, 6, 7, 8, 10},
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 1, 0},
                5
            },
        };

        public static IEnumerable<object[]> FishFightFail =>
        new List<object[]>
        {
           new object[]
           {
               new int[]{ 5, -3, 2, 7, 0},
               new int[]{ 0, 1, 0, 0, 0 },
               -1
           },
           new object[]
           {
               new int[]{},
               new int[]{ 0, 1, 0, 0, 0 },
               -1
           },
           new object[]
           {
               new int[]{ 1 },
               new int[]{ 0, 1, 0, 0, 0 },
               -1
           },
        };

        public static IEnumerable<object[]> HungryFishSuccesss =>
        new List<object[]>
        {
            new object[]
            {
                new int[] { 11, 4, 3, 2, 1, 5, 6, 7, 8, 10},
                new int[] { 0, 0, 1, 0, 0, 0, 0, 1, 1, 0},
                new List<Fish>
                {
                    new Fish(0, 11, Direction.Up),
                    new Fish(1, 4, Direction.Up),
                    new Fish(5, 5, Direction.Up),
                    new Fish(6, 6, Direction.Up),
                    new Fish(9, 10, Direction.Up)
                }
            }
        };
    }
}
