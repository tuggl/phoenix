using System;
namespace ns0
{
	internal sealed class Class88 : Class69
	{
		public override void vmethod_0(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "0";
			if (class63_0.uint_3 > 0u)
			{
				Class33 @class = class63_0.method_8().method_53(class63_0.uint_3);
				if (@class != null)
				{
					@class.bool_0 = true;
				}
			}
		}
		public override void vmethod_1(Class16 class16_0, Class63 class63_0)
		{
			class63_0.string_0 = "0";
			if (class63_0.uint_3 > 0u)
			{
				Class33 @class = class63_0.method_8().method_53(class63_0.uint_3);
				if (@class != null)
				{
					@class.bool_0 = true;
				}
			}
		}
		public override void vmethod_2(Class16 class16_0, Class63 class63_0, int int_0, bool bool_0)
		{
			if (class63_0.string_0 != "1" && class63_0.method_7().list_1.Count >= 1 && class63_0.uint_3 == 0u)
			{
				if (class16_0 != null)
				{
					Class33 @class = class63_0.method_8().method_53(class16_0.method_2().uint_0);
					if (@class == null)
					{
						return;
					}
					if (!class63_0.method_8().method_99(@class.int_3, @class.int_4, class63_0.Int32_0, class63_0.Int32_1))
					{
						if (!@class.bool_0)
						{
							return;
						}
						try
						{
							@class.method_4(class63_0.GStruct1_1);
							return;
						}
						catch
						{
							return;
						}
					}
					class63_0.uint_3 = class16_0.method_2().uint_0;
					@class.bool_0 = false;
					@class.method_3(true);
					@class.method_9(Class107.smethod_0(@class.int_3, @class.int_4, class63_0.Int32_0, class63_0.Int32_1));
				}
				class63_0.method_3(2);
				class63_0.string_0 = "1";
				class63_0.method_5(false, true);
			}
		}
	}
}
