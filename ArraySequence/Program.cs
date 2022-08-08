int[] n = { 3, 5, 11, 2 };

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

//create a function that takes two dates argument and returns difference in days
static int DateDiff(DateTime d1, DateTime d2)
{
    return (d1 - d2).Days;
}