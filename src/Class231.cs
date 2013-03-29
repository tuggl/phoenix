using System;
namespace ns0
{
	internal sealed class Class231 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null)
				{
					if (@class.method_72("stickiepole") > 0 || @class.method_26(class16_0))
					{
						uint uint_ = class18_0.method_15();
						string text = class18_0.method_9();
						string[] array = text.Split(new char[]
						{
							' '
						});
						if (array[0].Contains("-"))
						{
							array[0] = array[0].Replace("-", "");
						}
						Class39 class2 = class16_0.method_2().method_23().method_10(uint_);
						if (class2 != null)
						{
							if (array[0].StartsWith(":"))
							{
								string text2 = @class.method_98(text);
								if (text2 == null)
								{
									GClass5 gClass = new GClass5(516u);
									gClass.method_9(11);
									class16_0.method_14(gClass);
									return;
								}
								Class63 class63_ = new Class63(class2.uint_0, @class.UInt32_0, class2.uint_1, class2.string_0, 0, 0, 0.0, 0, text2, @class);
								if (@class.method_82(class16_0, class63_, true, null))
								{
									class16_0.method_2().method_23().method_12(uint_, 1u, false);
								}
							}
							using (Class6 class3 = Phoenix.smethod_12().method_0())
							{
								class3.method_1(string.Concat(new object[]
								{
									"UPDATE items SET room_id = '",
									@class.UInt32_0,
									"' WHERE id = '",
									class2.uint_0,
									"' LIMIT 1"
								}));
							}
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
