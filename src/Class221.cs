using System;
namespace ns0
{
	internal sealed class Class221 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				GClass5 gClass = new GClass5(465u);
				gClass.method_11(@class.UInt32_0);
				gClass.method_7(@class.string_0);
				gClass.method_7(@class.string_1);
				gClass.method_9(@class.int_1);
				gClass.method_9(@class.int_0);
				gClass.method_9(@class.int_3);
				gClass.method_9(100);
				gClass.method_9(@class.list_0.Count);
				foreach (string current in @class.list_0)
				{
					gClass.method_7(current);
				}
				gClass.method_9(@class.list_1.Count);
				foreach (uint current2 in @class.list_1)
				{
					gClass.method_11(current2);
					gClass.method_7(Phoenix.smethod_15().method_2().method_26(current2));
				}
				gClass.method_9(@class.list_1.Count);
				gClass.method_13(@class.bool_0);
				gClass.method_13(@class.bool_1);
				gClass.method_13(@class.bool_2);
				gClass.method_13(@class.bool_3);
				gClass.method_9(@class.int_5);
				gClass.method_9(@class.int_6);
				class16_0.method_14(gClass);
			}
		}
	}
}
