using System;
namespace ns0
{
	internal sealed class Class195 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().method_23() != null)
			{
				if (class16_0.method_2().Boolean_0)
				{
					Class14 class14_ = class16_0.method_2().Class14_0;
					Class33 @class = class14_.method_53(class16_0.method_2().uint_0);
					if (@class.Boolean_3)
					{
						return;
					}
				}
				int int_ = class18_0.method_14();
				class18_0.method_14();
				uint uint_ = class18_0.method_15();
				Class39 class2 = class16_0.method_2().method_23().method_10(uint_);
				if (class2 != null && class2.method_1().bool_4)
				{
					Phoenix.smethod_15().method_6().method_22().method_1(class16_0, class2.uint_0, int_);
				}
			}
		}
	}
}
