using Demo;

Console.WriteLine($"Random string generated: {StringProcessor.Generate()}");
Console.WriteLine("List");

var array = ArrayProcessor.Generate();
foreach (var item in array)
{
    Console.WriteLine($"\t{item}");
}
