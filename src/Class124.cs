using System;
namespace ns0
{
	internal sealed class Class124 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int num = class18_0.method_14();
			GClass5 gClass = new GClass5(300u);
			gClass.method_9(num);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					int num2 = class18_0.method_14();
					if (num2 > 0)
					{
						Class42 @class = Phoenix.smethod_15().method_8().method_4(num2);
						gClass.method_9(@class.int_0);
						gClass.method_7(@class.string_0);
						gClass.method_7(@class.string_2);
						gClass.method_9(@class.int_1);
						gClass.method_7(@class.string_1);
					}
				}
			}
			class16_0.method_14(gClass);
		}
	}
}
