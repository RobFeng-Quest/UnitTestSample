using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem.UnitTest
{
    [TestFixture]
    public class SmartHomeControllerTests
    {
        [Test]
        public void GetTimeOfDay_For6AM_ReturnsMorning()
        {
            // Arrange
            SmartHomeController controller = new SmartHomeController();

            // Act
            string timeOfDay = controller.GetTimeOfDay(new DateTime(2016, 12, 31, 06, 00, 00));

            // Assert
            Assert.AreEqual("Morning", timeOfDay);
        }
    }
}
