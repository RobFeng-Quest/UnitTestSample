using ServerProject.Converts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerProject
{
	public class Converter : IConverter
	{
		Dictionary<string, IConvert> FHandlers = null;

		public string Convert(string aType, string aContent)
		{
			IConvert handler = LookupHandlerBy(aType);

			return handler.Convert(aContent);
		}

		private IConvert LookupHandlerBy(string aType)
		{
			return FHandlers[aType];
		}

		public Converter()
		{
			FHandlers = new Dictionary<string, IConvert>();
			FHandlers["001"] = new ToLowerCaseLetterConvert();
			FHandlers["002"] = new ToUpperCaseLetterConvert();
		}
	}
}
