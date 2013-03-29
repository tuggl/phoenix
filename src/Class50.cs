using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace ns0
{
	internal sealed class Class50
	{
		private List<Class51> list_0;
		private uint uint_0;
		public int int_0;
		private Class16 class16_0;
		public int Int32_0
		{
			get
			{
				return this.list_0.Count;
			}
		}
		public Class50(uint uint_1, Class16 class16_1, Class12 class12_0)
		{
			this.class16_0 = class16_1;
			this.list_0 = new List<Class51>();
			this.uint_0 = uint_1;
			this.int_0 = -1;
			this.list_0.Clear();
			DataTable dataTable_ = class12_0.DataTable_7;
			StringBuilder stringBuilder = new StringBuilder();
			foreach (DataRow dataRow in dataTable_.Rows)
			{
				Class51 @class = new Class51((int)dataRow["effect_id"], (int)dataRow["total_duration"], Phoenix.smethod_3(dataRow["is_activated"].ToString()), (double)dataRow["activated_stamp"]);
				if (@class.Boolean_0)
				{
					stringBuilder.Append(string.Concat(new object[]
					{
						"DELETE FROM user_effects WHERE user_id = '",
						uint_1,
						"' AND effect_id = '",
						@class.int_0,
						"' LIMIT 1; "
					}));
				}
				else
				{
					this.list_0.Add(@class);
				}
			}
			if (stringBuilder.Length > 0)
			{
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_1(stringBuilder.ToString());
				}
			}
		}
		public void method_0(int int_1, int int_2)
		{
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1(string.Concat(new object[]
				{
					"INSERT INTO user_effects (user_id,effect_id,total_duration,is_activated,activated_stamp) VALUES ('",
					this.uint_0,
					"','",
					int_1,
					"','",
					int_2,
					"','0','0')"
				}));
			}
			this.list_0.Add(new Class51(int_1, int_2, false, 0.0));
			GClass5 gClass = new GClass5(461u);
			gClass.method_9(int_1);
			gClass.method_9(int_2);
			this.method_8().method_14(gClass);
		}
		public void method_1(int int_1)
		{
			Class51 @class = this.method_5(int_1, true);
			if (@class != null && @class.Boolean_0)
			{
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					class2.method_1(string.Concat(new object[]
					{
						"DELETE FROM user_effects WHERE user_id = '",
						this.uint_0,
						"' AND effect_id = '",
						int_1,
						"' AND is_activated = '1' LIMIT 1"
					}));
				}
				this.list_0.Remove(@class);
				GClass5 gClass = new GClass5(463u);
				gClass.method_9(int_1);
				this.method_8().method_14(gClass);
				if (this.int_0 >= 0)
				{
					this.method_2(-1, false);
				}
			}
		}
		public void method_2(int int_1, bool bool_0)
		{
			if (this.method_4(int_1, true) || bool_0)
			{
				Class14 @class = this.method_9();
				if (@class != null && (this.method_8() != null && this.method_8().method_2() != null))
				{
					Class33 class2 = @class.method_53(this.method_8().method_2().uint_0);
					if (class2 != null && (class2.byte_1 <= 0 || int_1 == -1 || bool_0) && (class2.class34_1 == null || int_1 == 77 || int_1 == -1))
					{
						this.int_0 = int_1;
						if (class2.method_16() != null && class2.method_16().method_2().uint_6 == 19u && (this.int_0 == 28 || this.int_0 == 29 || this.int_0 == 30 || this.int_0 == 37))
						{
							Phoenix.smethod_15().method_16().method_1(19u, class2.method_16());
						}
						GClass5 gClass = new GClass5(485u);
						gClass.method_9(class2.int_0);
						gClass.method_9(int_1);
						@class.method_59(gClass, null);
					}
				}
			}
		}
		public void method_3(int int_1)
		{
			Class51 @class = this.method_5(int_1, false);
			if (@class != null && !@class.Boolean_0 && !@class.bool_0 && (this.method_8() != null && this.method_8().method_2() != null))
			{
				Class14 class2 = this.method_9();
				if (class2 != null)
				{
					Class33 class3 = class2.method_53(this.method_8().method_2().uint_0);
					if (class3.byte_1 <= 0 && class3.class34_1 == null)
					{
						using (Class6 class4 = Phoenix.smethod_12().method_0())
						{
							class4.method_1(string.Concat(new object[]
							{
								"UPDATE user_effects SET is_activated = '1', activated_stamp = '",
								Phoenix.smethod_6(),
								"' WHERE user_id = '",
								this.uint_0,
								"' AND effect_id = '",
								int_1,
								"' LIMIT 1"
							}));
						}
						@class.method_0();
						GClass5 gClass = new GClass5(462u);
						gClass.method_9(@class.int_0);
						gClass.method_9(@class.int_1);
						this.method_8().method_14(gClass);
					}
				}
			}
		}
		public bool method_4(int int_1, bool bool_0)
		{
			bool result;
			if (int_1 == -1 || int_1 == 28 || int_1 == 29)
			{
				result = true;
			}
			else
			{
				using (GStruct0.smethod_0(this.list_0))
				{
					foreach (Class51 current in this.list_0)
					{
						if ((!bool_0 || current.bool_0) && !current.Boolean_0 && current.int_0 == int_1)
						{
							result = true;
							return result;
						}
					}
				}
				result = false;
			}
			return result;
		}
		public Class51 method_5(int int_1, bool bool_0)
		{
			Class51 result;
			using (GStruct0.smethod_0(this.list_0))
			{
				foreach (Class51 current in this.list_0)
				{
					if ((!bool_0 || current.bool_0) && current.int_0 == int_1)
					{
						result = current;
						return result;
					}
				}
			}
			result = null;
			return result;
		}
		public GClass5 method_6()
		{
			GClass5 gClass = new GClass5(460u);
			gClass.method_9(this.Int32_0);
			using (GStruct0.smethod_0(this.list_0))
			{
				foreach (Class51 current in this.list_0)
				{
					gClass.method_9(current.int_0);
					gClass.method_9(current.int_1);
					gClass.method_13(!current.bool_0);
					gClass.method_9(current.Int32_0);
				}
			}
			return gClass;
		}
		public void method_7()
		{
			using (GStruct0.smethod_0(this.list_0))
			{
				List<int> list = new List<int>();
				foreach (Class51 current in this.list_0)
				{
					if (current.Boolean_0)
					{
						list.Add(current.int_0);
					}
				}
				foreach (int current2 in list)
				{
					this.method_1(current2);
				}
			}
		}
		private Class16 method_8()
		{
			return this.class16_0;
		}
		private Class14 method_9()
		{
			return this.class16_0.method_2().Class14_0;
		}
	}
}
