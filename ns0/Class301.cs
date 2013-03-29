using System;
namespace ns0
{
	internal sealed class Class301 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			string text = Phoenix.smethod_7(class18_0.method_9());
			if (class16_0.method_2().method_21() != null)
			{
				if (num == 0u && class16_0.method_2().method_3("cmd_sa"))
				{
					GClass5 gClass = new GClass5(134u);
					gClass.method_11(0u);
					gClass.method_6(class16_0.method_2().string_0 + ": " + text);
					Phoenix.smethod_15().method_2().method_17(class16_0, gClass);
				}
				else
				{
					if (num == 0u)
					{
						GClass5 gClass2 = new GClass5(261u);
						gClass2.method_9(4);
						gClass2.method_11(0u);
						class16_0.method_14(gClass2);
					}
					else
					{
						class16_0.method_2().method_21().method_18(num, text);
					}
				}
			}
		}
	}
}
