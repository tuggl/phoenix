using System;
using System.Data;
namespace ns0
{
	internal sealed class Class153 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int num = class18_0.method_14();
			if (num > 0 && (class16_0 != null && class16_0.method_2() != null))
			{
				class16_0.method_2().int_0 = 0;
				if (class16_0.method_2().Boolean_0)
				{
					Class14 class14_ = class16_0.method_2().Class14_0;
					Class33 @class = class14_.method_53(class16_0.method_2().uint_0);
					GClass5 gClass = new GClass5(28u);
					gClass.method_9(1);
					@class.method_14(gClass);
					class14_.method_59(gClass, null);
				}
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_1("UPDATE user_stats SET groupid = 0 WHERE id = " + class16_0.method_2().uint_0 + " LIMIT 1;");
				}
				DataTable dataTable_ = class16_0.method_2().dataTable_0;
				if (dataTable_ != null)
				{
					GClass5 gClass2 = new GClass5(915u);
					gClass2.method_9(dataTable_.Rows.Count);
					foreach (DataRow dataRow in dataTable_.Rows)
					{
						Class5 class3 = Class4.smethod_2((int)dataRow["groupid"]);
						gClass2.method_9(class3.int_0);
						gClass2.method_7(class3.string_0);
						gClass2.method_7(class3.string_2);
						if (class16_0.method_2().int_0 == class3.int_0)
						{
							gClass2.method_13(true);
						}
						else
						{
							gClass2.method_13(false);
						}
					}
					class16_0.method_14(gClass2);
				}
			}
		}
	}
}
