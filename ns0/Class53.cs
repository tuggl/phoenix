using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class53
	{
		private uint uint_0;
		private Dictionary<string, Class52> dictionary_0;
		public List<string> List_0
		{
			get
			{
				List<string> list = new List<string>();
				using (GStruct0.smethod_0(this.dictionary_0.Values))
				{
					foreach (Class52 current in this.dictionary_0.Values)
					{
						list.Add(current.String_0);
					}
				}
				return list;
			}
		}
		public Class53(uint uint_1, Class12 class12_0)
		{
			this.uint_0 = uint_1;
			this.dictionary_0 = new Dictionary<string, Class52>();
			DataTable dataTable_ = class12_0.DataTable_4;
			if (dataTable_ != null)
			{
				foreach (DataRow dataRow in dataTable_.Rows)
				{
					this.dictionary_0.Add((string)dataRow["subscription_id"], new Class52((string)dataRow["subscription_id"], (int)dataRow["timestamp_activated"], (int)dataRow["timestamp_expire"]));
				}
			}
		}
		public void method_0()
		{
			this.dictionary_0.Clear();
		}
		public Class52 method_1(string string_0)
		{
			Class52 result;
			if (this.dictionary_0.ContainsKey(string_0))
			{
				result = this.dictionary_0[string_0];
			}
			else
			{
				result = null;
			}
			return result;
		}
		public bool method_2(string string_0)
		{
			bool result;
			if (!this.dictionary_0.ContainsKey(string_0))
			{
				result = false;
			}
			else
			{
				Class52 @class = this.dictionary_0[string_0];
				result = @class.method_0();
			}
			return result;
		}
		public void method_3(string string_0, int int_0)
		{
			string_0 = string_0.ToLower();
			if (this.dictionary_0.ContainsKey(string_0))
			{
				Class52 @class = this.dictionary_0[string_0];
				@class.method_1(int_0);
				if (@class.Int32_0 <= 0 || @class.Int32_0 >= 2147483647)
				{
					return;
				}
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_0("subcrbr", string_0);
					class2.method_1(string.Concat(new object[]
					{
						"UPDATE user_subscriptions SET timestamp_expire = '",
						@class.Int32_0,
						"' WHERE user_id = '",
						this.uint_0,
						"' AND subscription_id = @subcrbr LIMIT 1"
					}));
					return;
				}
			}
			if (!this.dictionary_0.ContainsKey("habbo_vip"))
			{
				int num = (int)Phoenix.smethod_6();
				int num2 = (int)Phoenix.smethod_6() + int_0;
				Class52 class3 = new Class52(string_0, num, num2);
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_0("subcrbr", string_0);
					class2.method_1(string.Concat(new object[]
					{
						"INSERT INTO user_subscriptions (user_id,subscription_id,timestamp_activated,timestamp_expire) VALUES ('",
						this.uint_0,
						"',@subcrbr,'",
						num,
						"','",
						num2,
						"')"
					}));
				}
				this.dictionary_0.Add(class3.String_0.ToLower(), class3);
			}
		}
	}
}
