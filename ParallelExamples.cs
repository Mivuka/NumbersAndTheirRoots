using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndTheirRoots
{

    public class ParallelExamples
    {
        public static async Task DealWithParallelForEachAsync(int start, int end)
        {
            var range = Enumerable.Range(start, end);
            await Parallel.ForEachAsync(range, LongRunningOperationAsync);
        }

        static void LongRunningOperation(int operationId)
        {
            Console.WriteLine($"Root of {operationId} is {Math.Sqrt(operationId)}");
        }

        static ValueTask LongRunningOperationAsync(int operationId, CancellationToken token)
        {
            LongRunningOperation(operationId);
            return ValueTask.CompletedTask;
        }

    }
}
