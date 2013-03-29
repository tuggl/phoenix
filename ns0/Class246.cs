using System;
namespace ns0
{
	internal sealed class Class246 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_26(class16_0) && (Class13.Boolean_1 || !(@class.string_3 != class16_0.method_2().string_0)))
			{
				string text = class18_0.method_9();
				string[] array = text.Split(new char[]
				{
					' '
				});
				if (array[0].Contains("-"))
				{
					array[0] = array[0].Replace("-", "");
				}
				uint uint_ = 0u;
				try
				{
					uint_ = uint.Parse(array[0]);
				}
				catch
				{
					return;
				}
				Class39 class2 = class16_0.method_2().method_23().method_10(uint_);
				if (class2 != null)
				{
					string text2 = class2.method_1().string_2.ToLower();
					if (text2 != null && text2 == "dimmer" && @class.method_72("dimmer") >= 1)
					{
						class16_0.method_8("You can only have one moodlight in a room.");
					}
					else
					{
						Class63 class63_;
						if (array[1].StartsWith(":"))
						{
							string text3 = @class.method_98(":" + text.Split(new char[]
							{
								':'
							})[1]);
							if (text3 == null)
							{
								GClass5 gClass = new GClass5(516u);
								gClass.method_9(11);
								class16_0.method_14(gClass);
								return;
							}
							class63_ = new Class63(class2.uint_0, @class.UInt32_0, class2.uint_1, class2.string_0, 0, 0, 0.0, 0, text3, @class);
							if (!@class.method_82(class16_0, class63_, true, null))
							{
								goto IL_32C;
							}
							class16_0.method_2().method_23().method_12(uint_, 1u, false);
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
								goto IL_32C;
							}
						}
						int int_ = int.Parse(array[1]);
						int int_2 = int.Parse(array[2]);
						int int_3 = int.Parse(array[3]);
						class63_ = new Class63(class2.uint_0, @class.UInt32_0, class2.uint_1, class2.string_0, 0, 0, 0.0, 0, "", @class);
						if (@class.method_79(class16_0, class63_, int_, int_2, int_3, true, false, false))
						{
							class16_0.method_2().method_23().method_12(uint_, 1u, false);
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
						IL_32C:
						if (class16_0.method_2().uint_6 == 14u)
						{
							Phoenix.smethod_15().method_16().method_1(14u, class16_0);
						}
					}
				}
			}
		}
	}
}
