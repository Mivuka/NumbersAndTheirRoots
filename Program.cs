using NumbersAndTheirRoots;

Console.WriteLine("Enter start of range (integer number)");
var startRange = int.Parse(Console.ReadLine());

Console.WriteLine("Enter end of range (integer number)");
var endRange = int.Parse(Console.ReadLine());

NumberRootPairsPrinter.PrintNumberRootPairsInRange(startRange, endRange);

