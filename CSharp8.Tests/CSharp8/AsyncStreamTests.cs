#if NET462_OR_GREATER
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolySharpFeatureTests.CSharp8
{
   [TestClass]
   public class AsyncStreamTests
   {
      [TestMethod]
      public async Task AsyncStream_WhenEnumerated_ReturnsAllItems()
      {
         // Arrange
         var count = 5;
         var sequence = GenerateSequence(count);

         // Act
         var data = await EnumerateSequence(sequence);

         // Assert
         Assert.IsNotNull(data);
         Assert.AreEqual(count, data.Count());
      }

      internal async IAsyncEnumerable<int> GenerateSequence(int sequenceSize)
      {
         for (int i = 0; i < sequenceSize; i++)
         {
            await Task.Delay(100);
            yield return i;
         }
      }

      public async Task<IEnumerable<int>> EnumerateSequence(IAsyncEnumerable<int> sequence)
      {
         var data = new List<int>();

         await foreach (var number in sequence)
         {
            data.Add(number);
         }

         return data;
      }

   }
}
#endif