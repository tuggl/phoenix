using System;
namespace ns0
{
	internal sealed class Class289 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint uint_ = class18_0.method_15();
			bool bool_ = class18_0.method_13();
			bool flag = class18_0.method_13();
			Class27 @class = Phoenix.smethod_15().method_9().method_12(uint_);
			if (@class != null)
			{
				GClass5 gClass = new GClass5(454u);
				gClass.method_13(bool_);
				@class.method_3(gClass, false, flag);
				gClass.method_13(flag);
				gClass.method_13(bool_);
				class16_0.method_14(gClass);
			}
		}
	}
}
