using System;
namespace ns0
{
	internal sealed class Class308 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint uint_ = class18_0.method_15();
			Class16 @class = Phoenix.smethod_15().method_2().method_2(uint_);
			if (@class != null && @class.method_2() != null && @class.method_2().Boolean_0)
			{
				Class14 class2 = Phoenix.smethod_15().method_9().method_19(@class.method_2().uint_3);
				if (class2 != null && class2 != class16_0.method_2().Class14_0)
				{
					GClass5 gClass = new GClass5(286u);
					gClass.method_13(class2.Boolean_3);
					gClass.method_11(class2.UInt32_0);
					class16_0.method_14(gClass);
				}
			}
		}
	}
}
