using System;
namespace ns0
{
	internal sealed class Class92 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "-1";
			class63_0.method_3(10);
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "-1";
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			if (bool_0 && class63_0.string_0 != "-1")
			{
				class63_0.string_0 = "-1";
				class63_0.method_4();
				class63_0.method_3(10);
			}
		}
	}
}
