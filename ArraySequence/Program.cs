﻿int[] n = { 3, 5, 11, 2 };

Console.WriteLine(FindIt(n));

Console.ReadLine();

static int FindIt(int[] num)
{
    Array.Sort(num);
    int maxVal = num[^1];
    Console.WriteLine("Max Value : " + maxVal);
    int minVal = num[0];
    Console.WriteLine("Min Value : " + minVal);
    int count = num.Length;
    Console.WriteLine("Count : " + count);
    return maxVal - minVal - count + 1;
}