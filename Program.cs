//Console.WriteLine("Enter start of range (integer number)");
//var startRange = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter end of range (integer number)");
//var endRange = int.Parse(Console.ReadLine());

//var range = Enumerable.Range(startRange, endRange);

//var NumberRootPairs = new SortedDictionary<int, double>();

//Parallel.ForEach(range, rootCalc);

//void rootCalc(int number)
//{
//    NumberRootPairs.Add(number, Math.Sqrt(number));
//}

//foreach (var pair in NumberRootPairs)
//{
//    Console.WriteLine($"{pair.Key} -> {pair.Value}");
//}
using NumbersAndTheirRoots;

Console.WriteLine("Enter start of range (integer number)");
var startRange = int.Parse(Console.ReadLine());

Console.WriteLine("Enter end of range (integer number)");
var endRange = int.Parse(Console.ReadLine());

var NumberRootPairs = new SortedDictionary<int, double>();

await ParallelExamples.DealWithParallelForEachAsync(startRange, endRange);

