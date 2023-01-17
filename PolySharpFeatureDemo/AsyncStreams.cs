using System.Collections.Generic;
using System.Threading;

namespace PolySharpFeatures
{
    internal class AsyncStreams
    {
        internal async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 5; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }

        public async Task EnumerateSequence()
        {
            Debug.WriteLine("AsyncStreams.EnumerateSequence");
            await foreach (var number in GenerateSequence()) 
            { 
                Debug.WriteLine(number);
            }
            Debug.WriteLine("");
        }

        public static void Execute()
        {
            new AsyncStreams().EnumerateSequence().Wait();
        }
    }

    
}
