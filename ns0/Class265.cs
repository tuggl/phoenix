using System;
namespace ns0
{
	internal sealed class Class265 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				foreach (uint current in @class.list_1)
				{
					Class33 class2 = @class.method_53(current);
					if (class2 != null && !class2.Boolean_4)
					{
						class2.method_16().method_14(new GClass5(43u));
					}
					GClass5 gClass = new GClass5(511u);
					gClass.method_11(@class.UInt32_0);
					gClass.method_11(current);
					class16_0.method_14(gClass);
				}
				using (Class6 class3 = Phoenix.smethod_12().method_0())
				{
					class3.method_1("DELETE FROM room_rights WHERE room_id = '" + @class.UInt32_0 + "'");
				}
				@class.list_1.Clear();
			}
		}
	}
}
