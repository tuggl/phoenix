using System;
using System.Data;
namespace ns0
{
	internal sealed class Class201 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			uint num = class18_0.method_15();
			DataRow dataRow = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataRow = @class.method_4("SELECT state, timestamp, total_price, extra_data, item_id, furni_id FROM catalog_marketplace_offers WHERE offer_id = '" + num + "' LIMIT 1");
			}
			if (dataRow == null || (string)dataRow["state"] != "1" || (double)dataRow["timestamp"] <= Phoenix.smethod_15().method_6().method_22().method_3())
			{
				class16_0.method_8(Class8.smethod_1("marketplace_error_expired"));
			}
			else
			{
				Class40 class2 = Phoenix.smethod_15().method_8().method_2((uint)dataRow["item_id"]);
				if (class2 != null)
				{
					if ((int)dataRow["total_price"] >= 1)
					{
						if (class16_0.method_2().int_2 < (int)dataRow["total_price"])
						{
							class16_0.method_8(Class8.smethod_1("marketplace_error_credits"));
							return;
						}
						class16_0.method_2().int_2 -= (int)dataRow["total_price"];
						class16_0.method_2().method_13(true);
					}
					Phoenix.smethod_15().method_6().method_9(class16_0, class2, 1, (string)dataRow["extra_data"], false, (uint)dataRow["furni_id"]);
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_1("UPDATE catalog_marketplace_offers SET state = '2' WHERE offer_id = '" + num + "' LIMIT 1");
						int num2 = 0;
						try
						{
							num2 = @class.method_6("SELECT id FROM catalog_marketplace_data WHERE daysago = 0 AND sprite = " + class2.int_0 + " LIMIT 1;");
						}
						catch
						{
						}
						if (num2 > 0)
						{
							@class.method_1(string.Concat(new object[]
							{
								"UPDATE catalog_marketplace_data SET sold = sold + 1, avgprice = (avgprice + ",
								(int)dataRow["total_price"],
								") WHERE id = ",
								num2,
								" LIMIT 1;"
							}));
						}
						else
						{
							@class.method_1(string.Concat(new object[]
							{
								"INSERT INTO catalog_marketplace_data (sprite, sold, avgprice, daysago) VALUES ('",
								class2.int_0,
								"', 1, ",
								(int)dataRow["total_price"],
								", 0)"
							}));
						}
						if (Phoenix.smethod_15().method_6().method_22().dictionary_0.ContainsKey(class2.int_0) && Phoenix.smethod_15().method_6().method_22().dictionary_1.ContainsKey(class2.int_0))
						{
							int num3 = Phoenix.smethod_15().method_6().method_22().dictionary_1[class2.int_0];
							int num4 = Phoenix.smethod_15().method_6().method_22().dictionary_0[class2.int_0];
							num4 += (int)dataRow["total_price"];
							Phoenix.smethod_15().method_6().method_22().dictionary_0.Remove(class2.int_0);
							Phoenix.smethod_15().method_6().method_22().dictionary_0.Add(class2.int_0, num4);
							Phoenix.smethod_15().method_6().method_22().dictionary_1.Remove(class2.int_0);
							Phoenix.smethod_15().method_6().method_22().dictionary_1.Add(class2.int_0, num3 + 1);
						}
						else
						{
							if (!Phoenix.smethod_15().method_6().method_22().dictionary_0.ContainsKey(class2.int_0))
							{
								Phoenix.smethod_15().method_6().method_22().dictionary_0.Add(class2.int_0, (int)dataRow["total_price"]);
							}
							if (!Phoenix.smethod_15().method_6().method_22().dictionary_1.ContainsKey(class2.int_0))
							{
								Phoenix.smethod_15().method_6().method_22().dictionary_1.Add(class2.int_0, 1);
							}
						}
					}
					GClass5 gClass = new GClass5(67u);
					gClass.method_11(class2.UInt32_0);
					gClass.method_7(class2.string_1);
					gClass.method_9((int)dataRow["total_price"]);
					gClass.method_9(0);
					gClass.method_9(0);
					gClass.method_9(1);
					gClass.method_7(class2.char_0.ToString());
					gClass.method_9(class2.int_0);
					gClass.method_7("");
					gClass.method_9(1);
					gClass.method_9(-1);
					gClass.method_7("");
					class16_0.method_14(gClass);
					class16_0.method_14(Phoenix.smethod_15().method_6().method_22().method_5(-1, -1, "", 1));
				}
			}
		}
	}
}
