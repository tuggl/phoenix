using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class97 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			if (class63_0.method_7().list_0.Count > 1)
			{
				Dictionary<int, GClass10> dictionary = class63_0.method_8().method_94(class63_0.method_7().int_2, class63_0.method_7().int_1, class63_0.Int32_0, class63_0.Int32_1, class63_0.int_3);
				class63_0.method_8().method_22();
				class63_0.method_8().method_87(class63_0.method_8().method_43(class63_0.Int32_0, class63_0.Int32_1), true, true);
				foreach (GClass10 current in dictionary.Values)
				{
					class63_0.method_8().method_87(class63_0.method_8().method_43(current.Int32_0, current.Int32_1), true, true);
				}
			}
			if (class16_0 != null)
			{
				Class33 class33_ = class16_0.method_2().Class14_0.method_53(class16_0.method_2().uint_0);
				class63_0.method_8().method_10(class33_, class63_0);
			}
		}
	}
}
