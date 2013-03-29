using System;
namespace ns0
{
	internal sealed class Class232 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null && @class.method_27(class16_0, true) && @class.class67_0 != null)
				{
					Class63 class2 = null;
					foreach (Class63 class3 in @class.Hashtable_1.Values)
					{
						if (class3.method_7().string_2.ToLower() == "dimmer")
						{
							class2 = class3;
							break;
						}
					}
					if (class2 != null)
					{
						if (@class.class67_0.bool_0)
						{
							@class.class67_0.method_1();
						}
						else
						{
							@class.class67_0.method_0();
						}
						class2.string_0 = @class.class67_0.method_7();
						class2.method_4();
					}
				}
			}
			catch
			{
			}
		}
	}
}
