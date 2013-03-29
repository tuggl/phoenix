using System;
namespace ns0
{
	internal sealed class Class169 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			string text = Phoenix.smethod_7(class18_0.method_9());
			if (text.Length <= 50 && !(text != Class58.smethod_4(text)) && !(text == class16_0.method_2().string_4))
			{
				class16_0.method_2().string_4 = text;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("motto", text);
					@class.method_1("UPDATE users SET motto = @motto WHERE id = '" + class16_0.method_2().uint_0 + "' LIMIT 1");
				}
				if (class16_0.method_2().uint_6 == 17u)
				{
					Phoenix.smethod_15().method_16().method_1(17u, class16_0);
				}
				GClass5 gClass = new GClass5(484u);
				gClass.method_9(-1);
				gClass.method_7(class16_0.method_2().string_4);
				class16_0.method_14(gClass);
				if (class16_0.method_2().Boolean_0)
				{
					Class14 class14_ = class16_0.method_2().Class14_0;
					if (class14_ == null)
					{
						return;
					}
					Class33 class2 = class14_.method_53(class16_0.method_2().uint_0);
					if (class2 == null)
					{
						return;
					}
					GClass5 gClass2 = new GClass5(266u);
					gClass2.method_9(class2.int_0);
					gClass2.method_7(class16_0.method_2().string_5);
					gClass2.method_7(class16_0.method_2().string_6.ToLower());
					gClass2.method_7(class16_0.method_2().string_4);
					gClass2.method_9(class16_0.method_2().int_13);
					gClass2.method_7("");
					class14_.method_59(gClass2, null);
				}
				Phoenix.smethod_15().method_12().method_3(class16_0, 5u, 1);
			}
		}
	}
}
