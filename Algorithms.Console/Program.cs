﻿// See https://aka.ms/new-console-template for more information

using Algorithms.Easy.CountZeros;

string number = "000001000001000111";

var result = CountZerosV1.CalculateMaxZerosBetweenTwoOne(number);

Console.WriteLine("For binary number {0} the result of concat zeros between 1 is {1}.", number, result);
