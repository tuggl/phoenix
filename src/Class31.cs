using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns0
{
	internal sealed class Class31
	{
		[CompilerGenerated]
		private sealed class Class219
		{
			public int int_0;
			public bool method_0(Class27 class27_0)
			{
				return class27_0.int_1 == this.int_0;
			}
			public bool method_1(Class14 class14_0)
			{
				return class14_0.int_0 == this.int_0;
			}
		}
		private List<Class30> list_0;
		private Dictionary<int, Class32> dictionary_0;
		private Dictionary<int, Class32> dictionary_1;
		[CompilerGenerated]
		private static Comparison<KeyValuePair<string, int>> comparison_0;
		[CompilerGenerated]
		private static Func<Class27, int> func_0;
		[CompilerGenerated]
		private static Func<Class14, int> func_1;
		[CompilerGenerated]
		private static Func<Class14, int> func_2;
		public Class31()
		{
			this.list_0 = new List<Class30>();
			this.dictionary_0 = new Dictionary<int, Class32>();
			this.dictionary_1 = new Dictionary<int, Class32>();
		}
		public void method_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Navigator..");
			this.list_0.Clear();
			this.dictionary_0.Clear();
			this.dictionary_1.Clear();
			DataTable dataTable = class6_0.method_3("SELECT id,caption,min_rank,cantrade FROM navigator_flatcats WHERE enabled = '1'");
			DataTable dataTable2 = class6_0.method_3("SELECT id,bannertype,caption,image,image_type,room_id,category,category_parent_id FROM navigator_publics ORDER BY ordernum ASC;");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					this.list_0.Add(new Class30((int)dataRow["id"], (string)dataRow["caption"], (int)dataRow["min_rank"], Phoenix.smethod_3(dataRow["cantrade"].ToString())));
				}
			}
			if (dataTable2 != null)
			{
				foreach (DataRow dataRow in dataTable2.Rows)
				{
					this.dictionary_0.Add((int)dataRow["id"], new Class32((int)dataRow["id"], int.Parse(dataRow["bannertype"].ToString()), (string)dataRow["caption"], (string)dataRow["image"], (dataRow["image_type"].ToString().ToLower() == "internal") ? Enum1.const_0 : Enum1.const_1, (uint)dataRow["room_id"], Phoenix.smethod_3(dataRow["category"].ToString()), (int)dataRow["category_parent_id"]));
					if (!this.dictionary_0[(int)dataRow["id"]].bool_0)
					{
						this.dictionary_1.Add((int)dataRow["id"], this.dictionary_0[(int)dataRow["id"]]);
					}
				}
			}
			GClass4.smethod_1("completed!");
		}
		public int method_1(int int_0)
		{
			int num = 0;
			foreach (Class32 current in this.dictionary_0.Values)
			{
				if (current.int_2 == int_0 || int_0 == -1)
				{
					num++;
				}
			}
			return num;
		}
		public Class30 method_2(int int_0)
		{
			Class30 result;
			using (GStruct0.smethod_0(this.list_0))
			{
				foreach (Class30 current in this.list_0)
				{
					if (current.int_0 == int_0)
					{
						result = current;
						return result;
					}
				}
			}
			result = null;
			return result;
		}
		public GClass5 method_3()
		{
			GClass5 gClass = new GClass5(221u);
			gClass.method_9(this.list_0.Count);
			foreach (Class30 current in this.list_0)
			{
				if (current.int_0 > 0)
				{
					gClass.method_13(true);
				}
				if (current.int_0 != 15)
				{
					gClass.method_9(current.int_0);
				}
				gClass.method_7(current.string_0);
			}
			gClass.method_7("");
			return gClass;
		}
		public void method_4(int int_0, GClass5 gclass5_0)
		{
			foreach (Class32 current in this.dictionary_0.Values)
			{
				if (current.int_2 == int_0 && !current.bool_0)
				{
					current.method_0(gclass5_0);
				}
			}
		}
		public GClass5 method_5()
		{
			GClass5 gClass = new GClass5(450u);
			gClass.method_9(this.dictionary_0.Count);
			foreach (Class32 current in this.dictionary_0.Values)
			{
				if (current.bool_0)
				{
					current.method_0(gClass);
					this.method_4(current.Int32_0, gClass);
				}
				if (!current.bool_0 && (current.int_2 == 0 || current.int_2 == -1))
				{
					current.method_0(gClass);
				}
			}
			return gClass;
		}
		public GClass5 method_6(Class16 class16_0)
		{
			GClass5 gClass = new GClass5(451u);
			gClass.method_9(0);
			gClass.method_9(6);
			gClass.method_7("");
			gClass.method_9(class16_0.method_2().list_1.Count);
			using (GStruct0.smethod_0(class16_0.method_2().list_1))
			{
				foreach (uint current in class16_0.method_2().list_1)
				{
					Phoenix.smethod_15().method_9().method_11(current).method_3(gClass, false, false);
				}
			}
			return gClass;
		}
		public GClass5 method_7(Class16 class16_0)
		{
			GClass5 result;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				DataTable dataTable = @class.method_3("SELECT * FROM rooms JOIN user_roomvisits ON rooms.id = user_roomvisits.room_id WHERE user_roomvisits.user_id = '" + class16_0.method_2().uint_0 + "' ORDER BY entry_timestamp DESC LIMIT 50;");
				List<Class27> list = new List<Class27>();
				List<uint> list2 = new List<uint>();
				if (dataTable != null)
				{
					foreach (DataRow dataRow in dataTable.Rows)
					{
						Class27 class2 = Phoenix.smethod_15().method_9().method_17((uint)dataRow["id"], dataRow);
						class2.method_1(dataRow);
						list.Add(class2);
						list2.Add(class2.uint_0);
					}
				}
				GClass5 gClass = new GClass5(451u);
				gClass.method_9(0);
				gClass.method_9(7);
				gClass.method_7("");
				gClass.method_9(list.Count);
				foreach (Class27 current in list)
				{
					current.method_3(gClass, false, false);
				}
				result = gClass;
			}
			return result;
		}
		public GClass5 method_8(Class16 class16_0, int int_0)
		{
			GClass5 gClass = new GClass5(451u);
			gClass.method_9(int_0);
			gClass.method_9(12);
			gClass.method_7("");
			List<Class14> list = Phoenix.smethod_15().method_9().method_6(int_0);
			gClass.method_9(list.Count);
			foreach (Class14 current in list)
			{
				Class27 class27_ = current.Class27_0;
				class27_.method_3(gClass, true, false);
			}
			return gClass;
		}
		public GClass5 method_9()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			GClass5 result;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				DataTable dataTable = @class.method_3("SELECT tags,users_now FROM rooms WHERE roomtype = 'private' AND users_now > 0 ORDER BY users_now DESC LIMIT 50;");
				if (dataTable != null)
				{
					foreach (DataRow dataRow in dataTable.Rows)
					{
						List<string> list = new List<string>();
						string[] array = dataRow["tags"].ToString().Split(new char[]
						{
							','
						});
						for (int i = 0; i < array.Length; i++)
						{
							string text = array[i];
							list.Add(text);
						}
						foreach (string text in list)
						{
							if (dictionary.ContainsKey(text))
							{
								Dictionary<string, int> dictionary2;
								string key;
								(dictionary2 = dictionary)[key = text] = dictionary2[key] + (int)dataRow["users_now"];
							}
							else
							{
								dictionary.Add(text, (int)dataRow["users_now"]);
							}
						}
					}
				}
				List<KeyValuePair<string, int>> list2 = new List<KeyValuePair<string, int>>(dictionary);
				List<KeyValuePair<string, int>> arg_163_0 = list2;
				if (Class31.comparison_0 == null)
				{
					Class31.comparison_0 = new Comparison<KeyValuePair<string, int>>(Class31.smethod_0);
				}
				arg_163_0.Sort(Class31.comparison_0);
				GClass5 gClass = new GClass5(452u);
				gClass.method_9(list2.Count);
				foreach (KeyValuePair<string, int> current in list2)
				{
					gClass.method_7(current.Key);
					gClass.method_9(current.Value);
				}
				result = gClass;
			}
			return result;
		}
		public GClass5 method_10(string string_0)
		{
			DataTable dataTable = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				string_0 = Phoenix.smethod_7(string_0.ToLower()).Trim();
				if (string_0.Length > 0)
				{
					if (string_0.StartsWith("owner:"))
					{
						string_0 = string_0.Replace(" ", "");
						@class.method_0("query", string_0.Substring(6));
						dataTable = @class.method_3("SELECT * FROM rooms WHERE owner = @query AND roomtype = 'private' ORDER BY users_now DESC LIMIT " + Class13.Int32_4);
					}
					else
					{
						string_0 = string_0.Replace("%", "\\%");
						string_0 = string_0.Replace("_", "\\_");
						@class.method_0("query", string_0 + "%");
						@class.method_0("tags_query", "%" + string_0 + "%");
						dataTable = @class.method_3("SELECT * FROM rooms WHERE caption LIKE @query AND roomtype = 'private' OR owner LIKE @query AND roomtype = 'private' ORDER BY users_now DESC LIMIT 40");
					}
				}
			}
			List<Class27> list = new List<Class27>();
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Class27 item = Phoenix.smethod_15().method_9().method_17((uint)dataRow["id"], dataRow);
					list.Add(item);
				}
			}
			GClass5 gClass = new GClass5(451u);
			gClass.method_9(1);
			gClass.method_9(9);
			gClass.method_7(string_0);
			gClass.method_9(list.Count);
			foreach (Class27 current in list)
			{
				current.method_3(gClass, false, false);
			}
			return gClass;
		}
		internal byte[] method_11(Class16 class16_0, int int_0)
		{
			byte[] result;
			if (int_0 != -2)
			{
				result = this.method_12(class16_0, int_0).method_14();
			}
			else
			{
				byte[] array = Phoenix.smethod_15().method_15().method_1(int_0);
				if (array != null)
				{
					result = array;
				}
				else
				{
					result = this.method_12(null, int_0).method_14();
				}
			}
			return result;
		}
		public GClass5 method_12(Class16 class16_0, int int_0)
		{
			Func<Class27, bool> func = null;
			Func<Class14, bool> func2 = null;
			Class31.Class219 @class = new Class31.Class219();
			@class.int_0 = int_0;
			GClass5 gClass = new GClass5(451u);
			if (@class.int_0 >= -1)
			{
				gClass.method_9(@class.int_0);
				gClass.method_9(1);
			}
			else
			{
				if (@class.int_0 == -2)
				{
					gClass.method_9(0);
					gClass.method_9(2);
				}
				else
				{
					if (@class.int_0 == -3)
					{
						gClass.method_9(0);
						gClass.method_9(5);
					}
					else
					{
						if (@class.int_0 == -4)
						{
							gClass.method_9(0);
							gClass.method_9(3);
						}
						else
						{
							if (@class.int_0 == -5)
							{
								gClass.method_9(0);
								gClass.method_9(4);
							}
						}
					}
				}
			}
			gClass.method_7("");
			List<Class27> list = new List<Class27>();
			switch (@class.int_0)
			{
			case -5:
			case -4:
				break;
			case -3:
				goto IL_3A2;
			case -2:
				goto IL_3E5;
			case -1:
				goto IL_47E;
			default:
			{
				Dictionary<Class14, int> dictionary = Phoenix.smethod_15().method_9().method_21();
				IEnumerable<Class27> arg_11F_0 = Phoenix.smethod_15().method_9().list_3;
				if (func == null)
				{
					func = new Func<Class27, bool>(@class.method_0);
				}
				IEnumerable<Class27> enumerable = arg_11F_0.Where(func);
				IEnumerable<Class14> arg_13E_0 = dictionary.Keys;
				if (func2 == null)
				{
					func2 = new Func<Class14, bool>(@class.method_1);
				}
				IEnumerable<Class14> arg_160_0 = arg_13E_0.Where(func2);
				if (Class31.func_2 == null)
				{
					Class31.func_2 = new Func<Class14, int>(Class31.smethod_3);
				}
				IOrderedEnumerable<Class14> orderedEnumerable = arg_160_0.OrderByDescending(Class31.func_2);
				new List<Class27>();
				int num = 0;
				foreach (Class14 current in orderedEnumerable)
				{
					if (num > 40)
					{
						break;
					}
					list.Add(current.Class27_0);
					num++;
				}
				using (IEnumerator<Class27> enumerator2 = enumerable.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						Class27 current2 = enumerator2.Current;
						if (num > 40)
						{
							break;
						}
						if (list.Contains(current2))
						{
							list.Remove(current2);
						}
						list.Add(current2);
						num++;
					}
					goto IL_508;
				}
				break;
			}
			}
			List<string> list2 = new List<string>();
			Dictionary<int, Class14> dictionary2 = new Dictionary<int, Class14>();
			Hashtable hashtable = class16_0.method_2().method_21().method_26().Clone() as Hashtable;
			Dictionary<Class27, int> dictionary3 = new Dictionary<Class27, int>();
			foreach (Class104 class2 in hashtable.Values)
			{
				if (class2.Boolean_0 && class2.Boolean_1)
				{
					Class16 class3 = Phoenix.smethod_15().method_2().method_2(class2.UInt32_0);
					if (class3 != null && class3.method_2() != null && class3.method_2().Class14_0 != null)
					{
						Class27 class27_ = class3.method_2().Class14_0.Class27_0;
						if (!dictionary3.ContainsKey(class27_))
						{
							dictionary3.Add(class27_, class27_.int_2);
						}
					}
				}
			}
			IEnumerable<Class27> arg_344_0 = dictionary3.Keys;
			if (Class31.func_0 == null)
			{
				Class31.func_0 = new Func<Class27, int>(Class31.smethod_1);
			}
			IOrderedEnumerable<Class27> orderedEnumerable2 = arg_344_0.OrderByDescending(Class31.func_0);
			list2.Clear();
			dictionary2.Clear();
			hashtable.Clear();
			dictionary3.Clear();
			using (IEnumerator<Class27> enumerator2 = orderedEnumerable2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class27 current3 = enumerator2.Current;
					list.Add(current3);
				}
				goto IL_508;
			}
			IL_3A2:
			using (List<Class27>.Enumerator enumerator4 = class16_0.method_2().list_6.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					Class27 current3 = enumerator4.Current;
					list.Add(current3);
				}
				goto IL_508;
			}
			IL_3E5:
			DataTable dataTable;
			using (Class6 class4 = Phoenix.smethod_12().method_0())
			{
				dataTable = class4.method_3("SELECT * FROM rooms WHERE score > 0 AND roomtype = 'private' ORDER BY score DESC LIMIT 40");
			}
			IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
			try
			{
				while (enumerator3.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator3.Current;
					list.Add(Phoenix.smethod_15().method_9().method_17((uint)dataRow["id"], dataRow));
				}
				goto IL_508;
			}
			finally
			{
				IDisposable disposable = enumerator3 as IDisposable;
				if (disposable != null)
				{
					disposable.Dispose();
				}
			}
			IL_47E:
			Dictionary<Class14, int> dictionary4 = Phoenix.smethod_15().method_9().method_21();
			IEnumerable<Class14> arg_4B3_0 = dictionary4.Keys;
			if (Class31.func_1 == null)
			{
				Class31.func_1 = new Func<Class14, int>(Class31.smethod_2);
			}
			IOrderedEnumerable<Class14> orderedEnumerable3 = arg_4B3_0.OrderByDescending(Class31.func_1);
			int num2 = 0;
			foreach (Class14 current4 in orderedEnumerable3)
			{
				if (num2 >= 40)
				{
					break;
				}
				num2++;
				list.Add(current4.Class27_0);
			}
			IL_508:
			gClass.method_9(list.Count);
			foreach (Class27 current5 in list)
			{
				current5.method_3(gClass, false, false);
			}
			Random random = new Random();
			gClass.method_7("");
			this.dictionary_1.ElementAt(random.Next(0, this.dictionary_1.Count)).Value.method_0(gClass);
			return gClass;
		}
		[CompilerGenerated]
		private static int smethod_0(KeyValuePair<string, int> keyValuePair_0, KeyValuePair<string, int> keyValuePair_1)
		{
			return keyValuePair_0.Value.CompareTo(keyValuePair_1.Value);
		}
		[CompilerGenerated]
		private static int smethod_1(Class27 class27_0)
		{
			return class27_0.int_2;
		}
		[CompilerGenerated]
		private static int smethod_2(Class14 class14_0)
		{
			return class14_0.Int32_0;
		}
		[CompilerGenerated]
		private static int smethod_3(Class14 class14_0)
		{
			return class14_0.Int32_0;
		}
	}
}
