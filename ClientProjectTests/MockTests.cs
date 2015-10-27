using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientProject;
using Moq;
using NUnit.Core;
using NUnit.Framework;
using ServerProject;

namespace ClientProjectTests
{
	[TestFixture]
	public class MockTests
	{
		private Mock<IConverter> converterMock = null;

		/// <summary>
		/// This runs only once at the beginning of all tests and is used for all tests in the class.
		/// </summary>
		[TestFixtureSetUp]
		public void InitialSetup()
		{
			Debug.WriteLine("Start testing at MockTests class");
		}

		interface IFoo
		{
			bool DoSomething(string a);
		}
		/// <summary>
		/// This setup funcitons runs before each test method
		/// </summary>
		[SetUp]
		public void SetupForEachTest()
		{
			Debug.WriteLine("Start a test ----");
			converterMock = new Mock<IConverter>();
		}

		[Test]
		public void ToLowerWillPassType001()
		{
			// arrange	   
			string expected = "001";
			string actual = string.Empty;
			converterMock.Setup(con => con.Convert(expected, It.IsAny<string>())).Callback(() => actual = expected);

			ConverterHost converterHost = new ConverterHost(converterMock.Object);

			// action
			converterHost.ToLower(string.Empty);

			// assert
			Assert.AreEqual(expected, actual);
			converterMock.Verify(converter => converter.Convert(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
		}

		/// <summary>
		/// This setup funcitons runs after each test method
		/// </summary>
		[TearDown]
		public void TearDownForEachTest()
		{
			Debug.WriteLine("End a test ----");
		}

		/// <summary>
		/// This runs only once at the end of all tests and is used for all tests in the class.
		/// </summary>
		[TestFixtureTearDown]
		public void FinalTearDown()
		{
			Debug.WriteLine("End test at MockTests class");
		}
	}
}
