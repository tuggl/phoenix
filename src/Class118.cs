using System;
namespace ns0
{
	internal sealed class Class118 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				uint uint_ = class18_0.method_15();
				Class63 class2 = @class.method_28(uint_);
				string text = class2.method_7().string_2.ToLower();
				if (text != null && (text == "wf_cnd_trggrer_on_frn" || text == "wf_cnd_furnis_hv_avtrs" || text == "wf_cnd_has_furni_on"))
				{
					class18_0.method_13();
					class18_0.method_9();
					class2.string_2 = class18_0.ToString().Substring(class18_0.Int32_0 - (class18_0.Int32_1 - 2));
					class2.string_2 = class2.string_2.Substring(0, class2.string_2.Length - 1);
					class18_0.method_0();
					class2 = @class.method_28(class18_0.method_15());
					class18_0.method_13();
					class18_0.method_9();
					int num = class18_0.method_14();
					class2.string_3 = "";
					for (int i = 0; i < num; i++)
					{
						class2.string_3 = class2.string_3 + "," + Convert.ToString(class18_0.method_15());
					}
					if (class2.string_3.Length > 0)
					{
						class2.string_3 = class2.string_3.Substring(1);
					}
				}
			}
			catch
			{
			}
		}
	}
}
