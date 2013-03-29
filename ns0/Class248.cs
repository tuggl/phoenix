using System;
namespace ns0
{
	internal sealed class Class248 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_26(class16_0))
			{
				Class63 class2 = @class.method_28(class18_0.method_15());
				if (class2 != null)
				{
					int num = class18_0.method_14();
					int num2 = class18_0.method_14();
					int num3 = class18_0.method_14();
					class18_0.method_14();
					if (class16_0.method_2().uint_6 == 1u && (num != class2.Int32_0 || num2 != class2.Int32_1))
					{
						Phoenix.smethod_15().method_16().method_1(1u, class16_0);
					}
					else
					{
						if (class16_0.method_2().uint_6 == 7u && num3 != class2.int_3)
						{
							Phoenix.smethod_15().method_16().method_1(7u, class16_0);
						}
						else
						{
							if (class16_0.method_2().uint_6 == 9u && class2.Double_0 >= 0.1)
							{
								Phoenix.smethod_15().method_16().method_1(9u, class16_0);
							}
						}
					}
					bool flag = false;
					string text = class2.method_7().string_2.ToLower();
					if (text != null && text == "teleport")
					{
						flag = true;
					}
					@class.method_79(class16_0, class2, num, num2, num3, false, false, false);
					if (flag)
					{
						@class.method_64();
					}
				}
			}
		}
	}
}
