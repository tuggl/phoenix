using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class229 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && (@class.bool_0 || @class.method_27(class16_0, true)))
			{
				uint uint_ = class18_0.method_15();
				Class15 class2 = class16_0.method_2().method_23().method_4(uint_);
				if (class2 != null && !class2.bool_0)
				{
					int num = class18_0.method_14();
					int num2 = class18_0.method_14();
					if (@class.method_30(num, num2, 0.0, true, false))
					{
						if (@class.Int32_2 >= Class13.int_2)
						{
							class16_0.method_8(Class8.smethod_1("error_maxpets") + Class13.int_2);
						}
						else
						{
							class2.bool_0 = true;
							class2.uint_3 = @class.UInt32_0;
							List<Class36> list = new List<Class36>();
							List<Class35> list2 = new List<Class35>();
							@class.method_4(new Class34(class2.uint_0, class2.uint_3, Enum2.const_0, "freeroam", class2.string_0, "", class2.String_0, num, num2, 0, 0, 0, 0, 0, 0, ref list, ref list2, 0), class2);
							if (@class.method_27(class16_0, true))
							{
								class16_0.method_2().method_23().method_6(class2.uint_0, @class.UInt32_0);
							}
						}
					}
				}
			}
		}
	}
}
