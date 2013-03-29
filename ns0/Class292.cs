using System;
namespace ns0
{
	internal sealed class Class292 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().list_6.Count <= Class13.Int32_4)
			{
				string string_ = Phoenix.smethod_7(class18_0.method_9());
				string string_2 = class18_0.method_9();
				class18_0.method_9();
				Class27 @class = Phoenix.smethod_15().method_9().method_20(class16_0, string_, string_2);
				if (@class != null)
				{
					GClass5 gClass = new GClass5(59u);
					gClass.method_11(@class.uint_0);
					gClass.method_7(@class.string_0);
					class16_0.method_14(gClass);
				}
			}
		}
	}
}
