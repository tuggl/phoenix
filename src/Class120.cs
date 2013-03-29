using System;
namespace ns0
{
	internal sealed class Class120 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			Class63 class2 = @class.method_28(class18_0.method_15());
			if (@class != null && class2 != null)
			{
				string text = class2.method_7().string_2.ToLower();
				if (text != null)
				{
					if (!(text == "wf_trg_onsay"))
					{
						if (!(text == "wf_trg_enterroom"))
						{
							if (!(text == "wf_trg_timer"))
							{
								if (!(text == "wf_trg_attime"))
								{
									if (text == "wf_trg_atscore")
									{
										class18_0.method_13();
										string text2 = class18_0.ToString().Substring(class18_0.Int32_0 - (class18_0.Int32_1 - 2));
										string[] array = text2.Split(new char[]
										{
											'@'
										});
										class2.string_3 = array[0];
										class2.string_2 = Convert.ToString(class18_0.method_14());
									}
								}
								else
								{
									class18_0.method_13();
									string text2 = class18_0.ToString().Substring(class18_0.Int32_0 - (class18_0.Int32_1 - 2));
									string[] array = text2.Split(new char[]
									{
										'@'
									});
									class2.string_3 = array[0];
									class2.string_2 = Convert.ToString(Convert.ToString((double)class18_0.method_14() * 0.5));
								}
							}
							else
							{
								class18_0.method_13();
								string text2 = class18_0.ToString().Substring(class18_0.Int32_0 - (class18_0.Int32_1 - 2));
								string[] array = text2.Split(new char[]
								{
									'@'
								});
								class2.string_3 = array[0];
								class2.string_2 = Convert.ToString(Convert.ToString((double)class18_0.method_14() * 0.5));
							}
						}
						else
						{
							class18_0.method_13();
							string text3 = class18_0.method_9();
							class2.string_2 = text3;
						}
					}
					else
					{
						class18_0.method_13();
						bool value = class18_0.method_13();
						string text3 = class18_0.method_9();
						text3 = Phoenix.smethod_8(text3, false, true);
						if (text3.Length > 100)
						{
							text3 = text3.Substring(0, 100);
						}
						class2.string_2 = text3;
						class2.string_3 = Convert.ToString(value);
					}
				}
				class2.method_5(true, false);
			}
		}
	}
}
