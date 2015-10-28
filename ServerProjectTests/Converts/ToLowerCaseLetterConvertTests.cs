using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ServerProject.Converts;
using StoryQ;

namespace ServerProjectTests.Converts
{			 
	[TestFixture]
	public class ToLowerCaseLetterConvertTests
	{
		[Test]
		public void ConvertToLower()
		{
			// arrange
			string convertContent = "ABC";
			string expected = "abc";
			ToLowerCaseLetterConvert converterHost = new ToLowerCaseLetterConvert();

			// action
			string actual = converterHost.Convert(convertContent);

			// assert
			Assert.AreEqual(expected, actual);
		}

		private string convertContent = null;
		private string actual = null;

		[Test]
		public void TestCaseConvertToLower()
		{
			new Story("lower case letter convert")
				.InOrderTo("convert a string to lower case")
				.AsA("caller")
				.IWant("to convert a string to lower")

						.WithScenario("upper string to lower")
							.Given(AUpperString_, "ABC")
							.When(CallingTheConvert)
							.Then(ItShouldBeReturnALowerString_, "abc")

				.ExecuteWithReport(MethodBase.GetCurrentMethod());
		}

		private void AUpperString_(string content)
		{
			convertContent = content;
		}

		private void CallingTheConvert()
		{
			ToLowerCaseLetterConvert converterHost = new ToLowerCaseLetterConvert();
			actual = converterHost.Convert(convertContent);
		}

		private void ItShouldBeReturnALowerString_(string expected)
		{
			Assert.AreEqual(expected, actual);
		}
	}
}
