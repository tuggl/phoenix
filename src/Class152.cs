using System;
namespace ns0
{
	internal sealed class Class152 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			bool flag = false;
			if (Phoenix.smethod_15().method_13().method_9(class16_0.method_2().uint_0))
			{
				flag = true;
			}
			if (!flag)
			{
				string string_ = Phoenix.smethod_7(class18_0.method_9());
				class18_0.method_14();
				int int_ = class18_0.method_14();
				uint uint_ = class18_0.method_15();
				Phoenix.smethod_15().method_13().method_3(class16_0, int_, uint_, string_);
			}
			GClass5 gClass = new GClass5(321u);
			gClass.method_13(flag);
			class16_0.method_14(gClass);
		}
	}
}
