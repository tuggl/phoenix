using System;
namespace ns0
{
	internal sealed class Class177 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null)
			{
				if (!@class.Boolean_2)
				{
					class16_0.method_2().method_28(Class8.smethod_1("trade_error_roomdisabled"));
				}
				else
				{
					Class33 class2 = @class.method_53(class16_0.method_2().uint_0);
					Class33 class3 = @class.method_52(class18_0.method_14());
					if (class2 != null && class3 != null && class3.method_16().method_2().bool_2)
					{
						@class.method_77(class2, class3);
					}
					else
					{
						class16_0.method_2().method_28(Class8.smethod_1("trade_error_targetdisabled"));
					}
				}
			}
		}
	}
}
