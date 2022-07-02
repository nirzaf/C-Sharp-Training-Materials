int[] n = { 3, 5, 11, 2 };

Console.WriteLine(FindIt(n));

static int FindIt(int[] num)
{
    Array.Sort(num);
    int maxVal = num[num.Length - 1];
    Console.WriteLine("Max Value : " + maxVal);
    int minVal = num[0];
    Console.WriteLine("Min Value : " + minVal);
    int count = num.Count();
    Console.WriteLine("Count : " + count);
    return maxVal - minVal - count + 1;
}