namespace CSharp10.Tests.UnitTests;

[TestClass]
public class ImprovedIndefiniteAssignmentTests
{
    [TestMethod]
    public void Assigment_FromOutParameter_DoesNotProduceFalsePositive()
    {
        // Arrange
        var expected = "Foo";
        var actual = default(string);
        var c = new Foo();

        // Act
        if (c != null && c.GetDependentValue(out object buffer))
        {
            actual = buffer.ToString();
        }

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Assigment_FromNullConditionalOperator_DoesNotProduceFalsePositive()
    {
        // Arrange
        var expected = "Foo";
        var actual = default(string);
        var c = new Foo();

        // Act
        if (c?.GetDependentValue(out object buffer) == true)
        {
            actual = buffer.ToString();
        }

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Assigment_FromNullCoalescingOperator_DoesNotProduceFalsePositive()
    {
        // Arrange
        var expected = "Foo";
        var actual = default(string);
        var c = new Foo();

        // Act
        if (c?.GetDependentValue(out object buffer) ?? false)
        {
            actual = buffer.ToString();
        }

        // Assert
        Assert.AreEqual(expected, actual);
    }

    private class Foo
    {
        public bool GetDependentValue(out object obj)
        {
            obj = "Foo";
            return true;
        }
    }
}
