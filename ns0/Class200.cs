using System;
using System.Data;
namespace ns0
{
	internal sealed class Class200 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			if (class16_0 != null)
			{
				uint num = class18_0.method_15();
				DataRow dataRow = null;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					dataRow = @class.method_4("SELECT furni_id, item_id, user_id, extra_data, offer_id, state, timestamp FROM catalog_marketplace_offers WHERE offer_id = '" + num + "' LIMIT 1");
				}
				if (dataRow != null)
				{
					int num2 = (int)Math.Floor(((double)dataRow["timestamp"] + 172800.0 - Phoenix.smethod_6()) / 60.0);
					int num3 = int.Parse(dataRow["state"].ToString());
					if (num2 <= 0)
					{
						num3 = 3;
					}
					if ((uint)dataRow["user_id"] == class16_0.method_2().uint_0 && num3 != 2)
					{
						Class40 class2 = Phoenix.smethod_15().method_8().method_2((uint)dataRow["item_id"]);
						if (class2 != null)
						{
							Phoenix.smethod_15().method_6().method_9(class16_0, class2, 1, (string)dataRow["extra_data"], false, (uint)dataRow["furni_id"]);
							using (Class6 @class = Phoenix.smethod_12().method_0())
							{
								@class.method_1("DELETE FROM catalog_marketplace_offers WHERE offer_id = '" + num + "' LIMIT 1");
							}
							GClass5 gClass = new GClass5(614u);
							gClass.method_11((uint)dataRow["offer_id"]);
							gClass.method_13(true);
							class16_0.method_14(gClass);
						}
					}
				}
			}
		}
	}
}
