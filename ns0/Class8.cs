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

			Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Phoenix Emulator");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("           v3.11.1");
            Console.WriteLine("      Mono Edition");
            Console.WriteLine();

		}
        private static void MatrixStep(int width, int height, int[] y, int[] l)
        {
            int x;
            thistime = !thistime;
            for (x = 0; x < width; ++x)
            {
                if (x % 11 == 10)
                {
                    if (!thistime)
                        continue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.SetCursorPosition(x, inBoxY(y[x] - 2 - (l[x] / 40 * 2), height));
                    Console.Write(R);
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.SetCursorPosition(x, y[x]);
                Console.Write(R);
                y[x] = inBoxY(y[x] + 1, height);
                Console.SetCursorPosition(x, inBoxY(y[x] - l[x], height));
                Console.Write(' ');
            }
        }

        private static void Initialize(out int width, out int height, out int[] y, out int[] l)
        {
            int h1;
            int h2 = (h1 = (height = Console.WindowHeight) / 2) / 2;
            width = Console.WindowWidth - 1;
            y = new int[width];
            l = new int[width];
            int x;
            Console.Clear();
            for (x = 0; x < width; ++x)
            {
                y[x] = r.Next(height);
                l[x] = r.Next(h2 * ((x % 11 != 10) ? 2 : 1), h1 * ((x % 11 != 10) ? 2 : 1));
            }
        }

        static Random r = new Random();
        private static bool thistime;
        static char R
        {
            get
            {
                int t = r.Next(10);
                if (t <= 2)
                    return (char)('0' + r.Next(10));
                else if (t <= 4)
                    return (char)('a' + r.Next(27));
                else if (t <= 6)
                    return (char)('A' + r.Next(27));
                else
                    return (char)(r.Next(32, 255));
            }
        }
        public static int inBoxY(int n, int height)
        {
            n = n % height;
            if (n < 0)
                return n + height;
            else
                return n;
        }
	}
}
