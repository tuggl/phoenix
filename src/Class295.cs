using System;
namespace ns0
{
	internal sealed class Class295 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				bool bool_ = true;
				int int_ = 0;
				if (@class.int_1 != 0)
				{
					bool_ = false;
					int_ = 3;
				}
				GClass5 gClass = new GClass5(367u);
				gClass.method_13(bool_);
				gClass.method_9(int_);
				class16_0.method_14(gClass);
			}
		}
	}
}
