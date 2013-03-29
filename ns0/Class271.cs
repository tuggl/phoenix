using System;
namespace ns0
{
	internal sealed class Class271 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			Class27 @class = Phoenix.smethod_15().method_9().method_12(num);
			if (num == 0u || (@class != null && !(@class.string_3.ToLower() != class16_0.method_2().string_0.ToLower())))
			{
				class16_0.method_2().uint_4 = num;
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_1(string.Concat(new object[]
					{
						"UPDATE users SET home_room = '",
						num,
						"' WHERE id = '",
						class16_0.method_2().uint_0,
						"' LIMIT 1;"
					}));
				}
				GClass5 gClass = new GClass5(455u);
				gClass.method_11(num);
				class16_0.method_14(gClass);
			}
		}
	}
}
