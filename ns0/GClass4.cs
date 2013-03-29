using System;
using System.IO;
using System.Text;
namespace ns0
{
	public sealed class GClass4
	{
		private static bool bool_0 = false;
		internal static void smethod_0(string string_0)
		{
			if (!GClass4.bool_0)
			{
				Console.Write(string_0);
			}
		}
		internal static void smethod_1(string string_0)
		{
			if (!GClass4.bool_0)
			{
				Console.WriteLine(string_0);
			}
		}
		internal static void smethod_2(string string_0)
		{
			try
			{
				FileStream fileStream = new FileStream("exceptions.err", FileMode.Append, FileAccess.Write);
				byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new object[]
				{
					DateTime.Now,
					": ",
					string_0,
					"\r\n\r\n"
				}));
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Close();
			}
			catch (Exception)
			{
				GClass4.smethod_1(DateTime.Now + ": " + string_0);
			}
			Console.ForegroundColor = ConsoleColor.Red;
			GClass4.smethod_1("Exception has been saved");
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		internal static void smethod_3(string string_0)
		{
			try
			{
				FileStream fileStream = new FileStream("criticalexceptions.err", FileMode.Append, FileAccess.Write);
				byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new object[]
				{
					DateTime.Now,
					": ",
					string_0,
					"\r\n\r\n"
				}));
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Close();
				Console.ForegroundColor = ConsoleColor.Red;
				GClass4.smethod_1("CRITICAL ERROR LOGGED");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			catch (Exception)
			{
				GClass4.smethod_1(DateTime.Now + ": " + string_0);
			}
		}
		internal static void smethod_4(string string_0)
		{
			try
			{
				FileStream fileStream = new FileStream("cacheerror.err", FileMode.Append, FileAccess.Write);
				byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new object[]
				{
					DateTime.Now,
					": ",
					string_0,
					"\r\n\r\n"
				}));
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Close();
			}
			catch (Exception)
			{
				GClass4.smethod_1(DateTime.Now + ": " + string_0);
			}
			Console.ForegroundColor = ConsoleColor.Red;
			GClass4.smethod_1("Critical error saved");
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		internal static void smethod_5(string string_0)
		{
			try
			{
				FileStream fileStream = new FileStream("ddos.txt", FileMode.Append, FileAccess.Write);
				byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new object[]
				{
					DateTime.Now,
					": ",
					string_0,
					"\r\n\r\n"
				}));
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Close();
			}
			catch
			{
			}
			GClass4.smethod_1(DateTime.Now + ": " + string_0);
		}
		internal static void smethod_6(string string_0, string string_1)
		{
			try
			{
				FileStream fileStream = new FileStream("threaderror.err", FileMode.Append, FileAccess.Write);
				byte[] bytes = Encoding.ASCII.GetBytes(string.Concat(new object[]
				{
					DateTime.Now,
					": Error in thread ",
					string_1,
					": \r\n",
					string_0,
					"\r\n\r\n"
				}));
				fileStream.Write(bytes, 0, bytes.Length);
				fileStream.Close();
				Console.ForegroundColor = ConsoleColor.Red;
				GClass4.smethod_1("Error in " + string_1 + " caught");
				Console.ForegroundColor = ConsoleColor.Gray;
			}
			catch (Exception)
			{
				GClass4.smethod_1(DateTime.Now + ": " + string_0);
			}
		}
		internal static void smethod_7()
		{
			GClass4.bool_0 = true;
		}
		internal static void smethod_8(string string_0)
		{
			throw new NotImplementedException();
		}
	}
}
