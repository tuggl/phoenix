using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns0
{
	internal sealed class Class258 : Interface0
	{
		[CompilerGenerated]
		private static Func<Class14, int> func_0;
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			string text = Phoenix.smethod_8(class18_0.method_9(), false, true);
			if (text.Length < 3)
			{
				GClass5 gClass = new GClass5(571u);
				gClass.method_6("J");
				class16_0.method_14(gClass);
			}
			else
			{
				if (text.Length > 15)
				{
					GClass5 gClass = new GClass5(571u);
					gClass.method_6("K");
					class16_0.method_14(gClass);
				}
				else
				{
					if (text.Contains(" ") || !class16_0.method_1().method_8(text) || text != Class58.smethod_4(text))
					{
						GClass5 gClass = new GClass5(571u);
						gClass.method_6("QA");
						class16_0.method_14(gClass);
					}
					else
					{
						if (class18_0.String_0 == "GW")
						{
							GClass5 gClass = new GClass5(571u);
							gClass.method_6("H");
							gClass.method_6(text);
							class16_0.method_14(gClass);
						}
						else
						{
							if (class18_0.String_0 == "GV")
							{
								GClass5 gClass2 = new GClass5(570u);
								gClass2.method_6("H");
								class16_0.method_14(gClass2);
								GClass5 gClass3 = new GClass5(572u);
								gClass3.method_11(class16_0.method_2().uint_0);
								gClass3.method_6("H");
								gClass3.method_6(text);
								class16_0.method_14(gClass3);
								if (class16_0.method_2().uint_3 > 0u)
								{
									Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
									Class33 class2 = @class.method_53(class16_0.method_2().uint_0);
									GClass5 gClass4 = new GClass5(28u);
									gClass4.method_9(1);
									class2.method_14(gClass4);
									@class.method_59(gClass4, null);
								}
								Dictionary<Class14, int> dictionary = Phoenix.smethod_15().method_9().method_22();
								IEnumerable<Class14> arg_204_0 = dictionary.Keys;
								if (Class258.func_0 == null)
								{
									Class258.func_0 = new Func<Class14, int>(Class258.smethod_0);
								}
								IOrderedEnumerable<Class14> orderedEnumerable = arg_204_0.OrderByDescending(Class258.func_0);
								foreach (Class14 current in orderedEnumerable)
								{
									if (current.string_3 == class16_0.method_2().string_0)
									{
										current.string_3 = text;
										Phoenix.smethod_15().method_9().method_16(Phoenix.smethod_15().method_9().method_19(current.UInt32_0));
									}
								}
								using (Class6 class3 = Phoenix.smethod_12().method_0())
								{
									class3.method_1(string.Concat(new string[]
									{
										"UPDATE rooms SET owner = '",
										text,
										"' WHERE owner = '",
										class16_0.method_2().string_0,
										"'"
									}));
									class3.method_1(string.Concat(new object[]
									{
										"UPDATE users SET username = '",
										text,
										"' WHERE id = '",
										class16_0.method_2().uint_0,
										"' LIMIT 1"
									}));
									Phoenix.smethod_15().method_2().method_31(class16_0, "flagme", "OldName: " + class16_0.method_2().string_0 + " NewName: " + text);
									class16_0.method_2().string_0 = text;
									class16_0.method_2().method_1(class3);
									foreach (Class27 current2 in class16_0.method_2().list_6)
									{
										current2.string_3 = text;
									}
								}
								Phoenix.smethod_15().method_12().method_3(class16_0, 9u, 1);
							}
						}
					}
				}
			}
		}
		[CompilerGenerated]
		private static int smethod_0(Class14 class14_0)
		{
			return class14_0.Int32_0;
		}
	}
}
