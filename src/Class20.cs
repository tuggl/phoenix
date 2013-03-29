using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class20
	{
		public List<Class19> list_0;
		public Class20()
		{
			this.list_0 = new List<Class19>();
		}
		public void method_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Room Adverts..");
			this.list_0.Clear();
			DataTable dataTable = class6_0.method_3("SELECT * FROM room_ads WHERE enabled = '1'");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					this.list_0.Add(new Class19((uint)dataRow["id"], (string)dataRow["ad_image"], (string)dataRow["ad_link"], (int)dataRow["views"], (int)dataRow["views_limit"]));
				}
				GClass4.smethod_1("completed!");
			}
		}
		public Class19 method_1()
		{
			Class19 result;
			if (this.list_0.Count <= 0)
			{
				result = null;
			}
			else
			{
				int index;
				do
				{
					index = Phoenix.smethod_5(0, this.list_0.Count - 1);
				}
				while (this.list_0[index] == null || this.list_0[index].Boolean_0);
				result = this.list_0[index];
			}
			return result;
		}
	}
}
