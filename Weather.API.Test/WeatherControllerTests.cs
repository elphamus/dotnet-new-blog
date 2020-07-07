using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Weather.API.Controllers;
using Moq;

namespace Weather.API.Test
{
    [TestClass]
    public class WeatherControllerTests
    {
        [TestMethod]
        [Description("Validates that the controller returns 5 values")]
        public void WeatherController_Get_Returns5Restults()
        {
            // Arrange
            var mockLogger = new Mock<ILogger<WeatherForecastController>>();
            var controller = new WeatherForecastController(mockLogger.Object);

            // Act 
            var response = controller.Get();

            // Assert
            Assert.AreEqual(5, response.ToList().Count());
        }

        [TestMethod]
        [Description("Validates that the controller returns the correct dates")]
        public void WeatherController_Get_ReturnsCorrectDates()
        {
            
        }
    }
}
