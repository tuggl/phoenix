using System;
namespace ns0
{
	internal sealed class Class95 : Class69
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
					@class.bool_1 = false;
					@class.bool_0 = true;
				}
				class63_0.uint_3 = 0u;
			}
			if (class63_0.uint_4 != 0u)
			{
				Class33 @class = class63_0.method_8().method_53(class63_0.uint_4);
				if (@class != null)
				{
					@class.method_3(true);
					@class.bool_1 = false;
					@class.bool_0 = true;
				}
				class63_0.uint_4 = 0u;
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
					@class.method_6();
				}
				class63_0.uint_3 = 0u;
			}
			if (class63_0.uint_4 != 0u)
			{
				Class33 @class = class63_0.method_8().method_53(class63_0.uint_4);
				if (@class != null)
				{
					@class.method_6();
				}
				class63_0.uint_4 = 0u;
			}
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			Class33 @class = class63_0.method_8().method_53(class16_0.method_2().uint_0);
			if (@class != null && @class.class34_1 == null)
			{
				if (GStruct1.smethod_0(@class.GStruct1_0, class63_0.GStruct1_0) || GStruct1.smethod_0(@class.GStruct1_0, class63_0.GStruct1_1))
				{
					if (class63_0.uint_3 == 0u)
					{
						@class.int_19 = -1;
						class63_0.uint_3 = @class.method_16().method_2().uint_0;
						@class.class63_0 = class63_0;
					}
				}
				else
				{
					if (@class.bool_0)
					{
						try
						{
							@class.method_4(class63_0.GStruct1_1);
						}
						catch
						{
						}
					}
				}
			}
		}
	}
}
