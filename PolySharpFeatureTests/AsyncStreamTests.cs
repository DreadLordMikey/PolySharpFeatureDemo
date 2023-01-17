namespace PolySharpFeatureTests
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

         Debug.WriteLine("AsyncStreams.EnumerateSequence");
         await foreach (var number in sequence)
         {
            data.Add(number);
         }

         return data;
      }

   }
}
