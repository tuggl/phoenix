using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace ns0
{
	internal sealed class Class67
	{
		public bool bool_0;
		public int int_0;
		public List<Class68> list_0;
		public uint uint_0;
		public Class67(uint uint_1)
		{
			this.uint_0 = uint_1;
			DataRow dataRow = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataRow = @class.method_4("SELECT enabled,current_preset,preset_one,preset_two,preset_three FROM room_items_moodlight WHERE item_id = '" + uint_1 + "' LIMIT 1");
			}
			if (dataRow == null)
			{
				throw new ArgumentException();
			}
			this.bool_0 = Phoenix.smethod_3(dataRow["enabled"].ToString());
			this.int_0 = (int)dataRow["current_preset"];
			this.list_0 = new List<Class68>();
			this.list_0.Add(this.method_3((string)dataRow["preset_one"]));
			this.list_0.Add(this.method_3((string)dataRow["preset_two"]));
			this.list_0.Add(this.method_3((string)dataRow["preset_three"]));
		}
		public void method_0()
		{
			this.bool_0 = true;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1("UPDATE room_items_moodlight SET enabled = '1' WHERE item_id = '" + this.uint_0 + "' LIMIT 1");
			}
		}
		public void method_1()
		{
			this.bool_0 = false;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1("UPDATE room_items_moodlight SET enabled = '0' WHERE item_id = '" + this.uint_0 + "' LIMIT 1");
			}
		}
		public void method_2(int int_1, string string_0, int int_2, bool bool_1)
		{
            string text = null;
			if (this.method_5(string_0) && this.method_6(int_2))
			{
				switch (int_1)
				{
				case 1:
				{
					IL_2E:
					text = "one";
					goto IL_44;
				}
				case 2:
				{
					text = "two";
					goto IL_44;
				}
				case 3:
				{
					text = "three";
					goto IL_44;
				}
				}
				/*goto IL_2E;*/
				IL_44:
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("color", string_0);
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE room_items_moodlight SET preset_",
						text,
						" = '@color,",
						int_2,
						",",
						Phoenix.smethod_4(bool_1),
						"' WHERE item_id = '",
						this.uint_0,
						"' LIMIT 1"
					}));
				}
				this.method_4(int_1).string_0 = string_0;
				this.method_4(int_1).int_0 = int_2;
				this.method_4(int_1).bool_0 = bool_1;
			}
		}
		public Class68 method_3(string string_0)
		{
			string[] array = string_0.Split(new char[]
			{
				','
			});
			if (!this.method_5(array[0]))
			{
				array[0] = "#000000";
			}
			return new Class68(array[0], int.Parse(array[1]), Phoenix.smethod_3(array[2]));
		}
		public Class68 method_4(int int_1)
		{
			int_1--;
			Class68 result;
			if (this.list_0[int_1] != null)
			{
				result = this.list_0[int_1];
			}
			else
			{
				result = new Class68("#000000", 255, false);
			}
			return result;
		}
		public bool method_5(string string_0)
		{
			bool result;
			switch (string_0)
			{
			case "#000000":
			case "#0053F7":
			case "#EA4532":
			case "#82F349":
			case "#74F5F5":
			case "#E759DE":
			case "#F2F851":
				result = true;
				return result;
			}
			result = false;
			return result;
		}
		public bool method_6(int int_1)
		{
			return int_1 >= 0 && int_1 <= 255;
		}
		public string method_7()
		{
			Class68 @class = this.method_4(this.int_0);
			StringBuilder stringBuilder = new StringBuilder();
			if (this.bool_0)
			{
				stringBuilder.Append(2);
			}
			else
			{
				stringBuilder.Append(1);
			}
			stringBuilder.Append(",");
			stringBuilder.Append(this.int_0);
			stringBuilder.Append(",");
			if (@class.bool_0)
			{
				stringBuilder.Append(2);
			}
			else
			{
				stringBuilder.Append(1);
			}
			stringBuilder.Append(",");
			stringBuilder.Append(@class.string_0);
			stringBuilder.Append(",");
			stringBuilder.Append(@class.int_0);
			return stringBuilder.ToString();
		}
	}
}
