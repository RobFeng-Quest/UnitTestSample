using ServerProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProject
{
	public class ConverterHost
	{
		IConverter converter = null;

		public ConverterHost()
		{
			converter = new Converter();
		}

		public ConverterHost(IConverter converter)
		{
			this.converter = converter;
		}

		public string ToLower(string content)
		{
			return converter.Convert("001", content);
		}

		public string ToUpper(string content)
		{
			return converter.Convert("002", content);
		}
	}
}
