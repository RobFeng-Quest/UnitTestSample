using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    /// <summary>
    /// Code from https://www.toptal.com/qa/how-to-write-testable-code-and-why-it-matters
    /// </summary>
    public class SmartHomeController
    {
        private readonly IDateTimeProvider FDateTimeProvider; // Dependency

        public DateTime LastMotionTime { get; private set; }

        public SmartHomeController(IDateTimeProvider dateTimeProvider)
        {
            // Inject required dependency in the constructor.
            FDateTimeProvider = dateTimeProvider;
        }

        public void ActuateLights(bool motionDetected)
        {
            DateTime time = FDateTimeProvider.GetDateTime(); // Delegating the responsibility

            // Update the time of last motion.
            if (motionDetected)
            {
                LastMotionTime = time;
            }

            // If motion was detected in the evening or at night, turn the light on.
            string timeOfDay = GetTimeOfDay(time);
            if (motionDetected && (timeOfDay == "Evening" || timeOfDay == "Night"))
            {
                BackyardLightSwitcher.Instance.TurnOn();
            }
            // If no motion is detected for one minute, or if it is morning or day, turn the light off.
            else if (time.Subtract(LastMotionTime) > TimeSpan.FromMinutes(1) || (timeOfDay == "Morning" || timeOfDay == "Noon"))
            {
                BackyardLightSwitcher.Instance.TurnOff();
            }
        }

        public string GetTimeOfDay(DateTime dateTime)
        {
            if (dateTime.Hour >= 0 && dateTime.Hour < 6)
            {
                return "Night";
            }
            if (dateTime.Hour >= 6 && dateTime.Hour < 12)
            {
                return "Morning";
            }
            if (dateTime.Hour >= 12 && dateTime.Hour < 18)
            {
                return "Noon";
            }
            return "Evening";
        }
    }
}
