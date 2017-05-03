Fixing the Client API: Dependency Injection
Problem:
-- the ActuateLights need a DateTime.Now

How to fix:
-- introduce a argument, delegating the responsibility of providing a DateTime value 
	to the caller of a new method with signature ActuateLights(bool motionDetected, DateTime dateTime)

-- or --

-- keep ActuateLights(bool motionDetected) method and its clients testable: Inversion of Control, or IoC.
	Steps:
	1. Create create an IDateTimeProvider interface, containing a method signature for obtaining some date and time;
	2. make SmartHomeController reference an IDateTimeProvider implementation, and delegate it the responsibility of obtaining date and time;
	3. Fake implementation of IDateTimeProvider