using System;
namespace ns0
{
	internal sealed class Class134 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().method_3("acc_supporttool"))
			{
				uint num = class18_0.method_15();
				string text = class18_0.method_9();
				string string_ = string.Concat(new object[]
				{
					"User: ",
					num,
					", Message: ",
					text
				});
				Phoenix.smethod_15().method_2().method_31(class16_0, "ModTool - Alert User", string_);
				Phoenix.smethod_15().method_13().method_16(class16_0, num, text, false);
			}
		}
	}
}
