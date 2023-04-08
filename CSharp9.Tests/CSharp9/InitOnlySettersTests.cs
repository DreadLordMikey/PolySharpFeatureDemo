using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CSharp9.Tests.Helpers;

namespace PolySharpFeatureTests.CSharp9
{
    [TestClass]
    public class InitOnlySettersTests
    {

        [TestMethod]
        public void Struct_WithInitOnlySetters_ProducesExpectedResult()
        {
            // Arrange
            var now = DateTime.Now;

            var expectedRecordedAt = now;
            var expectedTemperature = 20;
            var expectedPressure = 998.0m;

            // Act
            var actual = new WeatherObservation
            {
                RecordedAt = expectedRecordedAt,
                TemperatureInCelsius = expectedTemperature,
                PressureInMillibars = expectedPressure
            };

            // Assert
            Assert.AreEqual(expectedTemperature, actual.TemperatureInCelsius);
            Assert.AreEqual(expectedPressure, actual.PressureInMillibars);
            Assert.AreEqual(now, actual.RecordedAt);
        }
    }
}
