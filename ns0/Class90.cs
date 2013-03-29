using System;
namespace ns0
{
	internal sealed class Class90 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "0";
			if (class63_0.uint_3 != 0u)
			{
				Class33 @class = class63_0.method_8().method_53(class63_0.uint_3);
				if (@class != null)
				{
					@class.method_3(true);
					@class.method_6();
				}
				class63_0.uint_3 = 0u;
			}
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "0";
			if (class63_0.uint_3 != 0u)
			{
				Class33 @class = class63_0.method_8().method_53(class63_0.uint_3);
				if (@class != null)
				{
					@class.method_3(true);
					@class.method_6();
				}
				class63_0.uint_3 = 0u;
			}
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			Class33 @class = class63_0.method_8().method_53(class16_0.method_2().uint_0);
			if (@class != null && (class63_0.GStruct1_2.int_0 < class63_0.method_8().Class28_0.int_4 && class63_0.GStruct1_2.int_1 < class63_0.method_8().Class28_0.int_5))
			{
				if (GStruct1.smethod_1(@class.GStruct1_0, class63_0.GStruct1_1) && @class.bool_0)
				{
					@class.method_4(class63_0.GStruct1_1);
				}
				else
				{
					if (class63_0.method_8().method_30(class63_0.GStruct1_2.int_0, class63_0.GStruct1_2.int_1, class63_0.Double_0, true, false) && class63_0.uint_3 == 0u)
					{
						class63_0.uint_3 = @class.uint_0;
						@class.bool_0 = false;
						if (@class.bool_6 && (@class.int_10 != class63_0.GStruct1_1.int_0 || @class.int_11 != class63_0.GStruct1_1.int_1))
						{
							@class.method_3(true);
						}
						@class.bool_1 = true;
						@class.method_4(class63_0.GStruct1_0);
						class63_0.method_3(3);
					}
				}
			}
		}
	}
}
