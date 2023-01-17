namespace PolySharpFeatureTests
{
   [TestClass]
   public class PatternMatchingTests
   {
      [TestMethod]
      public void TypePattern_InSwitchStatement_MatchesPattern()
      {
         // Arrange
         var expected = true;
         var actual = false;

         // Act
         switch ("Hello, World")
         {
            case string message:
               actual = true;
               break;
         }

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Pattern_InSwitchExpression_MatchesPattern()
      {
         // Arrange
         var expected = 1;

         var value = ConsoleColor.Red;

         // Act
         var actual = value switch
         {
            ConsoleColor.Red => 1,
            ConsoleColor.Green => 2,
            ConsoleColor.Blue => 3,
            _ => 0
         };

         // Assert
         Assert.AreEqual(expected, actual);
      }

      [TestMethod]
      public void Pattern_WithGuard_MatchesPatternAndGuard()
      {
         // Arrange
         var p0 = new Point(0, 0);
         var p1 = new Point(5, 10);
         var p2 = new Point(10, 5);
         var p3 = new Point(5, 5);

         // Act
         var p0Actual = Point.Transform(p0);
         var p1Actual = Point.Transform(p1);
         var p2Actual = Point.Transform(p2);
         var p3Actual = Point.Transform(p3);

         // Assert
         Assert.AreEqual(p0.X, p0Actual.X);
         Assert.AreEqual(p0.Y, p0Actual.Y);

         Assert.AreEqual(p1.X + p1.Y, p1Actual.X);
         Assert.AreEqual(p1.Y, p1Actual.Y);

         Assert.AreEqual(p2.X - p2.Y, p2Actual.X);
         Assert.AreEqual(p2.Y, p2Actual.Y);

         Assert.AreEqual(2 * p3.X, 2 * p3.Y);
      }

      public readonly struct Point
      {
         public Point(int x, int y) => (X, Y) = (x, y);

         public int X { get; }
         public int Y { get; }   

         public static Point Transform(Point point) => point switch
         {
            { X: 0, Y: 0 } => new Point(0, 0),
            { X: var x, Y: var y } when x < y => new Point(x + y, y),
            { X: var x, Y: var y } when x > y => new Point(x - y, y),
            { X: var x, Y: var y } => new Point(2 * x, 2 * y),
         };
      }
   }
}
