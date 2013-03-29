using System;
namespace ns0
{
	internal sealed class Class310 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().method_21() != null)
			{
				int num = class18_0.method_14();
				for (int i = 0; i < num; i++)
				{
					uint uint_ = class18_0.method_15();
					Class106 @class = class16_0.method_2().method_21().method_4(uint_);
					if (@class != null)
					{
						if (@class.UInt32_1 != class16_0.method_2().uint_0)
						{
							break;
						}
						if (!class16_0.method_2().method_21().method_9(@class.UInt32_1, @class.UInt32_2))
						{
							class16_0.method_2().method_21().method_12(@class.UInt32_2);
						}
						class16_0.method_2().method_21().method_11(uint_);
					}
				}
			}
		}
	}
}
