using System;
namespace ns0
{
	internal sealed class Class136 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0.method_2().method_3("acc_supporttool"))
			{
				class18_0.method_14();
				int num = class18_0.method_14();
				string text = class18_0.method_9();
				string text2 = "";
				if (num.Equals(3))
				{
					text2 += "Room Cautioned.";
				}
				text2 = text2 + " Message: " + text;
				Phoenix.smethod_15().method_2().method_31(class16_0, "ModTool - Room Alert", text2);
				Phoenix.smethod_15().method_13().method_13(class16_0.method_2().uint_3, !num.Equals(3), text);
			}
		}
	}
}
