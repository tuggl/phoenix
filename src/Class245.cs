using System;
namespace ns0
{
	internal sealed class Class245 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null)
			{
				Class63 class2 = @class.method_28(class18_0.method_15());
				if (class2 != null && !(class2.method_7().string_2.ToLower() != "postit"))
				{
					GClass5 gClass = new GClass5(48u);
					gClass.method_7(class2.uint_0.ToString());
					gClass.method_7(class2.string_0);
					class16_0.method_14(gClass);
				}
			}
		}
	}
}
