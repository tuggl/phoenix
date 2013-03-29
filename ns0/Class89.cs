using System;
namespace ns0
{
	internal sealed class Class89 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "0";
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "0";
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			if (bool_0 && class63_0.string_0 == "0")
			{
				class63_0.string_0 = "1";
				class63_0.method_5(false, true);
				class63_0.method_3(4);
			}
		}
	}
}
