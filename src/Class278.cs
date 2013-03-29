using System;
namespace ns0
{
	internal sealed class Class278 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && !class16_0.method_2().list_4.Contains(@class.UInt32_0) && !@class.method_27(class16_0, true))
			{
				switch (class18_0.method_14())
				{
				case -1:
					@class.int_4--;
					break;
				case 0:
					return;
				case 1:
					@class.int_4++;
					break;
				default:
					return;
				}
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_1(string.Concat(new object[]
					{
						"UPDATE rooms SET score = '",
						@class.int_4,
						"' WHERE id = '",
						@class.UInt32_0,
						"' LIMIT 1"
					}));
				}
				class16_0.method_2().list_4.Add(@class.UInt32_0);
				GClass5 gClass = new GClass5(345u);
				gClass.method_9(@class.int_4);
				class16_0.method_14(gClass);
			}
		}
	}
}
