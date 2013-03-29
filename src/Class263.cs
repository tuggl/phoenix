using System;
namespace ns0
{
	internal sealed class Class263 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				uint uint_ = class18_0.method_15();
				Class33 class2 = @class.method_53(uint_);
				if (class2 != null && !class2.Boolean_4 && !class2.method_16().method_2().method_3("acc_unbannable"))
				{
					@class.method_70(uint_);
					@class.method_47(class2.method_16(), true, true);
				}
			}
		}
	}
}
