using System;
namespace ns0
{
	internal sealed class Class249 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			class18_0.method_14();
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				Class63 class2 = @class.method_28(class18_0.method_15());
				if (class2 != null)
				{
					string text = class2.method_7().string_2.ToLower();
					if (text == null || !(text == "postit"))
					{
						@class.method_29(class16_0, class2.uint_0, false, true);
						class16_0.method_2().method_23().method_11(class2.uint_0, class2.uint_2, class2.string_0, false);
						class16_0.method_2().method_23().method_9(true);
						if (class16_0.method_2().uint_6 == 10u)
						{
							Phoenix.smethod_15().method_16().method_1(10u, class16_0);
						}
					}
				}
			}
		}
	}
}
