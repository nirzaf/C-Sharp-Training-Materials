


var names = new List<string> { "Sophia", "Ana", "Jayme", "Bill" };
Console.WriteLine("Pre Sorting:");
foreach (var name in names)
{
    Console.WriteLine(name);
}

names.Sort();

Console.WriteLine();
Console.WriteLine("Post Sorting:");
foreach (var name in names)
{
    Console.WriteLine(name);
}