using System;
namespace ns0
{
	internal sealed class Class211 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint uint_ = class18_0.method_15();
			Class49 @class = Phoenix.smethod_15().method_6().method_2(uint_);
			if (@class != null)
			{
				GClass5 gClass = new GClass5(622u);
				gClass.method_11(@class.uint_0);
				gClass.method_13(@class.method_0().bool_6);
				class16_0.method_14(gClass);
			}
		}
	}
}
