using System;
namespace ns0
{
	internal sealed class Class260 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			//if (@class != null)
			{
				Class33 class2 = @class.method_53(class16_0.method_2().uint_0);
				//if (class2 != null)
				{
				    class2.method_0();
					int num = class18_0.method_14();

					if (num < 0 || num > 4 || (!class16_0.method_2().method_20().method_2("habbo_club") && num > 1))
					{
						num = 0;
					}
					if (num > 0 && class2.int_5 > 0)
					{
						class2.method_8(0);
					}
					class2.int_15 = num;
					GClass5 gClass = new GClass5(480u);
					gClass.method_9(class2.int_0);
					gClass.method_9(num);
					@class.method_59(gClass, null);
					
                    if (class16_0.method_2().uint_6 == 6u)
					{
						Phoenix.smethod_15().method_16().method_1(6u, class16_0);
					}
				}
			}
		}
	}
}
