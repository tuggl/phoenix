using System;
using System.Text;
namespace ns0
{
	internal sealed class Class266 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				StringBuilder stringBuilder = new StringBuilder();
				int num = class18_0.method_14();
				for (int i = 0; i < num; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(" OR ");
					}
					uint num2 = class18_0.method_15();
					@class.list_1.Remove(num2);
					stringBuilder.Append(string.Concat(new object[]
					{
						"room_id = '",
						@class.UInt32_0,
						"' AND user_id = '",
						num2,
						"'"
					}));
					Class33 class2 = @class.method_53(num2);
					if (class2 != null && !class2.Boolean_4)
					{
						class2.method_16().method_14(new GClass5(43u));
						class2.method_12("flatctrl");
						class2.bool_7 = true;
					}
					GClass5 gClass = new GClass5(511u);
					gClass.method_11(@class.UInt32_0);
					gClass.method_11(num2);
					class16_0.method_14(gClass);
				}
				using (Class6 class3 = Phoenix.smethod_12().method_0())
				{
					class3.method_1("DELETE FROM room_rights WHERE " + stringBuilder.ToString());
				}
			}
		}
	}
}
