using System;
namespace ns0
{
	internal sealed class Class242 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 class14_ = class16_0.method_2().Class14_0;
			if (class14_ != null)
			{
				Class33 @class = class14_.method_53(class16_0.method_2().uint_0);
				if (@class != null && @class.bool_0)
				{
					int num = class18_0.method_14();
					int num2 = class18_0.method_14();
					if (num != @class.int_3 || num2 != @class.int_4)
					{
						if (@class.class33_0 != null)
						{
							try
							{
								if (@class.class33_0.Boolean_4)
								{
									@class.method_0();
								}
								@class.class33_0.method_5(num, num2);
								return;
							}
							catch
							{
								@class.class33_0 = null;
								@class.class34_1 = null;
								@class.method_5(num, num2);
								class16_0.method_2().method_24().method_2(-1, true);
								return;
							}
						}
						if (@class.bool_2)
						{
							@class.int_3 = num;
							@class.int_4 = num2;
							@class.bool_7 = true;
						}
						else
						{
							@class.method_5(num, num2);
						}
					}
				}
			}
		}
	}
}
