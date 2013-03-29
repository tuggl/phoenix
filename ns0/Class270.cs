using System;
using System.Collections.Generic;
using System.Text;
namespace ns0
{
	internal sealed class Class270 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
			if (@class != null && @class.method_27(class16_0, true))
			{
				class18_0.method_14();
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				int num = class18_0.method_14();
				int num2 = class18_0.method_14();
				int num3 = class18_0.method_14();
				for (int i = 0; i < num3; i++)
				{
					int num4 = class18_0.method_14();
					int num5 = class18_0.method_14();
					if (num4 < 0 || num4 > 10 || (num5 < 1 || num5 > 27) || dictionary.ContainsKey(num4))
					{
						return;
					}
					dictionary.Add(num4, num5);
				}
				if (num >= 1 && num <= 24 && (num2 >= 0 && num2 <= 11))
				{
					StringBuilder stringBuilder = new StringBuilder();
					int num6 = 0;
					foreach (KeyValuePair<int, int> current in dictionary)
					{
						if (num6 > 0)
						{
							stringBuilder.Append("|");
						}
						stringBuilder.Append(current.Key + "," + current.Value);
						num6++;
					}
					using (Class6 class2 = Phoenix.smethod_12().method_0())
					{
						class2.method_1(string.Concat(new object[]
						{
							"UPDATE rooms SET icon_bg = '",
							num,
							"', icon_fg = '",
							num2,
							"', icon_items = '",
							stringBuilder.ToString(),
							"' WHERE id = '",
							@class.UInt32_0,
							"' LIMIT 1"
						}));
					}
					@class.Class29_0 = new Class29(num, num2, dictionary);
					GClass5 gClass = new GClass5(457u);
					gClass.method_11(@class.UInt32_0);
					gClass.method_13(true);
					class16_0.method_14(gClass);
					GClass5 gClass2 = new GClass5(456u);
					gClass2.method_11(@class.UInt32_0);
					class16_0.method_14(gClass2);
					Class27 class27_ = @class.Class27_0;
					GClass5 gClass3 = new GClass5(454u);
					gClass3.method_13(false);
					class27_.method_3(gClass3, false, false);
					class16_0.method_14(gClass3);
				}
			}
		}
	}
}
