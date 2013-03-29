using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class27
	{
		public uint uint_0;
		public uint uint_1;
		public string string_0;
		public string string_1;
		public string string_2;
		public string string_3;
		public string string_4;
		public int int_0;
		public int int_1;
		public int int_2;
		public int int_3;
		public string string_5;
		public string string_6;
		public int int_4;
		public List<string> list_0;
		public bool bool_0;
		public bool bool_1;
		public bool bool_2;
		internal bool bool_3;
		public bool bool_4;
		public int int_5;
		public int int_6;
		private Class29 class29_0;
		public Class21 class21_0;
		public string string_7;
		public string string_8;
		public string string_9;
		private Class28 class28_0;
		public bool Boolean_0
		{
			get
			{
				return this.string_2.ToLower() == "public";
			}
		}
		public Class29 Class29_0
		{
			get
			{
				return this.class29_0;
			}
		}
		public int Int32_0
		{
			get
			{
				return this.list_0.Count;
			}
		}
		public Class28 Class28_0
		{
			get
			{
				return this.class28_0;
			}
		}
		public void method_0(uint uint_2)
		{
			this.uint_0 = uint_2;
			this.string_0 = "Unknown Room";
			this.string_1 = "-";
			this.string_2 = "private";
			this.string_3 = "-";
			this.int_1 = 0;
			this.int_2 = 0;
			this.int_3 = 0;
			this.string_5 = "NO_MODEL";
			this.string_6 = "";
			this.int_4 = 0;
			this.list_0 = new List<string>();
			this.bool_0 = true;
			this.bool_1 = false;
			this.bool_2 = true;
			this.bool_4 = false;
			this.int_5 = 0;
			this.int_6 = 0;
			this.string_4 = "";
			this.string_7 = "0.0";
			this.string_8 = "0.0";
			this.string_9 = "0.0";
			this.class21_0 = null;
			this.uint_1 = 0u;
			this.bool_3 = false;
			this.class29_0 = new Class29(1, 1, new Dictionary<int, int>());
			this.class28_0 = Phoenix.smethod_15().method_9().method_10(this.string_5, uint_2);
		}
		public void method_1(DataRow dataRow_0)
		{
			this.uint_0 = (uint)dataRow_0["id"];
			this.string_0 = (string)dataRow_0["caption"];
			this.string_1 = (string)dataRow_0["description"];
			this.string_2 = (string)dataRow_0["roomtype"];
			this.string_3 = (string)dataRow_0["owner"];
			this.uint_1 = Convert.ToUInt32(dataRow_0["achievement"]);
			string text = dataRow_0["state"].ToString().ToLower();
			if (text != null)
			{
				if (text == "open")
				{
					this.int_0 = 0;
					goto IL_DF;
				}
				if (text == "password")
				{
					this.int_0 = 2;
					goto IL_DF;
				}
				if (!(text == "locked"))
				{
				}
			}
			this.int_0 = 1;
			IL_DF:
			this.int_1 = (int)dataRow_0["category"];
			this.int_2 = (int)dataRow_0["users_now"];
			this.int_3 = (int)dataRow_0["users_max"];
			this.string_5 = (string)dataRow_0["model_name"];
			this.string_6 = (string)dataRow_0["public_ccts"];
			this.int_4 = (int)dataRow_0["score"];
			this.list_0 = new List<string>();
			this.bool_0 = Phoenix.smethod_3(dataRow_0["allow_pets"].ToString());
			this.bool_1 = Phoenix.smethod_3(dataRow_0["allow_pets_eat"].ToString());
			this.bool_2 = Phoenix.smethod_3(dataRow_0["allow_walkthrough"].ToString());
			this.bool_3 = false;
			this.bool_4 = Phoenix.smethod_3(dataRow_0["allow_hidewall"].ToString());
			this.int_5 = (int)dataRow_0["wallthick"];
			this.int_6 = (int)dataRow_0["floorthick"];
			this.string_4 = (string)dataRow_0["password"];
			this.string_7 = (string)dataRow_0["wallpaper"];
			this.string_8 = (string)dataRow_0["floor"];
			this.string_9 = (string)dataRow_0["landscape"];
			this.class21_0 = null;
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			string[] array;
			if (dataRow_0["icon_items"].ToString() != "")
			{
				array = dataRow_0["icon_items"].ToString().Split(new char[]
				{
					'|'
				});
				for (int i = 0; i < array.Length; i++)
				{
					string text2 = array[i];
					if (!string.IsNullOrEmpty(text2))
					{
						string[] array2 = text2.Replace('.', ',').Split(new char[]
						{
							','
						});
						int key = 0;
						int value = 0;
						int.TryParse(array2[0], out key);
						if (array2.Length > 1)
						{
							int.TryParse(array2[1], out value);
						}
						try
						{
							if (!dictionary.ContainsKey(key))
							{
								dictionary.Add(key, value);
							}
						}
						catch (Exception ex)
						{
							GClass4.smethod_2(string.Concat(new string[]
							{
								"Exception: ",
								ex.ToString(),
								"[",
								text2,
								"]"
							}));
						}
					}
				}
			}
			this.class29_0 = new Class29((int)dataRow_0["icon_bg"], (int)dataRow_0["icon_fg"], dictionary);
			array = dataRow_0["tags"].ToString().Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				string item = array[i];
				this.list_0.Add(item);
			}
			this.class28_0 = Phoenix.smethod_15().method_9().method_10(this.string_5, this.uint_0);
		}
		public void method_2(Class14 class14_0)
		{
			this.uint_0 = class14_0.UInt32_0;
			this.string_0 = class14_0.string_0;
			this.string_1 = class14_0.string_1;
			this.string_2 = class14_0.string_2;
			this.string_3 = class14_0.string_3;
			this.int_1 = class14_0.int_0;
			this.int_0 = class14_0.int_1;
			this.int_2 = class14_0.int_2;
			this.int_3 = class14_0.int_3;
			this.string_5 = class14_0.string_5;
			this.string_6 = class14_0.string_6;
			this.int_4 = class14_0.int_4;
			this.list_0 = class14_0.list_0;
			this.bool_0 = class14_0.bool_0;
			this.bool_1 = class14_0.bool_1;
			this.bool_2 = class14_0.bool_2;
			this.bool_4 = class14_0.bool_3;
			this.int_5 = class14_0.int_5;
			this.int_6 = class14_0.int_6;
			this.class29_0 = class14_0.Class29_0;
			this.string_4 = class14_0.string_4;
			this.class21_0 = class14_0.class21_0;
			this.string_7 = class14_0.string_7;
			this.string_8 = class14_0.string_8;
			this.string_9 = class14_0.string_9;
			this.uint_1 = class14_0.uint_1;
			this.class28_0 = Phoenix.smethod_15().method_9().method_10(this.string_5, this.uint_0);
		}
		public void method_3(GClass5 gclass5_0, bool bool_5, bool bool_6)
		{
			gclass5_0.method_11(this.uint_0);
			if (this.class21_0 == null || !bool_5)
			{
				gclass5_0.method_13(false);
				gclass5_0.method_7(this.string_0);
				gclass5_0.method_7(this.string_3);
				gclass5_0.method_9(this.int_0);
				gclass5_0.method_9(this.int_2);
				gclass5_0.method_9(this.int_3);
				gclass5_0.method_7(this.string_1);
				gclass5_0.method_13(true);
				if (this.int_1 > 0)
				{
					gclass5_0.method_13(Phoenix.smethod_15().method_7().method_2(this.int_1).bool_0);
				}
				else
				{
					gclass5_0.method_13(false);
				}
				gclass5_0.method_9(this.int_4);
				gclass5_0.method_9(this.int_1);
				gclass5_0.method_7("");
				gclass5_0.method_9(this.Int32_0);
				using (List<string>.Enumerator enumerator = this.list_0.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						gclass5_0.method_7(current);
					}
					goto IL_1FA;
				}
			}
			gclass5_0.method_13(true);
			gclass5_0.method_7(this.class21_0.string_0);
			gclass5_0.method_7(this.string_3);
			gclass5_0.method_9(this.int_0);
			gclass5_0.method_9(this.int_2);
			gclass5_0.method_9(this.int_3);
			gclass5_0.method_7(this.class21_0.string_1);
			gclass5_0.method_13(true);
			gclass5_0.method_13(true);
			gclass5_0.method_9(this.int_4);
			gclass5_0.method_9(this.class21_0.int_0);
			gclass5_0.method_7(this.class21_0.string_2);
			gclass5_0.method_9(this.class21_0.list_0.Count);
			foreach (string current in this.class21_0.list_0)
			{
				gclass5_0.method_7(current);
			}
			IL_1FA:
			this.Class29_0.method_0(gclass5_0);
			gclass5_0.method_13(this.bool_0);
			gclass5_0.method_13(this.bool_1);
			if (bool_6)
			{
				gclass5_0.method_13(bool_6);
			}
		}
	}
}
