// See https://aka.ms/new-console-template for more information

//using Algorithms.Easy.CountZeros;

//string number = "000001000001000111";

//var result = CountZerosV1.CalculateMaxZerosBetweenTwoOne(number);

//Console.WriteLine("For binary number {0} the result of concat zeros between 1 is {1}.", number, result);


using Algorithms.Easy.Fish;

int[] arrayA = new int[] { 4, 3, 2, 1, 5 };

int[] arrayB = new int[] { 0, 1, 0, 0, 0 };

var result = new FishSolution().CalculateLifeFishOnRiver(arrayA, arrayB);

Console.WriteLine("The number of life fish are {0}.", result);
