using System;
namespace ns0
{
	internal sealed class Class255 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && class16_0 != null)
			{
				if (class16_0.method_2().bool_3)
				{
					class16_0.method_8(Class8.smethod_1("error_muted"));
				}
				else
				{
					if (class16_0.method_2().method_3("ignore_roommute") || !@class.bool_4)
					{
						string text = Phoenix.smethod_7(class18_0.method_9());
						string text2 = text.Split(new char[]
						{
							' '
						})[0];
						string text3 = text.Substring(text2.Length + 1);
						text3 = Class58.smethod_4(text3);
						Class33 class2 = @class.method_53(class16_0.method_2().uint_0);
						Class33 class3 = @class.method_56(text2);
						if (class16_0.method_2().method_4() > 0)
						{
							TimeSpan timeSpan = DateTime.Now - class16_0.method_2().dateTime_0;
							if (timeSpan.Seconds > 4)
							{
								class16_0.method_2().int_23 = 0;
							}
							if (timeSpan.Seconds < 4 && class16_0.method_2().int_23 > 5 && !class2.Boolean_4)
							{
								GClass5 gClass = new GClass5(27u);
								gClass.method_9(class16_0.method_2().method_4());
								class16_0.method_14(gClass);
								class16_0.method_2().bool_3 = true;
								class16_0.method_2().int_4 = class16_0.method_2().method_4();
								return;
							}
							class16_0.method_2().dateTime_0 = DateTime.Now;
							class16_0.method_2().int_23++;
						}
						GClass5 gClass2 = new GClass5(25u);
						gClass2.method_9(class2.int_0);
						gClass2.method_7(text3);
						gClass2.method_13(false);
						if (class2 != null && !class2.Boolean_4)
						{
							class2.method_16().method_14(gClass2);
						}
						class2.method_0();
						if (class3 != null && !class3.Boolean_4 && (class3.method_16().method_2().list_2.Count <= 0 || !class3.method_16().method_2().list_2.Contains(class16_0.method_2().uint_0)))
						{
							class3.method_16().method_14(gClass2);
							if (Class13.Boolean_4 && !class16_0.method_2().bool_0)
							{
								using (Class6 class4 = Phoenix.smethod_12().method_0())
								{
									class4.method_0("message", "<Whisper to " + class3.method_16().method_2().string_0 + ">: " + text3);
									class4.method_1(string.Concat(new object[]
									{
										"INSERT INTO chatlogs (user_id,room_id,hour,minute,timestamp,message,user_name,full_date) VALUES ('",
										class16_0.method_2().uint_0,
										"','",
										@class.UInt32_0,
										"','",
										DateTime.Now.Hour,
										"','",
										DateTime.Now.Minute,
										"',UNIX_TIMESTAMP(),@message,'",
										class16_0.method_2().string_0,
										"','",
										DateTime.Now.ToLongDateString(),
										"')"
									}));
								}
							}
						}
					}
				}
			}
		}
	}
}
