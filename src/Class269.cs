using System;
namespace ns0
{
	internal sealed class Class269 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				for (int i = 0; i < @class.class33_0.Length; i++)
				{
					Class33 class2 = @class.class33_0[i];
					if (class2 != null && (class2.Boolean_4 && class2.class34_0.enum2_0 == Enum2.const_1))
					{
						GClass5 gClass = new GClass5(33u);
						gClass.method_9(4009);
						class16_0.method_14(gClass);
						return;
					}
				}
				if (class16_0.method_2().bool_10)
				{
					GClass5 gClass = new GClass5(33u);
					gClass.method_9(4010);
					class16_0.method_14(gClass);
				}
				else
				{
					Class33 class3 = @class.method_3(Phoenix.smethod_15().method_14().method_3(2u));
					class3.method_7(@class.Class28_0.int_0, @class.Class28_0.int_1, @class.Class28_0.double_0);
					class3.bool_7 = true;
					Class33 class4 = @class.method_56(@class.string_3);
					if (class4 != null)
					{
						class3.method_4(class4.GStruct1_0);
						class3.method_9(Class107.smethod_0(class3.int_3, class3.int_4, class4.int_3, class4.int_4));
					}
					Phoenix.smethod_15().method_12().method_3(class16_0, 6u, 1);
					class16_0.method_2().bool_10 = true;
				}
			}
		}
	}
}
