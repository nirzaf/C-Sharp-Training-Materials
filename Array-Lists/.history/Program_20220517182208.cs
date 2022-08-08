
//List of Names 

//var names = new List<string> { "<name>", "Ana", "Felipe" };
//foreach (var name in names)
//{
//    Console.WriteLine($"Hello {name.ToUpper()}!");
//}


//var namesList = new List<string> { "Sophia", "Ana", "Jayme", "Bill" };
//string nameIndex = "Ana";
//var index = namesList.IndexOf(nameIndex);
//Console.WriteLine($"Found {nameIndex} at {index}");


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