using NUnit.Framework;
using System;
using Moq;
using Autofac.Extras.Moq;

namespace SmartHomeSystem.UnitTest
{
    [TestFixture]
    public class SmartHomeControllerTests
    {
        public class FakeDateTimeProvider : IDateTimeProvider
        {
            public DateTime ReturnValue { get; set; }

            public DateTime GetDateTime() { return ReturnValue; }

            public FakeDateTimeProvider(DateTime returnValue) { ReturnValue = returnValue; }
        }

        [Test]
        public void ActuateLights_MotionDetectedAtNight_TurnsOnTheLight()
        {
            // Arrange
            var controller = new SmartHomeController(new FakeDateTimeProvider(new DateTime(2015, 12, 31, 23, 59, 59)));

            // Act
            controller.ActuateLights(true);

            // Assert
            Assert.AreEqual(new DateTime(2015, 12, 31, 23, 59, 59), controller.LastMotionTime);
        }

        [Test]
        public void ActuateLights_MotionNotDetected_NoChangeTimeOfMotion()
        {
            // Arrange
            var fakeDateTimeProvider = Mock.Of<IDateTimeProvider>();
            var controller = new SmartHomeController(fakeDateTimeProvider);
            
            // Act
            controller.ActuateLights(false);

            // Assert
            Assert.AreEqual(new DateTime(0), controller.LastMotionTime);
        }

        [Test]
        public void ActuateLights_MotionNotDetected_NoChangeTimeOfMotion2()
        {
            // Arrange
            var mock = AutoMock.GetLoose(); // Using Autofac + Moq
            mock.Mock<IDateTimeProvider>().Setup(p => p.GetDateTime()).Throws<InvalidOperationException>();

            var controller = mock.Create<SmartHomeController>();
            
            // Act
            controller.ActuateLights(false);

            // Assert
            Assert.AreEqual(new DateTime(0), controller.LastMotionTime);
        }
    }
}
