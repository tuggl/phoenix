using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class198 : Interface0
	{
		public void imethod_0(Class16 class16_0, Class18 class18_0)
		{
			int int_ = class18_0.method_14();
			int num = class18_0.method_14();
			GClass5 gClass = new GClass5(617u);
			gClass.method_9(1);
			gClass.method_9(Phoenix.smethod_15().method_6().method_22().method_7(num));
			Dictionary<int, DataRow> dictionary = new Dictionary<int, DataRow>();
			DataTable dataTable = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataTable = @class.method_3("SELECT * FROM catalog_marketplace_data WHERE daysago > -30 AND sprite = " + num + " LIMIT 30;");
			}
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					dictionary.Add(Convert.ToInt32(dataRow["daysago"]), dataRow);
				}
			}
			gClass.method_9(30);
			gClass.method_9(29);
			for (int i = -29; i < 0; i++)
			{
				gClass.method_9(i);
				if (dictionary.ContainsKey(i + 1))
				{
					gClass.method_9(Convert.ToInt32(dictionary[i + 1]["avgprice"]) / Convert.ToInt32(dictionary[i + 1]["sold"]));
					gClass.method_9(Convert.ToInt32(dictionary[i + 1]["sold"]));
				}
				else
				{
					gClass.method_9(0);
					gClass.method_9(0);
				}
			}
			gClass.method_9(int_);
			gClass.method_9(num);
			class16_0.method_14(gClass);
		}
	}
}
