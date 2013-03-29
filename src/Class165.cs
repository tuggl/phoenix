using System;
namespace ns0
{
	internal sealed class Class165 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			string text = class18_0.method_9();
			GClass5 gClass = new GClass5(7u);
			gClass.method_7(text.ToLower());
			if (class16_0.method_2().method_20().method_2("habbo_vip"))
			{
				double num = (double)class16_0.method_2().method_20().method_1("habbo_vip").Int32_0;
				double num2 = num - Phoenix.smethod_6();
				int num3 = (int)Math.Ceiling(num2 / 86400.0);
				int num4 = num3 / 31;
				if (num4 >= 1)
				{
					num4--;
				}
				gClass.method_9(num3 - num4 * 31);
				gClass.method_13(true);
				gClass.method_9(num4);
				gClass.method_13(true);
				gClass.method_13(true);
				gClass.method_13(class16_0.method_2().bool_14);
				gClass.method_9(0);
				gClass.method_9(0);
			}
			else
			{
				if (class16_0.method_2().method_20().method_2(text))
				{
					double num = (double)class16_0.method_2().method_20().method_1(text).Int32_0;
					double num2 = num - Phoenix.smethod_6();
					int num3 = (int)Math.Ceiling(num2 / 86400.0);
					int num4 = num3 / 31;
					if (num4 >= 1)
					{
						num4--;
					}
					gClass.method_9(num3 - num4 * 31);
					gClass.method_13(true);
					gClass.method_9(num4);
					if (class16_0.method_2().uint_1 >= 2u)
					{
						gClass.method_9(1);
						gClass.method_9(1);
						gClass.method_9(2);
					}
					else
					{
						gClass.method_9(1);
					}
				}
				else
				{
					for (int i = 0; i < 3; i++)
					{
						gClass.method_9(0);
					}
				}
			}
			class16_0.method_14(gClass);
		}
	}
}
