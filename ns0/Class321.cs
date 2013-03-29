using System;
using System.Net.Sockets;
namespace ns0
{
	internal sealed class Class321
	{
		private static string[] string_0;
		private static string string_1;
		internal static void smethod_0(int int_0)
		{
			Class321.string_0 = new string[int_0];
		}
		internal static bool smethod_1(Socket socket_0)
		{
			string text = socket_0.RemoteEndPoint.ToString().Split(new char[]
			{
				':'
			})[0];
			bool result;
			if (text == Class321.string_1)
			{
				result = false;
			}
			else
			{
				if (Class321.smethod_2(text) > 10 && text != "127.0.0.1" && !Class13.bool_0)
				{
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.WriteLine(text + " was banned by Anti-DDoS system.");
					Console.ForegroundColor = ConsoleColor.White;
					GClass4.smethod_5(text + " - " + DateTime.Now.ToString());
					Class321.string_1 = text;
					result = false;
				}
				else
				{
					int num = Class321.smethod_4();
					if (num < 0)
					{
						result = false;
					}
					else
					{
						Class321.string_0[num] = text;
						result = true;
					}
				}
			}
			return result;
		}
		private static int smethod_2(string string_2)
		{
			int num = 0;
			for (int i = 0; i < Class321.string_0.Length; i++)
			{
				if (Class321.string_0[i] == string_2)
				{
					num++;
				}
			}
			return num;
		}
		internal static void smethod_3(string string_2)
		{
			for (int i = 0; i < Class321.string_0.Length; i++)
			{
				if (Class321.string_0[i] == string_2)
				{
					Class321.string_0[i] = null;
					return;
				}
			}
		}
		private static int smethod_4()
		{
			int result;
			for (int i = 0; i < Class321.string_0.Length; i++)
			{
				if (Class321.string_0[i] == null)
				{
					result = i;
					return result;
				}
			}
			result = -1;
			return result;
		}
	}
}
