using System;
namespace ns0
{
	internal sealed class Class73 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			if (bool_0 && class16_0 != null)
			{
				class63_0.method_9();
				GClass5 gClass = new GClass5(651u);
				gClass.method_9(0);
				gClass.method_9(5);
				if (class63_0.string_5.Length > 0)
				{
					gClass.method_6(class63_0.string_5);
				}
				else
				{
					gClass.method_9(0);
				}
				gClass.method_9(class63_0.method_7().int_0);
				gClass.method_11(class63_0.uint_0);
				gClass.method_7("");
				gClass.method_6("K");
				if (class63_0.string_3.Length > 0)
				{
					gClass.method_6(class63_0.string_3);
				}
				else
				{
					gClass.method_6("HHH");
				}
				gClass.method_6("IK");
				if (class63_0.string_6.Length > 0)
				{
					gClass.method_9(Convert.ToInt32(class63_0.string_6));
				}
				else
				{
					gClass.method_9(0);
				}
				gClass.method_7("H");
				class16_0.method_14(gClass);
			}
		}
	}
}
