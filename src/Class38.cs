using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace ns0
{
	internal sealed class Class38
	{
		public List<Class39> list_0;
		private Hashtable hashtable_0;
		private Hashtable hashtable_1;
		public List<uint> list_1;
		private Class16 class16_0;
		public uint uint_0;
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
				return this.hashtable_0.Count;
			}
		}
		public Class38(uint uint_1, Class16 class16_1, Class12 class12_0)
		{
			this.class16_0 = class16_1;
			this.uint_0 = uint_1;
			this.list_0 = new List<Class39>();
			this.hashtable_0 = new Hashtable();
			this.hashtable_1 = new Hashtable();
			this.list_1 = new List<uint>();
			this.list_0.Clear();
			DataTable dataTable_ = class12_0.DataTable_6;
			foreach (DataRow dataRow in dataTable_.Rows)
			{
				this.list_0.Add(new Class39((uint)dataRow["id"], (uint)dataRow["base_item"], (string)dataRow["extra_data"]));
			}
			this.hashtable_0.Clear();
			DataTable dataTable_2 = class12_0.DataTable_11;
			foreach (DataRow dataRow in dataTable_2.Rows)
			{
				Class15 @class = Phoenix.smethod_15().method_6().method_12(dataRow);
				this.hashtable_0.Add(@class.uint_0, @class);
			}
		}
		public void method_0()
		{
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1("DELETE FROM items WHERE room_id = 0 AND user_id = '" + this.uint_0 + "';");
			}
			this.hashtable_1.Clear();
			this.list_1.Clear();
			this.list_0.Clear();
			GClass5 gclass5_ = new GClass5(101u);
			this.method_16().method_14(gclass5_);
		}
		public void method_1(Class16 class16_1)
		{
			int num = 0;
			List<Class39> list = new List<Class39>();
			foreach (Class39 current in this.list_0)
			{
				if (current != null && (current.method_1().string_1.StartsWith("CF_") || current.method_1().string_1.StartsWith("CFC_")))
				{
					string[] array = current.method_1().string_1.Split(new char[]
					{
						'_'
					});
					int num2 = int.Parse(array[1]);
					if (!this.list_1.Contains(current.uint_0))
					{
						if (num2 > 0)
						{
							num += num2;
						}
						list.Add(current);
					}
				}
			}
			foreach (Class39 current in list)
			{
				this.method_12(current.uint_0, 0u, false);
			}
			class16_1.method_2().int_2 += num;
			class16_1.method_2().method_13(true);
			class16_1.method_8("All coins in your inventory have been converted back into " + num + " credits!");
		}
		public void method_2()
		{
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1("DELETE FROM user_pets WHERE user_id = " + this.uint_0 + " AND room_id = 0;");
			}
			foreach (Class15 class2 in this.hashtable_0.Values)
			{
				GClass5 gClass = new GClass5(604u);
				gClass.method_11(class2.uint_0);
				this.method_16().method_14(gClass);
			}
			this.hashtable_0.Clear();
		}
		public void method_3(bool bool_0)
		{
			if (bool_0)
			{
				this.method_8();
			}
			this.method_16().method_14(this.method_15());
		}
		public Class15 method_4(uint uint_1)
		{
			return this.hashtable_0[uint_1] as Class15;
		}
		public bool method_5(uint uint_1)
		{
			GClass5 gClass = new GClass5(604u);
			gClass.method_11(uint_1);
			this.method_16().method_14(gClass);
			this.hashtable_0.Remove(uint_1);
			return true;
		}
		public void method_6(uint uint_1, uint uint_2)
		{
			this.method_5(uint_1);
		}
		public void method_7(Class15 class15_0)
		{
			try
			{
				if (class15_0 != null)
				{
					class15_0.bool_0 = false;
					if (!this.hashtable_0.ContainsKey(class15_0.uint_0))
					{
						this.hashtable_0.Add(class15_0.uint_0, class15_0);
					}
					GClass5 gclass5_ = new GClass5(603u);
					class15_0.method_3(gclass5_);
					this.method_16().method_14(gclass5_);
				}
			}
			catch
			{
			}
		}
		public void method_8()
		{
			using (GStruct0.smethod_0(this.list_0))
			{
				this.list_0.Clear();
				this.hashtable_1.Clear();
				this.list_1.Clear();
				DataTable dataTable;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					dataTable = @class.method_3("SELECT id,base_item,extra_data,user_id FROM items WHERE room_id = 0 AND user_id = " + this.uint_0);
				}
				if (dataTable != null)
				{
					foreach (DataRow dataRow in dataTable.Rows)
					{
						this.list_0.Add(new Class39((uint)dataRow["id"], (uint)dataRow["base_item"], (string)dataRow["extra_data"]));
					}
				}
				using (GStruct0.smethod_0(this.hashtable_0))
				{
					this.hashtable_0.Clear();
					DataTable dataTable2;
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_0("userid", this.uint_0);
						dataTable2 = @class.method_3("SELECT id, user_id, room_id, name, type, race, color, expirience, energy, nutrition, respect, createstamp, x, y, z FROM user_pets WHERE user_id = @userid AND room_id <= 0");
					}
					if (dataTable2 != null)
					{
						foreach (DataRow dataRow in dataTable2.Rows)
						{
							Class15 class2 = Phoenix.smethod_15().method_6().method_12(dataRow);
							this.hashtable_0.Add(class2.uint_0, class2);
						}
					}
				}
			}
		}
		public void method_9(bool bool_0)
		{
			if (bool_0)
			{
				this.method_8();
				this.method_18();
			}
			if (this.method_16() != null)
			{
				this.method_16().method_14(new GClass5(101u));
			}
		}
		public Class39 method_10(uint uint_1)
		{
			List<Class39>.Enumerator enumerator = this.list_0.GetEnumerator();
			Class39 result;
			while (enumerator.MoveNext())
			{
				Class39 current = enumerator.Current;
				if (current.uint_0 == uint_1)
				{
					result = current;
					return result;
				}
			}
			result = null;
			return result;
		}
		public void method_11(uint uint_1, uint uint_2, string string_0, bool bool_0)
		{
			Class39 item = new Class39(uint_1, uint_2, string_0);
			this.list_0.Add(item);
			if (this.list_1.Contains(uint_1))
			{
				this.list_1.Remove(uint_1);
			}
			if (!this.hashtable_1.ContainsKey(uint_1))
			{
				if (bool_0)
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_0("extra_data", string_0);
						@class.method_1(string.Concat(new object[]
						{
							"INSERT INTO items (id,user_id,base_item,extra_data,wall_pos) VALUES ('",
							uint_1,
							"','",
							this.uint_0,
							"','",
							uint_2,
							"',@extra_data, '')"
						}));
						return;
					}
				}
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE items SET room_id = 0, user_id = '",
						this.uint_0,
						"' WHERE id = '",
						uint_1,
						"'"
					}));
				}
			}
		}
		public void method_12(uint uint_1, uint uint_2, bool bool_0)
		{
			GClass5 gClass = new GClass5(99u);
			gClass.method_11(uint_1);
			this.method_16().method_14(gClass);
			if (this.hashtable_1.ContainsKey(uint_1))
			{
				this.hashtable_1.Remove(uint_1);
			}
			if (!this.list_1.Contains(uint_1))
			{
				this.list_0.Remove(this.method_10(uint_1));
				this.list_1.Add(uint_1);
				if (bool_0)
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_1(string.Concat(new object[]
						{
							"UPDATE items SET user_id = '",
							uint_2,
							"' WHERE id = '",
							uint_1,
							"' LIMIT 1"
						}));
						return;
					}
				}
				if (uint_2 == 0u && !bool_0)
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_1("DELETE FROM items WHERE id = '" + uint_1 + "' LIMIT 1");
					}
				}
			}
		}
		public GClass5 method_13()
		{
			GClass5 gClass = new GClass5(140u);
			gClass.method_7("S");
			gClass.method_9(1);
			gClass.method_9(1);
			gClass.method_9(this.Int32_0);
			List<Class39>.Enumerator enumerator = this.list_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				enumerator.Current.method_0(gClass, true);
			}
			return gClass;
		}
		public GClass5 method_14()
		{
			GClass5 gClass = new GClass5(140u);
			gClass.method_7("I");
			gClass.method_6("II");
			gClass.method_9(0);
			return gClass;
		}
		public GClass5 method_15()
		{
			GClass5 gClass = new GClass5(600u);
			gClass.method_9(this.hashtable_0.Count);
			foreach (Class15 @class in this.hashtable_0.Values)
			{
				@class.method_3(gClass);
			}
			return gClass;
		}
		private Class16 method_16()
		{
			return Phoenix.smethod_15().method_2().method_2(this.uint_0);
		}
		public void method_17(List<Class63> list_2)
		{
			foreach (Class63 current in list_2)
			{
				this.method_11(current.uint_0, current.uint_2, current.string_0, false);
			}
		}
		internal void method_18()
		{
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				this.method_19(@class, false);
			}
		}
		internal void method_19(Class6 class6_0, bool bool_0)
		{
			try
			{
				if (this.list_1.Count > 0 || this.hashtable_1.Count > 0 || this.hashtable_0.Count > 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					foreach (Class15 @class in this.hashtable_0.Values)
					{
						if (@class.enum3_0 == Enum3.const_2)
						{
							class6_0.method_0("petname" + @class.uint_0, @class.string_0);
							class6_0.method_0("petcolor" + @class.uint_0, @class.string_2);
							class6_0.method_0("petrace" + @class.uint_0, @class.string_1);
							stringBuilder.Append(string.Concat(new object[]
							{
								"INSERT INTO `user_pets` VALUES ('",
								@class.uint_0,
								"', '",
								@class.uint_1,
								"', '",
								@class.uint_3,
								"', @petname",
								@class.uint_0,
								", @petrace",
								@class.uint_0,
								", @petcolor",
								@class.uint_0,
								", '",
								@class.uint_2,
								"', '",
								@class.int_1,
								"', '",
								@class.int_2,
								"', '",
								@class.int_3,
								"', '",
								@class.int_6,
								"', '",
								@class.double_1,
								"', '",
								@class.int_4,
								"', '",
								@class.int_5,
								"', '",
								@class.double_0,
								"');"
							}));
						}
						else
						{
							if (@class.enum3_0 == Enum3.const_1)
							{
								stringBuilder.Append(string.Concat(new object[]
								{
									"UPDATE user_pets SET room_id = '",
									@class.uint_3,
									"', expirience = '",
									@class.int_1,
									"', energy = '",
									@class.int_2,
									"', nutrition = '",
									@class.int_3,
									"', respect = '",
									@class.int_6,
									"', x = '",
									@class.int_4,
									"', y = '",
									@class.int_5,
									"', z = '",
									@class.double_0,
									"' WHERE id = '",
									@class.uint_0,
									"' LIMIT 1; "
								}));
							}
						}
						@class.enum3_0 = Enum3.const_0;
					}
					if (stringBuilder.Length > 0)
					{
						class6_0.method_1(stringBuilder.ToString());
					}
				}
				if (bool_0)
				{
					Console.WriteLine("Inventory for user: " + this.method_16().method_2().string_0 + " saved.");
				}
			}
			catch (Exception ex)
			{
				GClass4.smethod_4("FATAL ERROR DURING DB UPDATE: " + ex.ToString());
			}
		}
	}
}
