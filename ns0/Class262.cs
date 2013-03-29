using System;
namespace ns0
{
	internal sealed class Class262 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_26(class16_0))
			{
				string string_ = class18_0.method_9();
				byte[] array = class18_0.method_3(1);
				Class16 class2 = Phoenix.smethod_15().method_2().method_3(string_);
				if (class2 != null && class2.method_2().bool_6 && class2.method_2().uint_2 == class16_0.method_2().uint_3)
				{
					if (array[0] == Convert.ToByte(65))
					{
						class2.method_2().bool_5 = true;
						class2.method_14(new GClass5(41u));
					}
					else
					{
						class2.method_14(new GClass5(131u));
					}
				}
			}
		}
	}
}
