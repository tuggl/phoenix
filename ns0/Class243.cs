using System;
namespace ns0
{
	internal sealed class Class243 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				Class63 class2 = @class.method_28(class18_0.method_15());
				if (class2 != null && !(class2.method_7().string_2.ToLower() != "postit"))
				{
					@class.method_29(class16_0, class2.uint_0, true, true);
				}
			}
		}
	}
}
