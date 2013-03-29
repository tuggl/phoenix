using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Threading;
namespace ns0
{
	internal sealed class Class8
	{
		private static Dictionary<string, string> dictionary_0;
		public Class8()
		{
			Class8.dictionary_0 = new Dictionary<string, string>();
		}
		public static void smethod_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading external texts...");
			Class8.smethod_2();
			DataTable dataTable = class6_0.method_3("SELECT identifier, display_text FROM texts ORDER BY identifier ASC;");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Class8.dictionary_0.Add(dataRow["identifier"].ToString(), dataRow["display_text"].ToString());
				}
			}
			GClass4.smethod_1("completed!");
		}
		public static string smethod_1(string string_0)
		{
			string result;
			if (Class8.dictionary_0 != null && Class8.dictionary_0.Count > 0)
			{
				result = Class8.dictionary_0[string_0];
			}
			else
			{
				result = string_0;
			}
			return result;
		}
		public static void smethod_2()
		{
			Class8.dictionary_0.Clear();
		}
		public static void smethod_3()
        {

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine();
			Console.WriteLine("        ______  _                       _          _______             ");
			Console.WriteLine("       (_____ \\| |                     (_)        (_______)            ");
			Console.WriteLine("        _____) ) | _   ___   ____ ____  _ _   _    _____   ____  _   _ ");
			Console.WriteLine("       |  ____/| || \\ / _ \\ / _  )  _ \\| ( \\ / )  |  ___) |    \\| | | |");
			Console.WriteLine("       | |     | | | | |_| ( (/ /| | | | |) X (   | |_____| | | | |_| |");
			Console.WriteLine("       |_|     |_| |_|\\___/ \\____)_| |_|_(_/ \\_)  |_______)_|_|_|\\____|");
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                       " + Phoenix.String_0);
            Console.WriteLine();

		}

	}
      
}
