using System;
namespace ns0
{
	internal sealed class Class119 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				uint uint_ = class18_0.method_15();
				Class63 class2 = @class.method_28(uint_);
				string text = class2.method_7().string_2.ToLower();
				switch (text)
				{
				case "wf_act_give_phx":
				{
					class18_0.method_13();
					string text2 = class18_0.method_9();
					text2 = Phoenix.smethod_8(text2, false, true);
					text2 = Class58.smethod_4(text2);
					if (!(text2 == class2.string_2))
					{
						string string_ = text2.Split(new char[]
						{
							':'
						})[0].ToLower();
						if (Phoenix.smethod_15().method_4().method_12(string_, class16_0))
						{
							class2.string_2 = text2;
						}
						else
						{
							class16_0.method_2().method_28(Class8.smethod_1("wired_error_permissions"));
						}
					}
					break;
				}
				case "wf_cnd_phx":
				{
					class18_0.method_13();
					string text2 = class18_0.method_9();
					text2 = Phoenix.smethod_8(text2, false, true);
					text2 = Class58.smethod_4(text2);
					if (!(text2 == class2.string_2))
					{
						string string_ = text2.Split(new char[]
						{
							':'
						})[0].ToLower();
						if (Phoenix.smethod_15().method_4().method_11(string_, class16_0))
						{
							class2.string_2 = text2;
						}
						else
						{
							class16_0.method_2().method_28(Class8.smethod_1("wired_error_permissions"));
						}
					}
					break;
				}
				case "wf_act_saymsg":
				{
					class18_0.method_13();
					string text2 = class18_0.method_9();
					text2 = Phoenix.smethod_8(text2, false, true);
					if (text2.Length > 100)
					{
						text2 = text2.Substring(0, 100);
					}
					class2.string_2 = text2;
					break;
				}
				case "wf_trg_furnistate":
				case "wf_trg_onfurni":
				case "wf_trg_offfurni":
				case "wf_act_moveuser":
				case "wf_act_togglefurni":
				{
					class18_0.method_13();
					class18_0.method_9();
					class2.string_2 = class18_0.ToString().Substring(class18_0.Int32_0 - (class18_0.Int32_1 - 2));
					class2.string_2 = class2.string_2.Substring(0, class2.string_2.Length - 2);
					class18_0.method_0();
					class2 = @class.method_28(class18_0.method_15());
					class18_0.method_13();
					class18_0.method_9();
					int num2 = class18_0.method_14();
					class2.string_3 = "";
					for (int i = 0; i < num2; i++)
					{
						class2.string_3 = class2.string_3 + "," + Convert.ToString(class18_0.method_15());
					}
					if (class2.string_3.Length > 0)
					{
						class2.string_3 = class2.string_3.Substring(1);
					}
					break;
				}
				case "wf_act_givepoints":
					class18_0.method_14();
					class2.string_2 = Convert.ToString(class18_0.method_14());
					class2.string_3 = Convert.ToString(class18_0.method_14());
					break;
				case "wf_act_moverotate":
				{
					class18_0.method_14();
					class2.string_2 = Convert.ToString(class18_0.method_14());
					class2.string_3 = Convert.ToString(class18_0.method_14());
					class18_0.method_9();
					int num2 = class18_0.method_14();
					class2.string_4 = "";
					class2.string_5 = "";
					if (num2 > 0)
					{
						class2.string_5 = GClass9.smethod_0(num2);
						for (int i = 0; i < num2; i++)
						{
							int num3 = class18_0.method_14();
							class2.string_5 += GClass9.smethod_0(num3);
							class2.string_4 = class2.string_4 + "," + Convert.ToString(num3);
						}
						class2.string_4 = class2.string_4.Substring(1);
					}
					class2.string_6 = Convert.ToString(class18_0.method_14());
					break;
				}
				case "wf_act_matchfurni":
				{
					class18_0.method_14();
					class2.string_3 = "";
					if (class18_0.method_13())
					{
						Class63 expr_4A8 = class2;
						expr_4A8.string_3 += "I";
					}
					else
					{
						Class63 expr_4C0 = class2;
						expr_4C0.string_3 += "H";
					}
					if (class18_0.method_13())
					{
						Class63 expr_4E1 = class2;
						expr_4E1.string_3 += "I";
					}
					else
					{
						Class63 expr_4F9 = class2;
						expr_4F9.string_3 += "H";
					}
					if (class18_0.method_13())
					{
						Class63 expr_51A = class2;
						expr_51A.string_3 += "I";
					}
					else
					{
						Class63 expr_532 = class2;
						expr_532.string_3 += "H";
					}
					class18_0.method_9();
					int num2 = class18_0.method_14();
					class2.string_2 = "";
					class2.string_4 = "";
					class2.string_5 = "";
					if (num2 > 0)
					{
						class2.string_5 = GClass9.smethod_0(num2);
						for (int i = 0; i < num2; i++)
						{
							int num3 = class18_0.method_14();
							class2.string_5 += GClass9.smethod_0(num3);
							class2.string_4 = class2.string_4 + "," + Convert.ToString(num3);
							Class63 class3 = @class.method_28(Convert.ToUInt32(num3));
							Class63 expr_5E6 = class2;
							object string_2 = expr_5E6.string_2;
							expr_5E6.string_2 = string.Concat(new object[]
							{
								string_2,
								";",
								class3.Int32_0,
								",",
								class3.Int32_1,
								",",
								class3.Double_0,
								",",
								class3.int_3,
								",",
								class3.string_0
							});
						}
						class2.string_4 = class2.string_4.Substring(1);
						class2.string_2 = class2.string_2.Substring(1);
					}
					class2.string_6 = Convert.ToString(class18_0.method_14());
					break;
				}
				}
				class2.method_5(true, false);
			}
			catch
			{
			}
		}
	}
}
