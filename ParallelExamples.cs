namespace NumbersAndTheirRoots
{
    public class NumberRootPairsPrinter
    {       
        public static void PrintNumberRootPairsInRange(int start, int end)
        {
            var range = Enumerable.Range(start, end - start);

            var pairStrings = range.AsParallel().AsOrdered().Select(n => GetToStringNumberRootPair(n));

            foreach (var pair in pairStrings)
            {
                Console.WriteLine(pair);
            }            
        }
        public static string GetToStringNumberRootPair(int number)
        {
            return ($"{number} -> {Math.Round(Math.Sqrt(number),2)}");
        }
    }
}
