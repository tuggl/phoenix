using System;
namespace ns0
{
	internal sealed class Class241 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_26(class16_0))
			{
				int num = class18_0.method_14();
				int num2 = class18_0.method_14();
				string text = class18_0.method_9();
				string text2 = class18_0.method_9();
				string text3 = class18_0.method_9();
				string text4 = class18_0.method_9();
				string text5 = class18_0.method_9();
				string text6 = class18_0.method_9();
				string text7 = class18_0.method_9();
				string text8 = class18_0.method_9();
				string text9 = class18_0.method_9();
				string text10 = class18_0.method_9();
				string text11 = "";
				if (num2 == 10 || num2 == 8)
				{
					text11 = string.Concat(new object[]
					{
						text,
						"=",
						text2,
						Convert.ToChar(9),
						text3,
						"=",
						text4,
						Convert.ToChar(9),
						text5,
						"=",
						text6,
						Convert.ToChar(9),
						text7,
						"=",
						text8
					});
					if (text9 != "")
					{
						text11 = string.Concat(new object[]
						{
							text11,
							Convert.ToChar(9),
							text9,
							"=",
							text10
						});
					}
					using (Class6 class2 = Phoenix.smethod_12().method_0())
					{
						class2.method_0("extradata", text11);
						class2.method_1("UPDATE items SET extra_data = @extradata WHERE id = '" + num + "' LIMIT 1");
					}
					GClass5 gClass = new GClass5(88u);
					gClass.method_7(num.ToString());
					gClass.method_7(text11);
					@class.method_59(gClass, null);
					@class.method_28((uint)num).string_0 = text11;
					@class.method_28((uint)num).method_5(true, false);
				}
			}
		}
	}
}
