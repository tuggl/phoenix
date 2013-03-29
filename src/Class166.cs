using System;
namespace ns0
{
	internal sealed class Class166 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			string text = class18_0.method_9().ToUpper();
			string text2 = Phoenix.smethod_7(class18_0.method_9());
			//if (class16_0.method_2().Boolean_0 && Class98.smethod_0(text2, text))
			{
				Class14 class14_ = class16_0.method_2().Class14_0;
				if (class14_ != null)
				{
					Class33 @class = class14_.method_53(class16_0.method_2().uint_0);
					if (@class != null)
					{
						@class.string_0 = "";
						if (class16_0.method_2().method_4() > 0)
						{
							TimeSpan timeSpan = DateTime.Now - class16_0.method_2().dateTime_0;
							if (timeSpan.Seconds > 4)
							{
								class16_0.method_2().int_23 = 0;
							}
							if (timeSpan.Seconds < 4 && class16_0.method_2().int_23 > 5)
							{
								GClass5 gClass = new GClass5(27u);
								gClass.method_9(class16_0.method_2().method_4());
								class16_0.method_14(gClass);
								return;
							}
							class16_0.method_2().dateTime_0 = DateTime.Now;
							class16_0.method_2().int_23++;
						}
						if (class16_0.method_2().uint_6 == 2u)
						{
							Phoenix.smethod_15().method_16().method_1(2u, class16_0);
						}
						class16_0.method_2().string_5 = text2;
						class16_0.method_2().string_6 = text.ToLower();
						using (Class6 class2 = Phoenix.smethod_12().method_0())
						{
							class2.method_0("look", text2);
							class2.method_0("gender", text);
							class2.method_1("UPDATE users SET look = @look, gender = @gender WHERE id = '" + class16_0.method_2().uint_0 + "' LIMIT 1;");
						}
						GClass5 gClass2 = new GClass5(266u);
						gClass2.method_9(-1);
						gClass2.method_7(class16_0.method_2().string_5);
						gClass2.method_7(class16_0.method_2().string_6.ToLower());
						gClass2.method_7(class16_0.method_2().string_4);
						gClass2.method_9(class16_0.method_2().int_13);
						gClass2.method_7("");
						class16_0.method_14(gClass2);
						GClass5 gClass3 = new GClass5(266u);
						gClass3.method_9(@class.int_0);
						gClass3.method_7(class16_0.method_2().string_5);
						gClass3.method_7(class16_0.method_2().string_6.ToLower());
						gClass3.method_7(class16_0.method_2().string_4);
						gClass3.method_9(class16_0.method_2().int_13);
						gClass3.method_7("");
						class14_.method_59(gClass3, null);
						Phoenix.smethod_15().method_12().method_3(class16_0, 1u, 1);
					}
				}
			}
		}
	}
}
