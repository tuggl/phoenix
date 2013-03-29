using System;
namespace ns0
{
	internal sealed class Class234 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null && @class.method_27(class16_0, true) && @class.class67_0 != null)
				{
					GClass5 gClass = new GClass5(365u);
					gClass.method_9(@class.class67_0.list_0.Count);
					gClass.method_9(@class.class67_0.int_0);
					int num = 0;
					foreach (Class68 current in @class.class67_0.list_0)
					{
						num++;
						gClass.method_9(num);
						gClass.method_9(int.Parse(Phoenix.smethod_4(current.bool_0)) + 1);
						gClass.method_7(current.string_0);
						gClass.method_9(current.int_0);
					}
					class16_0.method_14(gClass);
				}
			}
			catch
			{
			}
		}
	}
}
