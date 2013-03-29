using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class62
	{
		public List<Class61> list_0;
		public Class62()
		{
			this.list_0 = new List<Class61>();
		}
		public void method_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading bans..");
			this.list_0.Clear();
			DataTable dataTable = class6_0.method_3("SELECT bantype,value,reason,expire FROM bans WHERE expire > '" + Phoenix.smethod_6() + "'");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Enum4 enum4_ = Enum4.const_0;
					if ((string)dataRow["bantype"] == "user")
					{
						enum4_ = Enum4.const_1;
					}
					this.list_0.Add(new Class61(enum4_, (string)dataRow["value"], (string)dataRow["reason"], (double)dataRow["expire"]));
				}
				GClass4.smethod_1("completed!");
			}
		}
		public void method_1(Class16 class16_0)
		{
			foreach (Class61 current in this.list_0)
			{
				if (!current.Boolean_0)
				{
					if (current.enum4_0 == Enum4.const_0 && class16_0.method_0().String_0 == current.string_0)
					{
						throw new GException1(current.string_1);
					}
					if (class16_0.method_2() != null && (current.enum4_0 == Enum4.const_1 && class16_0.method_2().string_0.ToLower() == current.string_0.ToLower()))
					{
						throw new GException1(current.string_1);
					}
				}
			}
		}
		public void method_2(Class16 class16_0, string string_0, double double_0, string string_1, bool bool_0)
		{
			if (!class16_0.method_2().bool_0)
			{
				Enum4 enum4_ = Enum4.const_1;
				string text = class16_0.method_2().string_0;
				string object_ = "user";
				double num = Phoenix.smethod_6() + double_0;
				if (bool_0)
				{
					enum4_ = Enum4.const_0;
					if (!Class13.bool_20)
					{
						text = class16_0.method_0().String_0;
					}
					else
					{
						using (Class6 @class = Phoenix.smethod_12().method_0())
						{
							text = @class.method_5("SELECT ip_last FROM users WHERE id = " + class16_0.method_2().uint_0 + " LIMIT 1;");
						}
					}
					object_ = "ip";
				}
				this.list_0.Add(new Class61(enum4_, text, string_1, num));
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("rawvar", object_);
					@class.method_0("var", text);
					@class.method_0("reason", string_1);
					@class.method_0("mod", string_0);
					@class.method_1(string.Concat(new object[]
					{
						"INSERT INTO bans (bantype,value,reason,expire,added_by,added_date,appeal_state) VALUES (@rawvar,@var,@reason,'",
						num,
						"',@mod,'",
						DateTime.Now.ToLongDateString(),
						"', '1')"
					}));
				}
				if (bool_0)
				{
					DataTable dataTable = null;
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_0("var", text);
						dataTable = @class.method_3("SELECT id FROM users WHERE ip_last = @var");
					}
					if (dataTable == null)
					{
						goto IL_268;
					}
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							using (Class6 @class = Phoenix.smethod_12().method_0())
							{
								@class.method_1("UPDATE user_info SET bans = bans + 1 WHERE user_id = '" + (uint)dataRow["id"] + "' LIMIT 1");
							}
						}
						goto IL_268;
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
				}
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1("UPDATE user_info SET bans = bans + 1 WHERE user_id = '" + class16_0.method_2().uint_0 + "' LIMIT 1");
				}
				IL_268:
				class16_0.method_7("You have been banned: " + string_1);
				class16_0.method_12();
			}
		}
	}
}
