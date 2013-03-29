using System;
namespace ns0
{
	internal sealed class Class240 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				Class39 class2 = class16_0.method_2().method_23().method_10(class18_0.method_15());
				if (class2 != null)
				{
					string text = "floor";
					if (class2.method_1().string_1.ToLower().Contains("wallpaper"))
					{
						text = "wallpaper";
					}
					else
					{
						if (class2.method_1().string_1.ToLower().Contains("landscape"))
						{
							text = "landscape";
						}
					}
					string text2 = text;
					if (text2 != null)
					{
						if (!(text2 == "floor"))
						{
							if (!(text2 == "wallpaper"))
							{
								if (text2 == "landscape")
								{
									@class.string_9 = class2.string_0;
								}
							}
							else
							{
								@class.string_7 = class2.string_0;
								if (class16_0.method_2().uint_6 == 11u)
								{
									Phoenix.smethod_15().method_16().method_1(11u, class16_0);
								}
							}
						}
						else
						{
							@class.string_8 = class2.string_0;
							if (class16_0.method_2().uint_6 == 13u)
							{
								Phoenix.smethod_15().method_16().method_1(13u, class16_0);
							}
						}
					}
					using (Class6 class3 = Phoenix.smethod_12().method_0())
					{
						class3.method_0("extradata", class2.string_0);
						class3.method_1(string.Concat(new object[]
						{
							"UPDATE rooms SET ",
							text,
							" = @extradata WHERE id = '",
							@class.UInt32_0,
							"' LIMIT 1"
						}));
					}
					class16_0.method_2().method_23().method_12(class2.uint_0, 0u, false);
					GClass5 gClass = new GClass5(46u);
					gClass.method_7(text);
					gClass.method_7(class2.string_0);
					@class.method_59(gClass, null);
					Phoenix.smethod_15().method_9().method_18(@class.UInt32_0);
				}
			}
		}
	}
}
