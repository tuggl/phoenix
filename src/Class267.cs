using System;
namespace ns0
{
	internal sealed class Class267 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			Class33 class2 = @class.method_53(num);
			if (@class != null && @class.method_27(class16_0, true) && class2 != null && !class2.Boolean_4 && !@class.list_1.Contains(num))
			{
				@class.list_1.Add(num);
				using (Class6 class3 = Phoenix.smethod_12().method_0())
				{
					class3.method_1(string.Concat(new object[]
					{
						"INSERT INTO room_rights (room_id,user_id) VALUES ('",
						@class.UInt32_0,
						"','",
						num,
						"')"
					}));
				}
				GClass5 gClass = new GClass5(510u);
				gClass.method_11(@class.UInt32_0);
				gClass.method_11(num);
				gClass.method_7(class2.method_16().method_2().string_0);
				class16_0.method_14(gClass);
				class2.method_11("flatctrl", "");
				class2.bool_7 = true;
				class2.method_16().method_14(new GClass5(42u));
			}
		}
	}
}
