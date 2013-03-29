using System;
namespace ns0
{
	internal sealed class Class227 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			Class33 class2 = @class.method_48(num);
			if (class2 != null && class2.class15_0 != null)
			{
				GClass5 gClass = new GClass5(605u);
				gClass.method_11(num);
				int i = class2.class15_0.Int32_0;
				gClass.method_9(18);
				gClass.method_9(0);
				gClass.method_9(1);
				gClass.method_9(2);
				gClass.method_9(3);
				gClass.method_9(4);
				gClass.method_9(17);
				gClass.method_9(5);
				gClass.method_9(6);
				gClass.method_9(7);
				gClass.method_9(8);
				gClass.method_9(9);
				gClass.method_9(10);
				gClass.method_9(11);
				gClass.method_9(12);
				gClass.method_9(13);
				gClass.method_9(14);
				gClass.method_9(15);
				gClass.method_9(16);
				int num2 = 0;
				while (i > num2)
				{
					num2++;
					gClass.method_9(num2);
				}
				gClass.method_9(0);
				gClass.method_9(1);
				gClass.method_9(2);
				class16_0.method_14(gClass);
			}
		}
	}
}
