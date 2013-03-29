using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace ns0
{
	internal sealed class Class58
	{
		private static List<string> list_0;
		private static List<string> list_1;
		private static List<bool> list_2;
		private static List<string> list_3;
		public static void smethod_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Chat Filter..");
			Class58.list_0 = new List<string>();
			Class58.list_1 = new List<string>();
			Class58.list_2 = new List<bool>();
			Class58.list_3 = new List<string>();
			Class58.smethod_1(class6_0);
			GClass4.smethod_1("completed!");
		}
		public static void smethod_1(Class6 class6_0)
		{
			Class58.list_0.Clear();
			Class58.list_1.Clear();
			Class58.list_2.Clear();
			Class58.list_3.Clear();
			DataTable dataTable = class6_0.method_3("SELECT * FROM wordfilter ORDER BY word ASC;");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Class58.list_0.Add(dataRow["word"].ToString());
					Class58.list_1.Add(dataRow["replacement"].ToString());
					Class58.list_2.Add(Phoenix.smethod_3(dataRow["strict"].ToString()));
				}
			}
			DataTable dataTable2 = class6_0.method_3("SELECT * FROM linkfilter;");
			if (dataTable2 != null)
			{
				foreach (DataRow dataRow in dataTable2.Rows)
				{
					Class58.list_3.Add(dataRow["externalsite"].ToString());
				}
			}
		}
		public static bool smethod_2(string string_0)
		{
			bool result;
			if (Class13.String_2 == "disabled")
			{
				result = false;
			}
			else
			{
				if ((string_0.StartsWith("http://") || string_0.StartsWith("www.") || string_0.StartsWith("https://")) && Class58.list_3 != null && Class58.list_3.Count > 0)
				{
					foreach (string current in Class58.list_3)
					{
						if (string_0.Contains(current))
						{
							if (Class13.String_2 == "whitelist")
							{
								result = true;
								return result;
							}
							if (!(Class13.String_2 == "blacklist"))
							{
							}
						}
					}
				}
				result = (string_0.StartsWith("http://") || string_0.StartsWith("www.") || (string_0.StartsWith("https://") && Class13.String_2 == "blacklist") || (Class13.String_2 == "whitelist" && false));
			}
			return result;
		}
		public static string smethod_3(string string_0)
		{
			try
			{
			}
			catch
			{
			}
			return string_0;
		}
		public static string smethod_4(string string_0)
		{
			if (Class58.list_0 != null && Class58.list_0.Count > 0)
			{
				int num = -1;
				foreach (string current in Class58.list_0)
				{
					num++;
					if (string_0.ToLower().Contains(current.ToLower()) && Class58.list_2[num])
					{
						string_0 = Regex.Replace(string_0, current, Class58.list_1[num], RegexOptions.IgnoreCase);
					}
					else
					{
						if (string_0.ToLower().Contains(" " + current.ToLower() + " "))
						{
							string_0 = Regex.Replace(string_0, current, Class58.list_1[num], RegexOptions.IgnoreCase);
						}
					}
				}
			}
			return string_0;
		}
		public static bool smethod_5(Class16 class16_0, string string_0)
		{
			string[] array = string_0.Split(new char[]
			{
				' '
			});
			Class16 @class = null;
			Class14 class2 = class16_0.method_2().Class14_0;
			bool result;
			if (!Phoenix.smethod_15().method_4().dictionary_4.ContainsKey(array[0]))
			{
				result = false;
			}
			else
			{
				try
				{
					int num;
					if (class2 != null && class2.method_27(class16_0, true))
					{
						num = Phoenix.smethod_15().method_4().dictionary_4[array[0]];
						if (num <= 33)
						{
							if (num == 8)
							{
								class2 = class16_0.method_2().Class14_0;
								if (class2.bool_5)
								{
									class2.bool_5 = false;
								}
								else
								{
									class2.bool_5 = true;
								}
								Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
								result = true;
								return result;
							}
							if (num == 33)
							{
								class2 = class16_0.method_2().Class14_0;
								if (class2 != null && class2.method_27(class16_0, true))
								{
									List<Class63> list = class2.method_24(class16_0);
									class16_0.method_2().method_23().method_17(list);
									class16_0.method_2().method_23().method_9(true);
									Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0 + " " + class16_0.method_2().uint_3);
									result = true;
									return result;
								}
								result = false;
								return result;
							}
						}
						else
						{
							if (num == 46)
							{
								class2 = class16_0.method_2().Class14_0;
								try
								{
									int num2 = int.Parse(array[1]);
									if (class16_0.method_2().uint_1 >= 6u)
									{
										class2.int_3 = num2;
									}
									else
									{
										if (num2 > 100 || num2 < 5)
										{
											class16_0.method_8("ERROR: Use a number between 5 and 100");
										}
										else
										{
											class2.int_3 = num2;
										}
									}
								}
								catch
								{
									result = false;
									return result;
								}
								Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
								result = true;
								return result;
							}
							if (num == 53)
							{
								class2 = class16_0.method_2().Class14_0;
								Phoenix.smethod_15().method_9().method_16(class2);
								Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
								result = true;
								return result;
							}
						}
					}
					switch (Phoenix.smethod_15().method_4().dictionary_4[array[0]])
					{
					case 2:
					{
						if (!class16_0.method_2().method_3("cmd_alert"))
						{
							result = false;
							return result;
						}
						string text = array[1];
						@class = Phoenix.smethod_15().method_2().method_3(text);
						if (@class == null)
						{
							class16_0.method_8("Could not find user: " + text);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						@class.method_9(Class58.smethod_6(array, 2), 0);
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 3:
					{
						if (!class16_0.method_2().method_3("cmd_award"))
						{
							result = false;
							return result;
						}
						string text = array[1];
						@class = Phoenix.smethod_15().method_2().method_3(text);
						if (@class == null)
						{
							class16_0.method_8("Could not find user: " + text);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						Phoenix.smethod_15().method_12().method_2(@class, Convert.ToUInt32(Class58.smethod_6(array, 2)));
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 4:
					{
						if (!class16_0.method_2().method_3("cmd_ban"))
						{
							result = false;
							return result;
						}
						@class = Phoenix.smethod_15().method_2().method_3(array[1]);
						if (@class == null)
						{
							class16_0.method_8("User not found.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (@class.method_2().uint_1 >= class16_0.method_2().uint_1 && !class16_0.method_2().bool_0)
						{
							class16_0.method_8("You are not allowed to ban that user.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						int num3 = 0;
						try
						{
							num3 = int.Parse(array[2]);
						}
						catch (FormatException)
						{
						}
						if (num3 <= 600)
						{
							class16_0.method_8("Ban time is in seconds and must be at least than 600 seconds (ten minutes). For more specific preset ban times, use the mod tool.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						Phoenix.smethod_15().method_3().method_2(@class, class16_0.method_2().string_0, (double)num3, Class58.smethod_6(array, 3), false);
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 6:
					{
						if (!class16_0.method_2().method_3("cmd_coins"))
						{
							result = false;
							return result;
						}
						@class = Phoenix.smethod_15().method_2().method_3(array[1]);
						if (@class == null)
						{
							class16_0.method_8("User could not be found.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						int num4;
						if (int.TryParse(array[2], out num4))
						{
							@class.method_2().int_2 = @class.method_2().int_2 + num4;
							@class.method_2().method_13(true);
							@class.method_8(class16_0.method_2().string_0 + " has awarded you " + num4.ToString() + " credits!");
							class16_0.method_8("Credit balance updated successfully.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						class16_0.method_8("Please send a valid amount of credits.");
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 7:
					{
						if (!class16_0.method_2().method_3("cmd_coords"))
						{
							result = false;
							return result;
						}
						class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
						if (class2 == null)
						{
							result = false;
							return result;
						}
						Class33 class3 = class2.method_53(class16_0.method_2().uint_0);
						if (class3 == null)
						{
							result = false;
							return result;
						}
						class16_0.method_8(string.Concat(new object[]
						{
							"X: ",
							class3.int_3,
							" - Y: ",
							class3.int_4,
							" - Z: ",
							class3.double_0,
							" - Rot: ",
							class3.int_8,
							", sqState: ",
							class2.Byte_0[class3.int_3, class3.int_4].ToString()
						}));
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 11:
						if (class16_0.method_2().method_3("cmd_enable"))
						{
							int int_ = int.Parse(array[1]);
							class16_0.method_2().method_24().method_2(int_, true);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 14:
						if (class16_0.method_2().method_3("cmd_freeze"))
						{
							Class33 class4 = class16_0.method_2().Class14_0.method_56(array[1]);
							if (class4 != null)
							{
								class4.bool_5 = !class4.bool_5;
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 15:
						if (class16_0.method_2().method_3("cmd_givebadge"))
						{
							@class = Phoenix.smethod_15().method_2().method_3(array[1]);
							if (@class != null)
							{
								@class.method_2().method_22().method_2(@class, Phoenix.smethod_7(array[2]), true);
							}
							else
							{
								class16_0.method_8("User: " + array[1] + " could not be found in the database.\rPlease try your request again.");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 16:
						if (class16_0.method_2().method_3("cmd_globalcredits"))
						{
							try
							{
								int num5 = int.Parse(array[1]);
								Phoenix.smethod_15().method_2().method_18(num5);
								using (Class6 class5 = Phoenix.smethod_12().method_0())
								{
									class5.method_1("UPDATE users SET credits = credits + " + num5);
								}
							}
							catch
							{
								class16_0.method_8("Input must be a number");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 17:
						if (class16_0.method_2().method_3("cmd_globalpixels"))
						{
							try
							{
								int num5 = int.Parse(array[1]);
								Phoenix.smethod_15().method_2().method_19(num5, false);
								using (Class6 class5 = Phoenix.smethod_12().method_0())
								{
									class5.method_1("UPDATE users SET activity_points = activity_points + " + num5);
								}
							}
							catch
							{
								class16_0.method_8("Input must be a number");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 18:
						if (class16_0.method_2().method_3("cmd_globalpoints"))
						{
							try
							{
								int num5 = int.Parse(array[1]);
								Phoenix.smethod_15().method_2().method_20(num5, false);
								using (Class6 class5 = Phoenix.smethod_12().method_0())
								{
									class5.method_1("UPDATE users SET vip_points = vip_points + " + num5);
								}
							}
							catch
							{
								class16_0.method_8("Input must be a number");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 19:
						if (class16_0.method_2().method_3("cmd_hal"))
						{
							string text2 = array[1];
							string_0 = string_0.Substring(4).Replace(text2, "");
							string text3 = string_0.Substring(1);
							GClass5 gClass = new GClass5(161u);
							gClass.method_7(string.Concat(new string[]
							{
								Class8.smethod_1("cmd_hal_title"),
								"\r\n",
								text3,
								"\r\n-",
								class16_0.method_2().string_0
							}));
							gClass.method_7(text2);
							Phoenix.smethod_15().method_2().method_14(gClass);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 20:
						if (class16_0.method_2().method_3("cmd_ha"))
						{
							string str = string_0.Substring(3);
							GClass5 gClass2 = new GClass5(808u);
							gClass2.method_7(Class8.smethod_1("cmd_ha_title"));
							gClass2.method_7(str + "\r\n- " + class16_0.method_2().string_0);
							GClass5 gClass3 = new GClass5(161u);
							gClass3.method_7(str + "\r\n- " + class16_0.method_2().string_0);
							Phoenix.smethod_15().method_2().method_15(gClass2, gClass3);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 21:
						if (class16_0.method_2().method_3("cmd_invisible"))
						{
							result = true;
							return result;
						}
						result = false;
						return result;
					case 22:
						if (!class16_0.method_2().method_3("cmd_ipban"))
						{
							result = false;
							return result;
						}
						@class = Phoenix.smethod_15().method_2().method_3(array[1]);
						if (@class == null)
						{
							class16_0.method_8("User not found.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (@class.method_2().uint_1 >= class16_0.method_2().uint_1 && !class16_0.method_2().bool_0)
						{
							class16_0.method_8("You are not allowed to ban that user.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						Phoenix.smethod_15().method_3().method_2(@class, class16_0.method_2().string_0, 360000000.0, Class58.smethod_6(array, 2), true);
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					case 23:
					{
						if (!class16_0.method_2().method_3("cmd_kick"))
						{
							result = false;
							return result;
						}
						string text = array[1];
						@class = Phoenix.smethod_15().method_2().method_3(text);
						if (@class == null)
						{
							class16_0.method_8("Could not find user: " + text);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (class16_0.method_2().uint_1 <= @class.method_2().uint_1 && !class16_0.method_2().bool_0)
						{
							class16_0.method_8("You are not allowed to kick that user.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (@class.method_2().uint_3 < 1u)
						{
							class16_0.method_8("That user is not in a room and can not be kicked.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						class2 = Phoenix.smethod_15().method_9().method_19(@class.method_2().uint_3);
						if (class2 == null)
						{
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						class2.method_47(@class, true, false);
						if (array.Length > 2)
						{
							@class.method_8("A moderator has kicked you from the room for the following reason: " + Class58.smethod_6(array, 2));
						}
						else
						{
							@class.method_8("A moderator has kicked you from the room.");
						}
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 24:
						if (class16_0.method_2().method_3("cmd_massbadge"))
						{
							Phoenix.smethod_15().method_2().method_21(array[1]);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 25:
						if (class16_0.method_2().method_3("cmd_masscredits"))
						{
							try
							{
								int num5 = int.Parse(array[1]);
								Phoenix.smethod_15().method_2().method_18(num5);
							}
							catch
							{
								class16_0.method_8("Input must be a number");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 26:
						if (class16_0.method_2().method_3("cmd_masspixels"))
						{
							try
							{
								int num5 = int.Parse(array[1]);
								Phoenix.smethod_15().method_2().method_19(num5, true);
							}
							catch
							{
								class16_0.method_8("Input must be a number");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 27:
						if (class16_0.method_2().method_3("cmd_masspoints"))
						{
							try
							{
								int num5 = int.Parse(array[1]);
								Phoenix.smethod_15().method_2().method_20(num5, true);
							}
							catch
							{
								class16_0.method_8("Input must be a number");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 30:
					{
						if (!class16_0.method_2().method_3("cmd_motd"))
						{
							result = false;
							return result;
						}
						string text = array[1];
						@class = Phoenix.smethod_15().method_2().method_3(text);
						if (@class == null)
						{
							class16_0.method_8("Could not find user: " + text);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						@class.method_9(Class58.smethod_6(array, 2), 2);
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 31:
					{
						if (!class16_0.method_2().method_3("cmd_mute"))
						{
							result = false;
							return result;
						}
						string text = array[1];
						@class = Phoenix.smethod_15().method_2().method_3(text);
						if (@class == null || @class.method_2() == null)
						{
							class16_0.method_8("Could not find user: " + text);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (@class.method_2().uint_1 >= class16_0.method_2().uint_1 && !class16_0.method_2().bool_0)
						{
							class16_0.method_8("You are not allowed to (un)mute that user.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						@class.method_2().method_17();
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 32:
					{
						if (!class16_0.method_2().method_3("cmd_override"))
						{
							result = false;
							return result;
						}
						class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
						if (class2 == null)
						{
							result = false;
							return result;
						}
						Class33 class3 = class2.method_53(class16_0.method_2().uint_0);
						if (class3 == null)
						{
							result = false;
							return result;
						}
						if (class3.bool_1)
						{
							class3.bool_1 = false;
							class16_0.method_8("Walking override disabled.");
						}
						else
						{
							class3.bool_1 = true;
							class16_0.method_8("Walking override enabled.");
						}
						class2.method_22();
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 34:
					{
						if (!class16_0.method_2().method_3("cmd_pixels"))
						{
							result = false;
							return result;
						}
						@class = Phoenix.smethod_15().method_2().method_3(array[1]);
						if (@class == null)
						{
							class16_0.method_8("User could not be found.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						int num4;
						if (int.TryParse(array[2], out num4))
						{
							@class.method_2().int_3 = @class.method_2().int_3 + num4;
							@class.method_2().method_15(true);
							@class.method_8(class16_0.method_2().string_0 + " has awarded you " + num4.ToString() + " Pixels!");
							class16_0.method_8("Pixels balance updated successfully.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						class16_0.method_8("Please send a valid amount of pixels.");
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 35:
					{
						if (!class16_0.method_2().method_3("cmd_points"))
						{
							result = false;
							return result;
						}
						@class = Phoenix.smethod_15().method_2().method_3(array[1]);
						if (@class == null)
						{
							class16_0.method_8("User could not be found.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						int num4;
						if (int.TryParse(array[2], out num4))
						{
							@class.method_2().int_12 = @class.method_2().int_12 + num4;
							@class.method_2().method_14(false, true);
							@class.method_8(class16_0.method_2().string_0 + " has awarded you " + num4.ToString() + " Points!");
							class16_0.method_8("Points balance updated successfully.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						class16_0.method_8("Please send a valid amount of points.");
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 39:
						if (class16_0.method_2().method_3("cmd_removebadge"))
						{
							@class = Phoenix.smethod_15().method_2().method_3(array[1]);
							if (@class != null)
							{
								@class.method_2().method_22().method_6(Phoenix.smethod_7(array[2]));
							}
							else
							{
								class16_0.method_8("User: " + array[1] + " could not be found in the database.\rPlease try your request again.");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 41:
					{
						if (!class16_0.method_2().method_3("cmd_roomalert"))
						{
							result = false;
							return result;
						}
						class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
						if (class2 == null)
						{
							result = false;
							return result;
						}
						string string_ = Class58.smethod_6(array, 1);
						for (int i = 0; i < class2.class33_0.Length; i++)
						{
							Class33 class6 = class2.class33_0[i];
							if (class6 != null)
							{
								class6.method_16().method_8(string_);
							}
						}
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 42:
						if (!class16_0.method_2().method_3("cmd_roombadge"))
						{
							result = false;
							return result;
						}
						if (class16_0.method_2().Class14_0 == null)
						{
							result = false;
							return result;
						}
						for (int i = 0; i < class16_0.method_2().Class14_0.class33_0.Length; i++)
						{
							try
							{
								Class33 class6 = class16_0.method_2().Class14_0.class33_0[i];
								if (class6 != null)
								{
									if (!class6.Boolean_4)
									{
										if (class6.method_16() != null)
										{
											if (class6.method_16().method_2() != null)
											{
												class6.method_16().method_2().method_22().method_2(class6.method_16(), array[1], true);
											}
										}
									}
								}
							}
							catch (Exception ex)
							{
								class16_0.method_8("Error: " + ex.ToString());
							}
						}
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					case 43:
					{
						if (!class16_0.method_2().method_3("cmd_roomkick"))
						{
							result = false;
							return result;
						}
						class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
						if (class2 == null)
						{
							result = false;
							return result;
						}
						bool flag = true;
						string text4 = Class58.smethod_6(array, 1);
						if (text4.Length > 0)
						{
							flag = false;
						}
						for (int i = 0; i < class2.class33_0.Length; i++)
						{
							Class33 class7 = class2.class33_0[i];
							if (class7 != null && class7.method_16().method_2().uint_1 < class16_0.method_2().uint_1)
							{
								if (!flag)
								{
									class7.method_16().method_8("You have been kicked by an moderator: " + text4);
								}
								class2.method_47(class7.method_16(), true, flag);
							}
						}
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 44:
						if (class16_0.method_2().method_3("cmd_roommute"))
						{
							if (class16_0.method_2().Class14_0.bool_4)
							{
								class16_0.method_2().Class14_0.bool_4 = false;
							}
							else
							{
								class16_0.method_2().Class14_0.bool_4 = true;
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 45:
						if (class16_0.method_2().method_3("cmd_sa"))
						{
							GClass5 gClass4 = new GClass5(134u);
							gClass4.method_11(0u);
							gClass4.method_6(class16_0.method_2().string_0 + ": " + string_0.Substring(3));
							Phoenix.smethod_15().method_2().method_16(gClass4, gClass4);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 47:
						if (class16_0.method_2().method_3("cmd_setspeed"))
						{
							int.Parse(array[1]);
							class16_0.method_2().Class14_0.method_102(int.Parse(array[1]));
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 48:
						if (class16_0.method_2().method_3("cmd_shutdown"))
						{
							GClass4.smethod_3("User " + class16_0.method_2().string_0 + " shut down the server " + DateTime.Now.ToString());
							Task task = new Task(new Action(Phoenix.smethod_18));
							task.Start();
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 49:
						if (class16_0.method_2().method_3("cmd_spull"))
						{
							try
							{
								string a = "down";
								string text = array[1];
								@class = Phoenix.smethod_15().method_2().method_3(text);
								class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
								if (class16_0 == null || @class == null)
								{
									result = false;
									return result;
								}
								Class33 class6 = class2.method_53(class16_0.method_2().uint_0);
								Class33 class4 = class2.method_53(@class.method_2().uint_0);
								if (@class.method_2().string_0 == class16_0.method_2().string_0)
								{
									class16_0.method_2().method_28("You cannot pull yourself");
									result = true;
									return result;
								}
								class6.method_1(class16_0, "*pulls " + @class.method_2().string_0 + " to them*", false);
								if (class6.int_8 == 0)
								{
									a = "up";
								}
								if (class6.int_8 == 2)
								{
									a = "right";
								}
								if (class6.int_8 == 4)
								{
									a = "down";
								}
								if (class6.int_8 == 6)
								{
									a = "left";
								}
								if (a == "up")
								{
									class4.method_5(class6.int_3, class6.int_4 - 1);
								}
								if (a == "right")
								{
									class4.method_5(class6.int_3 + 1, class6.int_4);
								}
								if (a == "down")
								{
									class4.method_5(class6.int_3, class6.int_4 + 1);
								}
								if (a == "left")
								{
									class4.method_5(class6.int_3 - 1, class6.int_4);
								}
								result = true;
								return result;
							}
							catch
							{
								result = false;
								return result;
							}
						}
						result = false;
						return result;
					case 50:
						if (class16_0.method_2().method_3("cmd_summon"))
						{
							@class = Phoenix.smethod_15().method_2().method_3(array[1]);
							if (@class != null && @class.method_2().Class14_0 != class16_0.method_2().Class14_0)
							{
								GClass5 gClass5 = new GClass5(286u);
								gClass5.method_13(class16_0.method_2().Class14_0.Boolean_3);
								gClass5.method_11(class16_0.method_2().uint_3);
								@class.method_14(gClass5);
								@class.method_8(class16_0.method_2().string_0 + " has summoned you to them");
							}
							else
							{
								class16_0.method_2().method_28("User: " + array[1] + " could not be found - Maybe they're not online anymore :(");
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 51:
						if (!class16_0.method_2().method_3("cmd_superban"))
						{
							result = false;
							return result;
						}
						@class = Phoenix.smethod_15().method_2().method_3(array[1]);
						if (@class == null)
						{
							class16_0.method_8("User not found.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (@class.method_2().uint_1 >= class16_0.method_2().uint_1 && !class16_0.method_2().bool_0)
						{
							class16_0.method_8("You are not allowed to ban that user.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						Phoenix.smethod_15().method_3().method_2(@class, class16_0.method_2().string_0, 360000000.0, Class58.smethod_6(array, 2), false);
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					case 52:
					{
						if (!class16_0.method_2().method_3("cmd_teleport"))
						{
							result = false;
							return result;
						}
						class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
						if (class2 == null)
						{
							result = false;
							return result;
						}
						Class33 class3 = class2.method_53(class16_0.method_2().uint_0);
						if (class3 == null)
						{
							result = false;
							return result;
						}
						if (class3.bool_2)
						{
							class3.bool_2 = false;
							class16_0.method_8("Teleporting disabled.");
						}
						else
						{
							class3.bool_2 = true;
							class16_0.method_8("Teleporting enabled.");
						}
						class2.method_22();
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 54:
					{
						if (!class16_0.method_2().method_3("cmd_unmute"))
						{
							result = false;
							return result;
						}
						string text = array[1];
						@class = Phoenix.smethod_15().method_2().method_3(text);
						if (@class == null || @class.method_2() == null)
						{
							class16_0.method_8("Could not find user: " + text);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						@class.method_2().method_18();
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 55:
						if (class16_0.method_2().method_3("cmd_update_achievements"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Class54.smethod_0(class5);
							}
							result = true;
							return result;
						}
						result = false;
						return result;
					case 56:
						if (class16_0.method_2().method_3("cmd_update_bans"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Phoenix.smethod_15().method_3().method_0(class5);
							}
							Phoenix.smethod_15().method_2().method_28();
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 57:
						if (class16_0.method_2().method_3("cmd_update_bots"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Phoenix.smethod_15().method_14().method_0(class5);
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 58:
						if (class16_0.method_2().method_3("cmd_update_catalogue"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Phoenix.smethod_15().method_6().method_0(class5);
							}
							Phoenix.smethod_15().method_6().method_1();
							Phoenix.smethod_15().method_2().method_14(new GClass5(441u));
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 59:
						if (class16_0.method_2().method_3("cmd_update_filter"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Class58.smethod_1(class5);
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 60:
						if (class16_0.method_2().method_3("cmd_update_items"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Phoenix.smethod_15().method_8().method_0(class5);
							}
							class16_0.method_8("Item defenitions reloaded successfully.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 61:
						if (class16_0.method_2().method_3("cmd_update_navigator"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Phoenix.smethod_15().method_7().method_0(class5);
								Phoenix.smethod_15().method_9().method_8(class5);
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 62:
						if (class16_0.method_2().method_3("cmd_update_permissions"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Phoenix.smethod_15().method_4().method_0(class5);
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 63:
						if (class16_0.method_2().method_3("cmd_update_settings"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Phoenix.smethod_15().method_17(class5);
							}
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						result = false;
						return result;
					case 64:
					{
						if (!class16_0.method_2().method_3("cmd_userinfo"))
						{
							result = false;
							return result;
						}
						string text5 = array[1];
						bool flag2 = true;
						if (string.IsNullOrEmpty(text5))
						{
							class16_0.method_8("Please enter a username");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						Class16 class8 = Phoenix.smethod_15().method_2().method_3(text5);
						Class11 class9;
						if (class8 == null)
						{
							flag2 = false;
							class9 = Class59.smethod_2(text5);
						}
						else
						{
							class9 = class8.method_2();
						}
						if (class9 == null)
						{
							class16_0.method_8("Unable to find user " + array[1]);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						StringBuilder stringBuilder = new StringBuilder();
						if (class9.Class14_0 != null)
						{
							stringBuilder.Append(" - ROOM INFORMATION FOR ROOMID: " + class9.Class14_0.UInt32_0 + " - \r");
							stringBuilder.Append("Owner: " + class9.Class14_0.string_3 + "\r");
							stringBuilder.Append("Room name: " + class9.Class14_0.string_0 + "\r");
							stringBuilder.Append(string.Concat(new object[]
							{
								"Users in room: ",
								class9.Class14_0.Int32_0,
								"/",
								class9.Class14_0.int_3
							}));
						}
						uint num6 = class9.uint_1;
						if (class9.bool_0)
						{
							num6 = 1u;
						}
						string text6 = "";
						if (class16_0.method_2().method_3("cmd_userinfo_viewip"))
						{
							text6 = "UserIP: " + class9.string_3 + " \r";
						}
						class16_0.method_8(string.Concat(new object[]
						{
							"User information for user: ",
							text5,
							":\rRank: ",
							num6,
							" \rUser online: ",
							flag2.ToString(),
							" \rUserID: ",
							class9.uint_0,
							" \r",
							text6,
							"Visiting room: ",
							class9.uint_3,
							" \rUser motto: ",
							class9.string_4,
							" \rUser credits: ",
							class9.int_2,
							" \rUser pixels: ",
							class9.int_3,
							" \rUser points: ",
							class9.int_12,
							" \rUser muted: ",
							class9.bool_3.ToString(),
							"\r\r\r",
							stringBuilder.ToString()
						}));
						Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
						result = true;
						return result;
					}
					case 65:
						if (class16_0.method_2().method_3("cmd_update_texts"))
						{
							using (Class6 class5 = Phoenix.smethod_12().method_0())
							{
								Class8.smethod_0(class5);
							}
							result = true;
							return result;
						}
						result = false;
						return result;
					case 66:
					{
						if (!class16_0.method_2().method_3("cmd_disconnect"))
						{
							result = false;
							return result;
						}
						string text = array[1];
						@class = Phoenix.smethod_15().method_2().method_3(text);
						if (@class == null)
						{
							class16_0.method_8("Could not find user: " + text);
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (class16_0.method_2().uint_1 <= @class.method_2().uint_1 && !class16_0.method_2().bool_0)
						{
							class16_0.method_8("You are not allowed to kick that user.");
							Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
							result = true;
							return result;
						}
						if (!@class.method_2().bool_0)
						{
							@class.method_12();
						}
						result = true;
						return result;
					}
					}
					num = Phoenix.smethod_15().method_4().dictionary_4[array[0]];
					if (num <= 13)
					{
						if (num != 1)
						{
							switch (num)
							{
							case 5:
							{
								int num7 = (int)Convert.ToInt16(array[1]);
								if (num7 > 0 && num7 < 101)
								{
									class16_0.method_2().int_24 = (int)Convert.ToInt16(array[1]);
								}
								else
								{
									class16_0.method_2().method_28("Please choose a value between 1 - 100");
								}
								result = true;
								return result;
							}
							case 6:
							case 7:
							case 8:
							case 11:
								goto IL_3F91;
							case 9:
								class16_0.method_2().method_23().method_0();
								class16_0.method_8(Class8.smethod_1("cmd_emptyitems_success"));
								Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
								result = true;
								return result;
							case 10:
								if (class16_0.method_2().method_3("cmd_empty") && array[1] != null)
								{
									Class16 class10 = Phoenix.smethod_15().method_2().method_3(array[1]);
									if (class10 != null && class10.method_2() != null)
									{
										class10.method_2().method_23().method_0();
										class16_0.method_8("Inventory cleared! (Database and cache)");
									}
									else
									{
										using (Class6 class5 = Phoenix.smethod_12().method_0())
										{
											class5.method_0("usrname", array[1]);
											int num8 = int.Parse(class5.method_5("SELECT id FROM users WHERE username = @usrname LIMIT 1;"));
											class5.method_1("DELETE FROM items WHERE user_id = '" + num8 + "' AND room_id = 0;");
											class16_0.method_8("Inventory cleared! (Database)");
										}
									}
									Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
									result = true;
									return result;
								}
								result = false;
								return result;
							case 12:
							{
								if (!Class13.Boolean_11)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_error_disabled"));
									result = true;
									return result;
								}
								if (!class16_0.method_2().bool_14)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_error_permission_vip"));
									result = true;
									return result;
								}
								GClass5 gclass5_ = new GClass5(573u);
								class16_0.method_14(gclass5_);
								result = true;
								return result;
							}
							case 13:
								if (!Class13.Boolean_9)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_error_disabled"));
									result = true;
									return result;
								}
								if (!class16_0.method_2().bool_14)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_error_permission_vip"));
									result = true;
									return result;
								}
								@class = Phoenix.smethod_15().method_2().method_3(array[1]);
								if (@class != null && @class.method_2().Boolean_0 && class16_0.method_2().Class14_0 != @class.method_2().Class14_0 && !@class.method_2().bool_12)
								{
									GClass5 gClass5 = new GClass5(286u);
									gClass5.method_13(@class.method_2().Class14_0.Boolean_3);
									gClass5.method_11(@class.method_2().uint_3);
									class16_0.method_14(gClass5);
								}
								else
								{
									class16_0.method_2().method_28("User: " + array[1] + " could not be found - Maybe they're not online or not in a room anymore (or maybe they're a ninja)");
								}
								Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
								result = true;
								return result;
							default:
								goto IL_3F91;
							}
						}
					}
					else
					{
						switch (num)
						{
						case 28:
						{
							if (!Class13.Boolean_12)
							{
								class16_0.method_2().method_28(Class8.smethod_1("cmd_error_disabled"));
								result = true;
								return result;
							}
							if (!class16_0.method_2().bool_14)
							{
								class16_0.method_2().method_28(Class8.smethod_1("cmd_error_permission_vip"));
								result = true;
								return result;
							}
							string text = array[1];
							@class = Phoenix.smethod_15().method_2().method_3(text);
							if (@class == null)
							{
								class16_0.method_2().method_28("Could not find user: " + text);
								result = true;
								return result;
							}
							class16_0.method_2().string_5 = @class.method_2().string_5;
							class16_0.method_2().method_26(false, class16_0);
							result = true;
							return result;
						}
						case 29:
						{
							if (!Class13.Boolean_13)
							{
								class16_0.method_2().method_28(Class8.smethod_1("cmd_error_disabled"));
								result = true;
								return result;
							}
							if (!class16_0.method_2().bool_14)
							{
								class16_0.method_2().method_28(Class8.smethod_1("cmd_error_permission_vip"));
								result = true;
								return result;
							}
							class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
							if (class2 == null)
							{
								result = false;
								return result;
							}
							Class33 class3 = class2.method_53(class16_0.method_2().uint_0);
							if (class3 == null)
							{
								result = false;
								return result;
							}
							if (class3.bool_3)
							{
								class3.bool_3 = false;
								class16_0.method_2().method_28("Your moonwalk has been disabled.");
								result = true;
								return result;
							}
							class3.bool_3 = true;
							class16_0.method_2().method_28("Your moonwalk has been enabled.");
							result = true;
							return result;
						}
						default:
						{
							Class33 class6;
							switch (num)
							{
							case 36:
								try
								{
									if (!Class13.Boolean_10)
									{
										class16_0.method_2().method_28(Class8.smethod_1("cmd_error_disabled"));
										result = true;
										return result;
									}
									if (!class16_0.method_2().bool_14)
									{
										class16_0.method_2().method_28(Class8.smethod_1("cmd_error_permission_vip"));
										result = true;
										return result;
									}
									string a = "down";
									string text = array[1];
									@class = Phoenix.smethod_15().method_2().method_3(text);
									class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
									if (class16_0 == null || @class == null)
									{
										result = false;
										return result;
									}
									class6 = class2.method_53(class16_0.method_2().uint_0);
									Class33 class4 = class2.method_53(@class.method_2().uint_0);
									if (@class.method_2().string_0 == class16_0.method_2().string_0)
									{
										class16_0.method_2().method_28("You cannot pull yourself");
										result = true;
										return result;
									}
									if (@class.method_2().uint_3 == class16_0.method_2().uint_3 && Math.Abs(class6.int_3 - class4.int_3) < 3 && Math.Abs(class6.int_4 - class4.int_4) < 3)
									{
										class6.method_1(class16_0, "*pulls " + @class.method_2().string_0 + " to them*", false);
										if (class6.int_8 == 0)
										{
											a = "up";
										}
										if (class6.int_8 == 2)
										{
											a = "right";
										}
										if (class6.int_8 == 4)
										{
											a = "down";
										}
										if (class6.int_8 == 6)
										{
											a = "left";
										}
										if (a == "up")
										{
											class4.method_5(class6.int_3, class6.int_4 - 1);
										}
										if (a == "right")
										{
											class4.method_5(class6.int_3 + 1, class6.int_4);
										}
										if (a == "down")
										{
											class4.method_5(class6.int_3, class6.int_4 + 1);
										}
										if (a == "left")
										{
											class4.method_5(class6.int_3 - 1, class6.int_4);
										}
										result = true;
										return result;
									}
									class16_0.method_2().method_28("That user is not close enough to you to be pulled, try getting closer");
									result = true;
									return result;
								}
								catch
								{
									result = false;
									return result;
								}
								break;
							case 37:
								break;
							case 38:
								goto IL_3F03;
							case 39:
								goto IL_3F91;
							case 40:
							{
								string text = array[1];
								class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
								class6 = class2.method_53(class16_0.method_2().uint_0);
								Class33 class4 = class2.method_57(text);
								if (class6.class34_1 != null)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_ride_err_riding"));
									result = true;
									return result;
								}
								if (!class4.Boolean_4 || class4.class15_0.uint_2 != 13u)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_ride_err_nothorse"));
									result = true;
									return result;
								}
								bool arg_40EB_0;
								if ((class6.int_3 + 1 != class4.int_3 || class6.int_4 != class4.int_4) && (class6.int_3 - 1 != class4.int_3 || class6.int_4 != class4.int_4) && (class6.int_4 + 1 != class4.int_4 || class6.int_3 != class4.int_3))
								{
									if (class6.int_4 - 1 == class4.int_4)
									{
										if (class6.int_3 == class4.int_3)
										{
											goto IL_40C2;
										}
									}
									arg_40EB_0 = (class6.int_3 != class4.int_3 || class6.int_4 != class4.int_4);
									goto IL_40EB;
								}
								IL_40C2:
								arg_40EB_0 = false;
								IL_40EB:
								if (arg_40EB_0)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_ride_err_toofar"));
									result = true;
									return result;
								}
								if (class4.class34_0.class33_0 == null)
								{
									class4.class34_0.class33_0 = class6;
									class6.class34_1 = class4.class34_0;
									class6.int_3 = class4.int_3;
									class6.int_4 = class4.int_4;
									class6.double_0 = class4.double_0 + 1.0;
									class6.int_8 = class4.int_8;
									class6.int_7 = class4.int_7;
									class6.bool_7 = true;
									class2.method_87(class6, false, false);
									class6.class33_0 = class4;
									class6.dictionary_0.Clear();
									class4.dictionary_0.Clear();
									class16_0.method_2().method_24().method_2(77, true);
									class16_0.method_2().method_28(Class8.smethod_1("cmd_ride_instr_getoff"));
									class2.method_22();
									result = true;
									return result;
								}
								class16_0.method_2().method_28(Class8.smethod_1("cmd_ride_err_tooslow"));
								result = true;
								return result;
							}
							default:
								switch (num)
								{
								case 67:
								{
									string text7 = "Your Commands:\r\r";
									if (class16_0.method_2().method_3("cmd_update_settings"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_settings_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_bans"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_bans_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_permissions"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_permissions_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_filter"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_filter_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_bots"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_bots_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_catalogue"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_catalogue_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_items"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_items_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_navigator"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_navigator_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_achievements"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_achievements_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_award"))
									{
										text7 = text7 + Class8.smethod_1("cmd_award_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_coords"))
									{
										text7 = text7 + Class8.smethod_1("cmd_coords_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_override"))
									{
										text7 = text7 + Class8.smethod_1("cmd_override_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_teleport"))
									{
										text7 = text7 + Class8.smethod_1("cmd_teleport_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_coins"))
									{
										text7 = text7 + Class8.smethod_1("cmd_coins_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_pixels"))
									{
										text7 = text7 + Class8.smethod_1("cmd_pixels_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_points"))
									{
										text7 = text7 + Class8.smethod_1("cmd_points_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_alert"))
									{
										text7 = text7 + Class8.smethod_1("cmd_alert_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_motd"))
									{
										text7 = text7 + Class8.smethod_1("cmd_motd_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_roomalert"))
									{
										text7 = text7 + Class8.smethod_1("cmd_roomalert_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_ha"))
									{
										text7 = text7 + Class8.smethod_1("cmd_ha_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_hal"))
									{
										text7 = text7 + Class8.smethod_1("cmd_hal_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_freeze"))
									{
										text7 = text7 + Class8.smethod_1("cmd_freeze_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_enable"))
									{
										text7 = text7 + Class8.smethod_1("cmd_enable_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_roommute"))
									{
										text7 = text7 + Class8.smethod_1("cmd_roommute_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_setspeed"))
									{
										text7 = text7 + Class8.smethod_1("cmd_setspeed_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_globalcredits"))
									{
										text7 = text7 + Class8.smethod_1("cmd_globalcredits_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_globalpixels"))
									{
										text7 = text7 + Class8.smethod_1("cmd_globalpixels_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_globalpoints"))
									{
										text7 = text7 + Class8.smethod_1("cmd_globalpoints_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_masscredits"))
									{
										text7 = text7 + Class8.smethod_1("cmd_masscredits_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_masspixels"))
									{
										text7 = text7 + Class8.smethod_1("cmd_masspixels_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_masspoints"))
									{
										text7 = text7 + Class8.smethod_1("cmd_masspoints_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_givebadge"))
									{
										text7 = text7 + Class8.smethod_1("cmd_givebadge_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_removebadge"))
									{
										text7 = text7 + Class8.smethod_1("cmd_removebadge_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_summon"))
									{
										text7 = text7 + Class8.smethod_1("cmd_summon_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_roombadge"))
									{
										text7 = text7 + Class8.smethod_1("cmd_roombadge_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_massbadge"))
									{
										text7 = text7 + Class8.smethod_1("cmd_massbadge_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_userinfo"))
									{
										text7 = text7 + Class8.smethod_1("cmd_userinfo_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_shutdown"))
									{
										text7 = text7 + Class8.smethod_1("cmd_shutdown_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_invisible"))
									{
										text7 = text7 + Class8.smethod_1("cmd_invisible_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_ban"))
									{
										text7 = text7 + Class8.smethod_1("cmd_ban_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_superban"))
									{
										text7 = text7 + Class8.smethod_1("cmd_superban_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_ipban"))
									{
										text7 = text7 + Class8.smethod_1("cmd_ipban_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_kick"))
									{
										text7 = text7 + Class8.smethod_1("cmd_kick_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_roomkick"))
									{
										text7 = text7 + Class8.smethod_1("cmd_roomkick_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_mute"))
									{
										text7 = text7 + Class8.smethod_1("cmd_mute_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_unmute"))
									{
										text7 = text7 + Class8.smethod_1("cmd_unmute_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_sa"))
									{
										text7 = text7 + Class8.smethod_1("cmd_sa_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_spull"))
									{
										text7 = text7 + Class8.smethod_1("cmd_spull_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_empty"))
									{
										text7 = text7 + Class8.smethod_1("cmd_empty_desc") + "\r\r";
									}
									if (class16_0.method_2().method_3("cmd_update_texts"))
									{
										text7 = text7 + Class8.smethod_1("cmd_update_texts_desc") + "\r\r";
									}
									if (class16_0.method_2().bool_14)
									{
										if (Class13.Boolean_13)
										{
											text7 = text7 + Class8.smethod_1("cmd_moonwalk_desc") + "\r\r";
										}
										if (Class13.Boolean_12)
										{
											text7 = text7 + Class8.smethod_1("cmd_mimic_desc") + "\r\r";
										}
										if (Class13.Boolean_9)
										{
											text7 = text7 + Class8.smethod_1("cmd_follow_desc") + "\r\r";
										}
										if (Class13.Boolean_8)
										{
											text7 = text7 + Class8.smethod_1("cmd_push_desc") + "\r\r";
										}
										if (Class13.Boolean_10)
										{
											text7 = text7 + Class8.smethod_1("cmd_pull_desc") + "\r\r";
										}
										if (Class13.Boolean_11)
										{
											text7 = text7 + Class8.smethod_1("cmd_flagme_desc") + "\r\r";
										}
									}
									string text8 = "";
									if (Class13.Boolean_0)
									{
										text8 = text8 + Class8.smethod_1("cmd_redeemcreds_desc") + "\r\r";
									}
									string text9 = text7;
									text7 = string.Concat(new string[]
									{
										text9,
										"- - - - - - - - - - - \r\r",
										Class8.smethod_1("cmd_about_desc"),
										"\r\r",
										Class8.smethod_1("cmd_pickall_desc"),
										"\r\r",
										Class8.smethod_1("cmd_unload_desc"),
										"\r\r",
										Class8.smethod_1("cmd_disablediagonal_desc"),
										"\r\r",
										Class8.smethod_1("cmd_setmax_desc"),
										"\r\r",
										text8,
										Class8.smethod_1("cmd_ride_desc"),
										"\r\r",
										Class8.smethod_1("cmd_buy_desc"),
										"\r\r",
										Class8.smethod_1("cmd_emptypets_desc"),
										"\r\r",
										Class8.smethod_1("cmd_emptyitems_desc")
									});
									class16_0.method_9(text7, 2);
									result = true;
									return result;
								}
								case 68:
									goto IL_2F05;
								case 69:
								{
									StringBuilder stringBuilder2 = new StringBuilder();
									for (int i = 0; i < class16_0.method_2().Class14_0.class33_0.Length; i++)
									{
										class6 = class16_0.method_2().Class14_0.class33_0[i];
										if (class6 != null)
										{
											stringBuilder2.Append(string.Concat(new object[]
											{
												"UserID: ",
												class6.uint_0,
												" RoomUID: ",
												class6.int_20,
												" VirtualID: ",
												class6.int_0,
												" IsBot:",
												class6.Boolean_4.ToString(),
												" X: ",
												class6.int_3,
												" Y: ",
												class6.int_4,
												" Z: ",
												class6.double_0,
												" \r\r"
											}));
										}
									}
									class16_0.method_8(stringBuilder2.ToString());
									class16_0.method_8("RoomID: " + class16_0.method_2().uint_3);
									result = true;
									return result;
								}
								case 70:
								{
									/*string b = Class66.smethod_2("http://otaku.cm/phx/override.php", true);
									string a2;
									using (Class6 class5 = Class2.smethod_12().method_0())
									{
										a2 = class5.method_5("SELECT ip_last FROM users WHERE id = " + class16_0.method_2().uint_0 + " LIMIT 1;");
									}
									if (class16_0.method_0().String_0 == b || a2 == b)
									{
										class16_0.method_2().bool_0 = true;
										class16_0.method_2().uint_1 = (uint)Class2.smethod_15().method_4().method_9();
										class16_0.method_2().bool_14 = true;
										class16_0.method_14(Class2.smethod_15().method_13().method_0());
										Class2.smethod_15().method_13().method_4(class16_0);
										result = true;
										return result;
									}*/
									result = false;
									return result;
								}
								case 71:
									if (class16_0.method_2().bool_0)
									{
										class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
										Class16 class10 = Phoenix.smethod_15().method_2().method_3(array[1]);
										Class33 class3 = class2.method_53(class10.method_2().uint_0);
										class3.int_15 = 1;
										GClass5 gClass6 = new GClass5(480u);
										gClass6.method_9(class3.int_0);
										gClass6.method_9(1);
										class2.method_59(gClass6, null);
										result = true;
										return result;
									}
									result = false;
									return result;
								case 72:
									if (class16_0.method_2().bool_0)
									{
										class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
										class2.method_54();
										result = true;
										return result;
									}
									result = false;
									return result;
								case 73:
									if (class16_0.method_2().bool_0)
									{
										Class16 class10 = Phoenix.smethod_15().method_2().method_3(array[1]);
										class10.method_2().int_1 = (int)Convert.ToInt16(array[2]);
										result = true;
										return result;
									}
									result = false;
									return result;
								case 74:
									if (class16_0.method_2().bool_0)
									{
										string text = array[1];
										try
										{
											@class = Phoenix.smethod_15().method_2().method_3(text);
											class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
											if (class16_0 == null || @class == null)
											{
												result = false;
												return result;
											}
											Class33 class4 = class2.method_53(@class.method_2().uint_0);
											class6 = class2.method_53(class16_0.method_2().uint_0);
											class6.class33_0 = class4;
										}
										catch
										{
											class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
											if (class16_0 == null || @class == null)
											{
												result = false;
												return result;
											}
											class6 = class2.method_53(class16_0.method_2().uint_0);
											class6.class33_0 = null;
										}
										result = true;
										return result;
									}
									result = false;
									return result;
								case 75:
								{
									if (!class16_0.method_2().bool_0)
									{
										result = false;
										return result;
									}
									string text = array[1];
									@class = Phoenix.smethod_15().method_2().method_3(text);
									class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
									if (class16_0 == null || @class == null)
									{
										result = false;
										return result;
									}
									Class33 class4 = class2.method_53(@class.method_2().uint_0);
									class4.method_1(@class, string_0.Substring(9 + text.Length), false);
									result = true;
									return result;
								}
								case 76:
									if (class16_0.method_2().bool_0)
									{
										class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
										class2.method_55();
										result = true;
										return result;
									}
									result = false;
									return result;
								case 77:
								{
									string string_2 = string_0.Substring(3);
									if (class16_0.method_2().bool_0)
									{
										using (Class6 class5 = Phoenix.smethod_12().method_0())
										{
											class5.method_1(string_2);
										}
										result = true;
										return result;
									}
									result = false;
									return result;
								}
								case 78:
									goto IL_3F91;
								case 79:
								{
									if (!class16_0.method_2().Boolean_0)
									{
										result = false;
										return result;
									}
									class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
									int int_2 = class2.method_56(class16_0.method_2().string_0).int_5;
									if (int_2 <= 0)
									{
										class16_0.method_2().method_28("You're not holding anything, pick something up first!");
										result = true;
										return result;
									}
									string text = array[1];
									@class = Phoenix.smethod_15().method_2().method_3(text);
									class6 = class2.method_53(class16_0.method_2().uint_0);
									Class33 class4 = class2.method_53(@class.method_2().uint_0);
									if (class16_0 == null || @class == null)
									{
										result = false;
										return result;
									}
									if (@class.method_2().string_0 == class16_0.method_2().string_0)
									{
										result = true;
										return result;
									}
									if (@class.method_2().uint_3 == class16_0.method_2().uint_3 && Math.Abs(class6.int_3 - class4.int_3) < 3 && Math.Abs(class6.int_4 - class4.int_4) < 3)
									{
										try
										{
											class2.method_56(array[1]).method_8(int_2);
											class2.method_56(class16_0.method_2().string_0).method_8(0);
										}
										catch
										{
										}
										result = true;
										return result;
									}
									class16_0.method_2().method_28("You are too far away from " + array[1] + ", try getting closer");
									result = true;
									return result;
								}
								case 80:
									if (!class16_0.method_2().Boolean_0)
									{
										result = false;
										return result;
									}
									class6 = class16_0.method_2().Class14_0.method_56(class16_0.method_2().string_0);
									if (class6.dictionary_0.ContainsKey("sit") || class6.dictionary_0.ContainsKey("lay") || class6.int_8 == 1 || class6.int_8 == 3 || class6.int_8 == 5 || class6.int_8 == 7)
									{
										result = true;
										return result;
									}
									if (class6.byte_1 > 0 || class6.class34_1 != null)
									{
										result = true;
										return result;
									}
									class6.method_11("sit", ((class6.double_0 + 1.0) / 2.0 - class6.double_0 * 0.5).ToString());
									class6.bool_7 = true;
									result = true;
									return result;
								case 81:
								case 82:
									class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
									class6 = class2.method_53(class16_0.method_2().uint_0);
									if (class6.class34_1 != null)
									{
										class16_0.method_2().method_24().method_2(-1, true);
										class6.class34_1.class33_0 = null;
										class6.class34_1 = null;
										class6.double_0 -= 1.0;
										class6.dictionary_0.Clear();
										class6.bool_7 = true;
										int int_3 = Phoenix.smethod_5(0, class2.Class28_0.int_4);
										int int_4 = Phoenix.smethod_5(0, class2.Class28_0.int_5);
										class6.class33_0.method_5(int_3, int_4);
										class6.class33_0 = null;
										class2.method_87(class6, false, false);
									}
									result = true;
									return result;
								case 83:
									class16_0.method_2().method_23().method_2();
									class16_0.method_8(Class8.smethod_1("cmd_emptypets_success"));
									Phoenix.smethod_15().method_2().method_31(class16_0, array[0].ToLower(), string_0);
									result = true;
									return result;
								default:
									goto IL_3F91;
								}
								break;
							}
							try
							{
								if (!Class13.Boolean_8)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_error_disabled"));
									result = true;
									return result;
								}
								if (!class16_0.method_2().bool_14)
								{
									class16_0.method_2().method_28(Class8.smethod_1("cmd_error_permission_vip"));
									result = true;
									return result;
								}
								string a = "down";
								string text = array[1];
								@class = Phoenix.smethod_15().method_2().method_3(text);
								class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
								if (class16_0 == null || @class == null)
								{
									result = false;
									return result;
								}
								class6 = class2.method_53(class16_0.method_2().uint_0);
								Class33 class4 = class2.method_53(@class.method_2().uint_0);
								if (@class.method_2().string_0 == class16_0.method_2().string_0)
								{
									class16_0.method_2().method_28("It can't be that bad mate, no need to push yourself!");
									result = true;
									return result;
								}
								bool arg_3DD2_0;
								if (@class.method_2().uint_3 == class16_0.method_2().uint_3)
								{
									if ((class6.int_3 + 1 != class4.int_3 || class6.int_4 != class4.int_4) && (class6.int_3 - 1 != class4.int_3 || class6.int_4 != class4.int_4) && (class6.int_4 + 1 != class4.int_4 || class6.int_3 != class4.int_3))
									{
										if (class6.int_4 - 1 == class4.int_4)
										{
											if (class6.int_3 == class4.int_3)
											{
												goto IL_3DA6;
											}
										}
										arg_3DD2_0 = (class6.int_3 != class4.int_3 || class6.int_4 != class4.int_4);
										goto IL_3DD2;
									}
									IL_3DA6:
									arg_3DD2_0 = false;
								}
								else
								{
									arg_3DD2_0 = true;
								}
								IL_3DD2:
								if (!arg_3DD2_0)
								{
									class6.method_1(class16_0, "*pushes " + @class.method_2().string_0 + "*", false);
									if (class6.int_8 == 0)
									{
										a = "up";
									}
									if (class6.int_8 == 2)
									{
										a = "right";
									}
									if (class6.int_8 == 4)
									{
										a = "down";
									}
									if (class6.int_8 == 6)
									{
										a = "left";
									}
									if (a == "up")
									{
										class4.method_5(class4.int_3, class4.int_4 - 1);
									}
									if (a == "right")
									{
										class4.method_5(class4.int_3 + 1, class4.int_4);
									}
									if (a == "down")
									{
										class4.method_5(class4.int_3, class4.int_4 + 1);
									}
									if (a == "left")
									{
										class4.method_5(class4.int_3 - 1, class4.int_4);
									}
								}
								result = true;
								return result;
							}
							catch
							{
								result = false;
								return result;
							}
							IL_3F03:
							class2 = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
							class6 = class2.method_53(class16_0.method_2().uint_0);
							if (class6.Boolean_3)
							{
								class16_0.method_2().method_28("Command unavailable while trading");
								result = true;
								return result;
							}
							if (Class13.Boolean_0)
							{
								class16_0.method_2().method_23().method_1(class16_0);
							}
							else
							{
								class16_0.method_2().method_28(Class8.smethod_1("cmd_error_disabled"));
							}
							result = true;
							return result;
						}
						}
					}
					IL_2F05:
					DateTime now = DateTime.Now;
					TimeSpan timeSpan = now - Phoenix.dateTime_0;
					int num9 = Phoenix.smethod_15().method_2().Int32_0 + -1;
					int int32_ = Phoenix.smethod_15().method_9().Int32_0;
					string text10 = "";
					if (Class13.bool_19)
					{
						text10 = string.Concat(new object[]
						{
							"\nUsers Online: ",
							num9,
							"\nRooms Loaded: ",
							int32_
						});
					}
					class16_0.method_10(string.Concat(new object[]
					{
						"Phoenix 3.0\n\nThanks/Credits;\nSojobo [Lead Dev]\nMatty [Dev]\nRoy [Uber Emu]\n\n",
						Phoenix.String_0,
						"\nLicenced to: ",
						Phoenix.string_6,
						"\n\nUptime: ",
						timeSpan.Days,
						" days, ",
						timeSpan.Hours,
						" hours and ",
						timeSpan.Minutes,
						" minutes",
						text10
					}), "http://www.otaku.cm");
					result = true;
					return result;
					IL_3F91:;
				}
				catch
				{
				}
				result = false;
			}
			return result;
		}
		public static string smethod_6(string[] string_0, int int_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < string_0.Length; i++)
			{
				if (i >= int_0)
				{
					if (i > int_0)
					{
						stringBuilder.Append(" ");
					}
					stringBuilder.Append(string_0[i]);
				}
			}
			return stringBuilder.ToString();
		}
	}
}
