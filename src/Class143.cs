using System;
namespace ns0
{
	internal sealed class Class143 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().method_3("acc_supporttool"))
			{
				uint uint_ = class18_0.method_15();
				if (Phoenix.smethod_15().method_2().method_26(uint_) != "Unknown User")
				{
					class16_0.method_14(Phoenix.smethod_15().method_13().method_18(uint_));
				}
				else
				{
					class16_0.method_8("Could not load user info, invalid user.");
				}
			}
		}
	}
}
