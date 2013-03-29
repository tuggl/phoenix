using System;
namespace ns0
{
	internal sealed class Class233 : Interface0
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
						int num = class18_0.method_14();
						int num2 = class18_0.method_14();
						string string_ = class18_0.method_9();
						int int_ = class18_0.method_14();
						bool bool_ = false;
						if (num2 >= 2)
						{
							bool_ = true;
						}
						@class.class67_0.bool_0 = true;
						@class.class67_0.int_0 = num;
						@class.class67_0.method_2(num, string_, int_, bool_);
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
