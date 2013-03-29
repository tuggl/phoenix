using System;
using System.Collections.Generic;
using System.IO;
namespace ns0
{
	internal sealed class Class1
	{
		public Dictionary<string, string> dictionary_0;
		public Class1(string string_0)
		{
			this.dictionary_0 = new Dictionary<string, string>();
			if (!File.Exists(string_0))
			{
				throw new Exception("Unable to locate configuration file at '" + string_0 + "'.");
			}
			try
			{
				using (StreamReader streamReader = new StreamReader(string_0))
				{
					string text;
					while ((text = streamReader.ReadLine()) != null)
					{
						if (text.Length >= 1 && !text.StartsWith("#"))
						{
							int num = text.IndexOf('=');
							if (num != -1)
							{
								string key = text.Substring(0, num);
								string value = text.Substring(num + 1);
								this.dictionary_0.Add(key, value);
							}
						}
					}
					streamReader.Close();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Could not process configuration file: " + ex.Message);
			}
		}
	}
}
