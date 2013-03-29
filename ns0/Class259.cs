using System;
namespace ns0
{
	internal sealed class Class259 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null)
			{
				Class33 class2 = @class.method_53(class16_0.method_2().uint_0);
				if (class2 != null)
				{
					class2.method_0();
					int num = class18_0.method_14();
					int num2 = class18_0.method_14();
					if (num != class2.int_3 || num2 != class2.int_4)
					{
						int int_ = Class107.smethod_0(class2.int_3, class2.int_4, num, num2);
						class2.method_9(int_);
						if (class2.class34_1 != null && class2.class33_0 != null)
						{
							class2.class33_0.method_9(int_);
						}
					}
				}
			}
		}
	}
}
