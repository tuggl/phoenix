using System;
using System.Collections.Generic;
using System.Text;
namespace ns0
{
	internal sealed class Class220 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				class18_0.method_14();
				string text = Phoenix.smethod_7(class18_0.method_9());
				string text2 = Phoenix.smethod_7(class18_0.method_9());
				if (text2.Length > 255)
				{
					text2 = text2.Substring(0, 255);
				}
				int num = class18_0.method_14();
				string text3 = Phoenix.smethod_7(class18_0.method_9());
				int num2 = class18_0.method_14();
				int num3 = class18_0.method_14();
				int num4 = class18_0.method_14();
				List<string> list = new List<string>();
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < num4; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(",");
					}
					string text4 = Phoenix.smethod_7(class18_0.method_9().ToLower());
					if (text4 == Class58.smethod_4(text4))
					{
						list.Add(text4);
						stringBuilder.Append(text4);
					}
				}
				if (stringBuilder.Length > 100)
				{
					stringBuilder.Clear();
					stringBuilder.Append("");
				}
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				string a = class18_0.method_4(1)[0].ToString();
				class18_0.method_1(1);
				string a2 = class18_0.method_4(1)[0].ToString();
				class18_0.method_1(1);
				string a3 = class18_0.method_4(1)[0].ToString();
				class18_0.method_1(1);
				string a4 = class18_0.method_4(1)[0].ToString();
				class18_0.method_1(1);
				int num9 = class18_0.method_14();
				int num10 = class18_0.method_14();
				if (!(text != Class58.smethod_4(text)) && !(text2 != Class58.smethod_4(text2)) && text.Length >= 1 && (num9 >= -2 && num9 <= 1 && num10 >= -2 && num10 <= 1))
				{
					@class.int_5 = num9;
					@class.int_6 = num10;
					if (num >= 0 && num <= 2 && (num2 == 10 || num2 == 15 || num2 == 20 || num2 == 25 || num2 == 30 || num2 == 35 || num2 == 40 || num2 == 45 || num2 == 50 || num2 == 55 || num2 == 60 || num2 == 65 || num2 == 70 || num2 == 75 || num2 == 80 || num2 == 85 || num2 == 90 || num2 == 95 || num2 == 100))
					{
						Class30 class2 = Phoenix.smethod_15().method_7().method_2(num3);
						if (class2 != null)
						{
							if ((long)class2.int_1 > (long)((ulong)class16_0.method_2().uint_1))
							{
								class16_0.method_8("You are not allowed to use this category. Your room has been moved to no category instead.");
								num3 = 0;
							}
							if (num4 <= 2)
							{
								if (a == "65")
								{
									num5 = 1;
									@class.bool_0 = true;
								}
								else
								{
									@class.bool_0 = false;
								}
								if (a2 == "65")
								{
									num6 = 1;
									@class.bool_1 = true;
								}
								else
								{
									@class.bool_1 = false;
								}
								if (a3 == "65")
								{
									num7 = 1;
									@class.bool_2 = true;
								}
								else
								{
									@class.bool_2 = false;
								}
								@class.method_22();
								if (a4 == "65")
								{
									num8 = 1;
									@class.bool_3 = true;
								}
								else
								{
									@class.bool_3 = false;
								}
								@class.string_0 = text;
								@class.int_1 = num;
								@class.string_1 = text2;
								@class.int_0 = num3;
								if (text3 != "")
								{
									@class.string_4 = text3;
								}
								@class.list_0 = list;
								@class.int_3 = num2;
								string text5 = "open";
								if (@class.int_1 == 1)
								{
									text5 = "locked";
								}
								else
								{
									if (@class.int_1 > 1)
									{
										text5 = "password";
									}
								}
								using (Class6 class3 = Phoenix.smethod_12().method_0())
								{
									class3.method_0("caption", @class.string_0);
									class3.method_0("description", @class.string_1);
									class3.method_0("password", @class.string_4);
									class3.method_0("tags", stringBuilder.ToString());
									class3.method_1(string.Concat(new object[]
									{
										"UPDATE rooms SET caption = @caption, description = @description, password = @password, category = '",
										num3,
										"', state = '",
										text5,
										"', tags = @tags, users_max = '",
										num2,
										"', allow_pets = '",
										num5,
										"', allow_pets_eat = '",
										num6,
										"', allow_walkthrough = '",
										num7,
										"', allow_hidewall = '",
										num8,
										"', wallthick = '",
										num9,
										"', floorthick = '",
										num10,
										"'  WHERE id = '",
										@class.UInt32_0,
										"' LIMIT 1;"
									}));
								}
								GClass5 gClass = new GClass5(467u);
								gClass.method_11(@class.UInt32_0);
								class16_0.method_14(gClass);
								GClass5 gClass2 = new GClass5(456u);
								gClass2.method_11(@class.UInt32_0);
								class16_0.method_14(gClass2);
								GClass5 gClass3 = new GClass5(472u);
								gClass3.method_13(@class.bool_3);
								gClass3.method_9(@class.int_5);
								gClass3.method_9(@class.int_6);
								@class.method_59(gClass3, null);
								GClass5 gClass4 = new GClass5(473u);
								gClass4.method_13(true);
								gClass4.method_13(true);
								@class.method_59(gClass4, null);
								Class27 class27_ = @class.Class27_0;
								GClass5 gClass5 = new GClass5(454u);
								gClass5.method_13(false);
								class27_.method_3(gClass5, false, false);
								class16_0.method_14(gClass5);
							}
						}
					}
				}
			}
		}
	}
}
