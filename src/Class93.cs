using System;
namespace ns0
{
	internal sealed class Class93 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			Class33 @class = null;
			if (class16_0 != null)
			{
				@class = class63_0.method_8().method_53(class16_0.method_2().uint_0);
				if (@class == null)
				{
					return;
				}
			}
			if (class16_0 == null || class63_0.method_8().method_99(class63_0.Int32_0, class63_0.Int32_1, @class.int_3, @class.int_4))
			{
				if (class63_0.string_0 != "-1")
				{
					if (int_0 == -1)
					{
						class63_0.string_0 = "0";
						class63_0.method_4();
					}
					else
					{
						class63_0.uint_3 = @class.uint_0;
						class63_0.string_0 = "-1";
						class63_0.method_5(false, true);
						class63_0.method_3(4);
					}
				}
			}
			else
			{
				if (class16_0 != null && @class != null && @class.bool_0)
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
