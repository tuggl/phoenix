using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class56
	{
		private List<Class57> list_0;
		private uint uint_0;
		public int Int32_0
		{
			get
			{
				return this.list_0.Count;
			}
		}
		public int Int32_1
		{
			get
			{
				int num = 0;
				foreach (Class57 current in this.list_0)
				{
					if (current.int_0 > 0)
					{
						num++;
					}
				}
				return num;
			}
		}
		public List<Class57> List_0
		{
			get
			{
				return this.list_0;
			}
		}
		public Class56(uint uint_1, Class12 class12_0)
		{
			this.list_0 = new List<Class57>();
			this.uint_0 = uint_1;
			DataTable dataTable_ = class12_0.DataTable_5;
			if (dataTable_ != null)
			{
				foreach (DataRow dataRow in dataTable_.Rows)
				{
					this.list_0.Add(new Class57((string)dataRow["badge_id"], (int)dataRow["badge_slot"]));
				}
			}
		}
		public Class57 method_0(string string_0)
		{
			Class57 result;
			foreach (Class57 current in this.list_0)
			{
				if (string_0.ToLower() == current.string_0.ToLower())
				{
					result = current;
					return result;
				}
			}
			result = null;
			return result;
		}
		public bool method_1(string string_0)
		{
			return this.method_0(string_0) != null;
		}
		public void method_2(Class16 class16_0, string string_0, bool bool_0)
		{
			this.method_3(string_0, 0, bool_0);
			GClass5 gClass = new GClass5(832u);
			gClass.method_9(1);
			gClass.method_9(4);
			gClass.method_9(1);
			gClass.method_11(Phoenix.smethod_15().method_12().method_0(string_0));
			class16_0.method_14(gClass);
		}
		public void method_3(string string_0, int int_0, bool bool_0)
		{
			if (!this.method_1(string_0))
			{
				if (bool_0)
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_0("badge", string_0);
						@class.method_1(string.Concat(new object[]
						{
							"INSERT INTO user_badges (user_id,badge_id,badge_slot) VALUES ('",
							this.uint_0,
							"',@badge,'",
							int_0,
							"')"
						}));
					}
				}
				this.list_0.Add(new Class57(string_0, int_0));
			}
		}
		public void method_4(string string_0, int int_0)
		{
			Class57 @class = this.method_0(string_0);
			if (@class != null)
			{
				@class.int_0 = int_0;
			}
		}
		public void method_5()
		{
			foreach (Class57 current in this.list_0)
			{
				current.int_0 = 0;
			}
		}
		public void method_6(string string_0)
		{
			if (this.method_1(string_0))
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("badge", string_0);
					@class.method_1("DELETE FROM user_badges WHERE badge_id = @badge AND user_id = '" + this.uint_0 + "' LIMIT 1");
				}
				this.list_0.Remove(this.method_0(string_0));
			}
		}
		public GClass5 method_7()
		{
			List<Class57> list = new List<Class57>();
			GClass5 gClass = new GClass5(229u);
			gClass.method_9(this.Int32_0);
			foreach (Class57 current in this.list_0)
			{
				gClass.method_11(Phoenix.smethod_15().method_12().method_0(current.string_0));
				gClass.method_7(current.string_0);
				if (current.int_0 > 0)
				{
					list.Add(current);
				}
			}
			gClass.method_9(list.Count);
			foreach (Class57 current in list)
			{
				gClass.method_9(current.int_0);
				gClass.method_7(current.string_0);
			}
			return gClass;
		}
	}
}
