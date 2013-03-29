using System;
namespace ns0
{
	internal sealed class Class226 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && !@class.Boolean_3)
			{
				uint uint_ = class18_0.method_15();
				Class33 class2 = @class.method_48(uint_);
				if (class2 != null && class2.class15_0 != null && class16_0.method_2().int_22 > 0)
				{
					class2.class15_0.method_0();
					class16_0.method_2().int_22--;
					using (Class6 class3 = Phoenix.smethod_12().method_0())
					{
						class3.method_0("userid", class16_0.method_2().uint_0);
						class3.method_1("UPDATE user_stats SET dailypetrespectpoints = dailypetrespectpoints - 1 WHERE id = @userid LIMIT 1");
					}
				}
			}
		}
	}
}
