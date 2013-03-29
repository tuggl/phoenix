using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class5
	{
		public int int_0;
		public string string_0;
		public string string_1;
		public int int_1;
		public List<int> list_0;
		public string string_2;
		public uint uint_0;
		public string string_3;
		public Class5(int int_2, DataRow dataRow_0, Class6 class6_0)
		{
			this.int_0 = int_2;
			this.string_0 = (string)dataRow_0["name"];
			this.string_1 = (string)dataRow_0["desc"];
			this.int_1 = (int)dataRow_0["OwnerId"];
			this.string_2 = (string)dataRow_0["badge"];
			this.uint_0 = (uint)dataRow_0["roomid"];
			this.string_3 = (string)dataRow_0["locked"];
			this.list_0 = new List<int>();
			DataTable dataTable = class6_0.method_3("SELECT userid FROM group_memberships WHERE groupid = " + int_2 + ";");
			foreach (DataRow dataRow in dataTable.Rows)
			{
				this.method_0((int)dataRow["userid"]);
			}
		}
		public void method_0(int int_2)
		{
			if (!this.list_0.Contains(int_2))
			{
				this.list_0.Add(int_2);
			}
		}
		public void method_1(int int_2)
		{
			if (this.list_0.Contains(int_2))
			{
				this.list_0.Remove(int_2);
			}
		}
	}
}
