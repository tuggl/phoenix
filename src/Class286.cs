using System;
namespace ns0
{
	internal sealed class Class286 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			class18_0.method_9();
			class18_0.method_14();
			Class27 @class = Phoenix.smethod_15().method_9().method_12(num);
			if (@class != null)
			{
				if (@class.string_2 == "private")
				{
					GClass5 gClass = new GClass5(286u);
					gClass.method_13(@class.Boolean_0);
					gClass.method_11(num);
					class16_0.method_14(gClass);
				}
				else
				{
					GClass5 gClass2 = new GClass5(453u);
					gClass2.method_11(@class.uint_0);
					gClass2.method_7(@class.string_6);
					gClass2.method_11(@class.uint_0);
					class16_0.method_14(gClass2);
				}
			}
		}
	}
}
