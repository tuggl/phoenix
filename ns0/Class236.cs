using System;
using System.Data;
namespace ns0
{
	internal sealed class Class236 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			try
			{
				Class14 @class = Phoenix.smethod_15().method_9().method_19(class16_0.method_2().uint_3);
				if (@class != null && @class.method_27(class16_0, true))
				{
					Class63 class2 = @class.method_28(class18_0.method_15());
					if (class2 != null)
					{
						DataRow dataRow = null;
						using (Class6 class3 = Phoenix.smethod_12().method_0())
						{
							dataRow = class3.method_4("SELECT base_id,amount,extra_data FROM user_presents WHERE item_id = '" + class2.uint_0 + "' LIMIT 1");
						}
						if (dataRow != null)
						{
							Class40 class4 = Phoenix.smethod_15().method_8().method_2((uint)dataRow["base_id"]);
							if (class4 != null)
							{
								@class.method_29(class16_0, class2.uint_0, true, true);
								GClass5 gClass = new GClass5(219u);
								gClass.method_11(class2.uint_0);
								class16_0.method_14(gClass);
								GClass5 gClass2 = new GClass5(129u);
								gClass2.method_7(class4.char_0.ToString());
								gClass2.method_9(class4.int_0);
								gClass2.method_7(class4.string_1);
								class16_0.method_14(gClass2);
								using (Class6 class3 = Phoenix.smethod_12().method_0())
								{
									class3.method_1("DELETE FROM user_presents WHERE item_id = '" + class2.uint_0 + "' LIMIT 1");
								}
								Phoenix.smethod_15().method_6().method_9(class16_0, class4, (int)dataRow["amount"], (string)dataRow["extra_data"], true, 0u);
							}
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
