using System;
using System.Data;
namespace ns0
{
	internal sealed class Class154 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int num = class18_0.method_14();
			if (num > 0 && (class16_0 != null && class16_0.method_2() != null))
			{
				class16_0.method_2().int_0 = num;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE user_stats SET groupid = ",
						num,
						" WHERE id = ",
						class16_0.method_2().uint_0,
						" LIMIT 1;"
					}));
				}
				DataTable dataTable_ = class16_0.method_2().dataTable_0;
				if (dataTable_ != null)
				{
					GClass5 gClass = new GClass5(915u);
					gClass.method_9(dataTable_.Rows.Count);
					foreach (DataRow dataRow in dataTable_.Rows)
					{
						Class5 class2 = Class4.smethod_2((int)dataRow["groupid"]);
						gClass.method_9(class2.int_0);
						gClass.method_7(class2.string_0);
						gClass.method_7(class2.string_2);
						if (class16_0.method_2().int_0 == class2.int_0)
						{
							gClass.method_13(true);
						}
						else
						{
							gClass.method_13(false);
						}
					}
					class16_0.method_14(gClass);
					if (class16_0.method_2().Boolean_0)
					{
						Class14 class14_ = class16_0.method_2().Class14_0;
						Class33 class3 = class14_.method_53(class16_0.method_2().uint_0);
						GClass5 gClass2 = new GClass5(28u);
						gClass2.method_9(1);
						class3.method_14(gClass2);
						class14_.method_59(gClass2, null);
						Class5 class4 = Class4.smethod_2(class16_0.method_2().int_0);
						if (!class14_.list_17.Contains(class4))
						{
							class14_.list_17.Add(class4);
							GClass5 gClass3 = new GClass5(309u);
							gClass3.method_9(class14_.list_17.Count);
							foreach (Class5 class2 in class14_.list_17)
							{
								gClass3.method_9(class2.int_0);
								gClass3.method_7(class2.string_2);
							}
							class14_.method_59(gClass3, null);
						}
						else
						{
							foreach (Class5 current in class14_.list_17)
							{
								if (current == class4 && current.string_2 != class4.string_2)
								{
									GClass5 gClass3 = new GClass5(309u);
									gClass3.method_9(class14_.list_17.Count);
									foreach (Class5 class2 in class14_.list_17)
									{
										gClass3.method_9(class2.int_0);
										gClass3.method_7(class2.string_2);
									}
									class14_.method_59(gClass3, null);
								}
							}
						}
					}
				}
			}
		}
	}
}
