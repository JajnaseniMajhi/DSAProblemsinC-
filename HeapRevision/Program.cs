// See https://aka.ms/new-console-template for more information
using HeapRevision;

Console.WriteLine("Hello, World!");
MaxChocolates maxChocolates = new MaxChocolates();
var result=maxChocolates.maxChoco(3, new List<int>() { 6, 5 });
Console.WriteLine(result);
var result1 = maxChocolates.maxChoco(5, new List<int>() { 2, 4, 6, 8, 10 });
Console.WriteLine(result1);
Console.ReadLine();
