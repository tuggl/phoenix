using System;
using System.Data;
namespace ns0
{
	internal sealed class Class194 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			DataTable dataTable = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataTable = @class.method_3("SELECT asking_price FROM catalog_marketplace_offers WHERE user_id = '" + class16_0.method_2().uint_0 + "' AND state = '2'");
			}
			if (dataTable != null)
			{
				int num = 0;
				foreach (DataRow dataRow in dataTable.Rows)
				{
					num += (int)dataRow["asking_price"];
				}
				if (num >= 1)
				{
					class16_0.method_2().int_2 += num;
					class16_0.method_2().method_13(true);
				}
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1("DELETE FROM catalog_marketplace_offers WHERE user_id = '" + class16_0.method_2().uint_0 + "' AND state = '2'");
				}
			}
		}
	}
}
