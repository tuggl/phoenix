using System;
namespace ns0
{
	internal sealed class Class206 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int int_ = class18_0.method_14();
			uint uint_ = class18_0.method_15();
			string string_ = class18_0.method_9();
			if (class16_0.method_2().int_24 > 1)
			{
				int num = 0;
				while (num < class16_0.method_2().int_24 && Phoenix.smethod_15().method_6().method_6(class16_0, int_, uint_, string_, false, "", "", num == 0))
				{
					num++;
				}
				class16_0.method_2().int_24 = 1;
			}
			else
			{
				Phoenix.smethod_15().method_6().method_6(class16_0, int_, uint_, string_, false, "", "", true);
			}
		}
	}
}
