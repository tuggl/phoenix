using System;
namespace ns0
{
	internal sealed class Class137 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().method_3("acc_supporttool"))
			{
				uint uint_ = class18_0.method_15();
				bool flag = class18_0.method_13();
				bool flag2 = class18_0.method_13();
				bool flag3 = class18_0.method_13();
				string text = "";
				if (flag)
				{
					text += "Apply Doorbell";
				}
				if (flag2)
				{
					text += " Change Name";
				}
				if (flag3)
				{
					text += " Kick Users";
				}
				Phoenix.smethod_15().method_2().method_31(class16_0, "ModTool - Room Action", text);
				Phoenix.smethod_15().method_13().method_12(class16_0, uint_, flag3, flag, flag2);
			}
		}
	}
}
