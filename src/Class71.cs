using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class71 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			Class14 @class = class63_0.method_8();
			Class33 class2 = @class.method_53(class16_0.method_2().uint_0);
			if (class2 != null && @class != null)
			{
				GStruct1 gstruct1_ = new GStruct1(class63_0.Int32_0 + 1, class63_0.Int32_1);
				GStruct1 gstruct1_2 = new GStruct1(class63_0.Int32_0 - 1, class63_0.Int32_1);
				GStruct1 gstruct1_3 = new GStruct1(class63_0.Int32_0, class63_0.Int32_1 + 1);
				GStruct1 gstruct1_4 = new GStruct1(class63_0.Int32_0, class63_0.Int32_1 - 1);
				if (GStruct1.smethod_1(class2.GStruct1_0, gstruct1_) && GStruct1.smethod_1(class2.GStruct1_0, gstruct1_2) && GStruct1.smethod_1(class2.GStruct1_0, gstruct1_3) && GStruct1.smethod_1(class2.GStruct1_0, gstruct1_4))
				{
					if (class2.bool_0)
					{
						class2.method_4(class63_0.GStruct1_0);
					}
				}
				else
				{
					int num = class63_0.Int32_0;
					int num2 = class63_0.Int32_1;
					if (GStruct1.smethod_0(class2.GStruct1_0, gstruct1_))
					{
						num = class63_0.Int32_0 - 1;
						num2 = class63_0.Int32_1;
					}
					else
					{
						if (GStruct1.smethod_0(class2.GStruct1_0, gstruct1_2))
						{
							num = class63_0.Int32_0 + 1;
							num2 = class63_0.Int32_1;
						}
						else
						{
							if (GStruct1.smethod_0(class2.GStruct1_0, gstruct1_3))
							{
								num = class63_0.Int32_0;
								num2 = class63_0.Int32_1 - 1;
							}
							else
							{
								if (GStruct1.smethod_0(class2.GStruct1_0, gstruct1_4))
								{
									num = class63_0.Int32_0;
									num2 = class63_0.Int32_1 + 1;
								}
							}
						}
					}
					if (@class.method_37(num, num2, true, true, true, true, false))
					{
						List<Class63> list_ = new List<Class63>();
						list_ = @class.method_93(num, num2);
						double double_ = @class.method_84(num, num2, list_);
						GClass5 gClass = new GClass5(230u);
						gClass.method_9(class63_0.Int32_0);
						gClass.method_9(class63_0.Int32_1);
						gClass.method_9(num);
						gClass.method_9(num2);
						gClass.method_9(1);
						gClass.method_11(class63_0.uint_0);
						gClass.method_3(2);
						gClass.method_7(double_.ToString());
						gClass.method_6("M");
						@class.method_59(gClass, null);
						@class.method_81(class63_0, num, num2, double_);
					}
				}
			}
		}
	}
}
