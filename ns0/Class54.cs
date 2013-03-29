using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class54
	{
		public static Dictionary<uint, Class55> dictionary_0;
		public static Dictionary<string, uint> dictionary_1;
		public Class54()
		{
			Class54.dictionary_0 = new Dictionary<uint, Class55>();
			Class54.dictionary_1 = new Dictionary<string, uint>();
		}
		public static void smethod_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Achievements..");
			Class54.dictionary_0.Clear();
			DataTable dataTable = class6_0.method_3("SELECT * FROM achievements");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Class54.dictionary_0.Add((uint)dataRow["id"], new Class55((uint)dataRow["id"], (string)dataRow["type"], (int)dataRow["levels"], (string)dataRow["badge"], (int)dataRow["pixels_base"], (double)dataRow["pixels_multiplier"], Phoenix.smethod_3(dataRow["dynamic_badgelevel"].ToString()), (int)dataRow["score_base"]));
				}
				Class54.dictionary_1.Clear();
				dataTable = class6_0.method_3("SELECT * FROM badges");
				if (dataTable != null)
				{
					foreach (DataRow dataRow in dataTable.Rows)
					{
						Class54.dictionary_1.Add((string)dataRow["badge"], (uint)dataRow["id"]);
					}
					GClass4.smethod_1("completed!");
				}
			}
		}
		public uint method_0(string string_0)
		{
			uint result;
			if (Class54.dictionary_1.ContainsKey(string_0))
			{
				result = Class54.dictionary_1[string_0];
			}
			else
			{
				result = 0u;
			}
			return result;
		}
		public bool method_1(Class16 class16_0, uint uint_0, int int_0)
		{
			return class16_0.method_2().dictionary_0.ContainsKey(uint_0) && class16_0.method_2().dictionary_0[uint_0] >= int_0;
		}
		public static GClass5 smethod_1(Class16 class16_0)
		{
			int num = Class54.dictionary_0.Count;
			foreach (KeyValuePair<uint, Class55> current in Class54.dictionary_0)
			{
				if (current.Value.string_0 == "hidden")
				{
					num--;
				}
			}
			GClass5 gClass = new GClass5(436u);
			gClass.method_9(num);
			foreach (KeyValuePair<uint, Class55> current in Class54.dictionary_0)
			{
				if (!(current.Value.string_0 == "hidden"))
				{
					int num2 = 0;
					int num3 = 1;
					if (class16_0.method_2().dictionary_0.ContainsKey(current.Value.uint_0))
					{
						num2 = class16_0.method_2().dictionary_0[current.Value.uint_0];
					}
					if (current.Value.int_0 > 1 && num2 > 0)
					{
						num3 = num2 + 1;
					}
					if (num3 > current.Value.int_0)
					{
						num3 = current.Value.int_0;
					}
					gClass.method_11(current.Value.uint_0);
					gClass.method_9(num3);
					gClass.method_7(Class54.smethod_3(current.Value.string_1, num3, current.Value.bool_0));
					gClass.method_9(1);
					gClass.method_9(0);
					gClass.method_9(0);
					gClass.method_9(0);
					gClass.method_13(num2 == current.Value.int_0);
					gClass.method_7(current.Value.string_0);
					gClass.method_9(current.Value.int_0);
				}
			}
			return gClass;
		}
		public void method_2(Class16 class16_0, uint uint_0)
		{
			if (!Class54.dictionary_0.ContainsKey(uint_0))
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("AchievementID: " + uint_0 + " does not exist in your database!");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Class55 @class = Class54.dictionary_0[uint_0];
				if (@class != null)
				{
					if (class16_0.method_2().dictionary_0.ContainsKey(uint_0))
					{
						this.method_3(class16_0, uint_0, class16_0.method_2().dictionary_0[uint_0 + 1u]);
					}
					else
					{
						this.method_3(class16_0, uint_0, 1);
					}
				}
			}
		}
		public void method_3(Class16 class16_0, uint uint_0, int int_0)
		{
			if (!Class54.dictionary_0.ContainsKey(uint_0))
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("AchievementID: " + uint_0 + " does not exist in our database!");
				Console.ForegroundColor = ConsoleColor.White;
			}
			else
			{
				Class55 @class = Class54.dictionary_0[uint_0];
				if (@class != null && !this.method_1(class16_0, @class.uint_0, int_0) && int_0 >= 1 && int_0 <= @class.int_0)
				{
					int num = Class54.smethod_2(@class.int_1, @class.double_0, int_0);
					int num2 = Class54.smethod_2(@class.int_2, @class.double_0, int_0);
					using (GStruct0.smethod_0(class16_0.method_2().method_22().List_0))
					{
						List<string> list = new List<string>();
						foreach (Class57 current in class16_0.method_2().method_22().List_0)
						{
							if (current.string_0.StartsWith(@class.string_1))
							{
								list.Add(current.string_0);
							}
						}
						foreach (string current2 in list)
						{
							class16_0.method_2().method_22().method_6(current2);
						}
					}
					class16_0.method_2().method_22().method_2(class16_0, Class54.smethod_3(@class.string_1, int_0, @class.bool_0), true);
					if (class16_0.method_2().dictionary_0.ContainsKey(@class.uint_0))
					{
						class16_0.method_2().dictionary_0[@class.uint_0] = int_0;
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							class2.method_1(string.Concat(new object[]
							{
								"UPDATE user_achievements SET achievement_level = '",
								int_0,
								"' WHERE user_id = '",
								class16_0.method_2().uint_0,
								"' AND achievement_id = '",
								@class.uint_0,
								"' LIMIT 1; UPDATE user_stats SET AchievementScore = AchievementScore + ",
								num2,
								" WHERE id = '",
								class16_0.method_2().uint_0,
								"' LIMIT 1; "
							}));
							goto IL_346;
						}
					}
					class16_0.method_2().dictionary_0.Add(@class.uint_0, int_0);
					using (Class6 class2 = Phoenix.smethod_12().method_0())
					{
						class2.method_1(string.Concat(new object[]
						{
							"INSERT INTO user_achievements (user_id,achievement_id,achievement_level) VALUES ('",
							class16_0.method_2().uint_0,
							"','",
							@class.uint_0,
							"','",
							int_0,
							"'); UPDATE user_stats SET AchievementScore = AchievementScore + ",
							num2,
							" WHERE id = '",
							class16_0.method_2().uint_0,
							"' LIMIT 1; "
						}));
					}
					IL_346:
					GClass5 gClass = new GClass5(437u);
					gClass.method_11(@class.uint_0);
					gClass.method_9(int_0);
					gClass.method_9(1337);
					gClass.method_7(Class54.smethod_3(@class.string_1, int_0, @class.bool_0));
					gClass.method_9(num2);
					gClass.method_9(num);
					gClass.method_9(0);
					gClass.method_9(0);
					gClass.method_9(0);
					if (int_0 > 1)
					{
						gClass.method_7(Class54.smethod_3(@class.string_1, int_0 - 1, @class.bool_0));
					}
					else
					{
						gClass.method_7("");
					}
					gClass.method_7(@class.string_0);
					class16_0.method_14(gClass);
					class16_0.method_2().int_13 += num2;
					class16_0.method_2().int_3 += num;
					class16_0.method_2().method_16(num);
				}
			}
		}
		public static int smethod_2(int int_0, double double_0, int int_1)
		{
			return (int)((double)int_0 * ((double)int_1 * double_0));
		}
		public static string smethod_3(string string_0, int int_0, bool bool_0)
		{
			string result;
			if (!bool_0)
			{
				result = string_0;
			}
			else
			{
				result = string_0 + int_0;
			}
			return result;
		}
	}
}
