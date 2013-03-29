using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class4
	{
		public static Dictionary<int, Class5> dictionary_0;
		public Class4()
		{
			Class4.dictionary_0 = new Dictionary<int, Class5>();
		}
		public static void smethod_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading groups...");
			Class4.smethod_1();
			DataTable dataTable = class6_0.method_3("SELECT * FROM groups;");
			foreach (DataRow dataRow in dataTable.Rows)
			{
				Class4.dictionary_0.Add((int)dataRow["id"], new Class5((int)dataRow["id"], dataRow, class6_0));
			}
			GClass4.smethod_1("completed!");
		}
		public static void smethod_1()
		{
			Class4.dictionary_0.Clear();
		}
		public static Class5 smethod_2(int int_0)
		{
			Class5 result;
			if (Class4.dictionary_0.ContainsKey(int_0))
			{
				result = Class4.dictionary_0[int_0];
			}
			else
			{
				result = null;
			}
			return result;
		}
		public static void smethod_3(Class6 class6_0, int int_0)
		{
			Class5 @class = Class4.smethod_2(int_0);
			if (@class != null)
			{
				DataRow dataRow = class6_0.method_4("SELECT * FROM groups WHERE id = " + int_0 + " LIMIT 1");
				@class.string_0 = (string)dataRow["name"];
				@class.string_2 = (string)dataRow["badge"];
				@class.uint_0 = (uint)dataRow["roomid"];
				@class.string_1 = (string)dataRow["desc"];
				@class.string_3 = (string)dataRow["locked"];
				@class.list_0.Clear();
				DataTable dataTable = class6_0.method_3("SELECT userid FROM group_memberships WHERE groupid = " + int_0 + ";");
				foreach (DataRow dataRow2 in dataTable.Rows)
				{
					@class.method_0((int)dataRow2["userid"]);
				}
			}
		}
	}
}
