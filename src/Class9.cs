using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class9
	{
		public List<Class10> list_0;
		public Class9()
		{
			this.list_0 = new List<Class10>();
		}
		public void method_0()
		{
			GClass4.smethod_0("Loading Quests..");
			this.list_0.Clear();
			DataTable dataTable = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataTable = @class.method_3("SELECT id,type,action,needofcount,level_num,pixel_reward FROM quests WHERE enabled = '1' ORDER by level_num");
			}
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Class10 class2 = new Class10((uint)dataRow["id"], (string)dataRow["type"], (string)dataRow["action"], (int)dataRow["needofcount"], (int)dataRow["level_num"], (int)dataRow["pixel_reward"]);
					if (class2 != null)
					{
						this.list_0.Add(class2);
					}
				}
				GClass4.smethod_1("completed!");
			}
		}
		public void method_1(uint uint_0, Class16 class16_0)
		{
			class16_0.method_2().int_5++;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1("UPDATE user_stats SET quest_progress = quest_progress + 1 WHERE id = '" + class16_0.method_2().uint_0 + "' LIMIT 1");
			}
			Phoenix.smethod_15().method_16().method_7(uint_0, class16_0);
		}
		public int method_2(string string_0)
		{
			int num = 0;
			foreach (Class10 current in this.list_0)
			{
				if (current.string_0 == string_0)
				{
					num++;
				}
			}
			return num;
		}
		public uint method_3(int int_0, string string_0)
		{
			uint result;
			foreach (Class10 current in this.list_0)
			{
				if (current.string_0 == string_0 && current.int_1 == int_0 + 1)
				{
					result = current.method_0();
					return result;
				}
			}
			result = 0u;
			return result;
		}
		public void method_4(Class16 class16_0)
		{
			Class10 @class = this.method_6(class16_0.method_2().uint_7);
			string text = @class.string_0.ToLower();
			int int_ = 0;
			string text2 = text;
			if (text2 != null)
			{
				if (!(text2 == "social"))
				{
					if (!(text2 == "room_builder"))
					{
						if (!(text2 == "identity"))
						{
							if (text2 == "explore")
							{
								int_ = class16_0.method_2().int_9;
							}
						}
						else
						{
							int_ = class16_0.method_2().int_8;
						}
					}
					else
					{
						int_ = class16_0.method_2().int_6;
					}
				}
				else
				{
					int_ = class16_0.method_2().int_7;
				}
			}
			if (this.method_3(int_, text) != 0u)
			{
				this.method_7(this.method_3(int_, text), class16_0);
			}
		}
		public GClass5 method_5(Class16 class16_0)
		{
			GClass5 gClass = new GClass5(800u);
			gClass.method_9(4);
			this.method_9(class16_0, gClass);
			gClass.method_9(1);
			return gClass;
		}
		public Class10 method_6(uint uint_0)
		{
			Class10 result;
			foreach (Class10 current in this.list_0)
			{
				if (current.method_0() == uint_0)
				{
					result = current;
					return result;
				}
			}
			result = null;
			return result;
		}
		public void method_7(uint uint_0, Class16 class16_0)
		{
			if (class16_0 != null)
			{
				if (class16_0.method_2().uint_6 != uint_0)
				{
					class16_0.method_2().uint_6 = uint_0;
					class16_0.method_2().int_5 = 0;
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_0("uid", class16_0.method_2().uint_0);
						@class.method_0("qid", uint_0);
						@class.method_1("UPDATE user_stats SET quest_id = @qid, quest_progress = '0' WHERE id = @uid LIMIT 1");
					}
				}
				if (uint_0 == 0u)
				{
					class16_0.method_14(this.method_5(class16_0));
					GClass5 gclass5_ = new GClass5(803u);
					class16_0.method_14(gclass5_);
				}
				else
				{
					Class10 class2 = this.method_6(uint_0);
					if (class2.int_0 <= class16_0.method_2().int_5)
					{
						this.method_8(uint_0, class16_0);
					}
					else
					{
						GClass5 gclass5_ = new GClass5(802u);
						class2.method_1(gclass5_, class16_0, true);
						class16_0.method_14(gclass5_);
					}
				}
			}
		}
		public void method_8(uint uint_0, Class16 class16_0)
		{
			class16_0.method_2().uint_6 = 0u;
			class16_0.method_2().uint_7 = uint_0;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_0("userid", class16_0.method_2().uint_0);
				@class.method_0("questid", uint_0);
				@class.method_1(string.Concat(new string[]
				{
					"UPDATE user_stats SET quest_id = '0',quest_progress = '0', lev_",
					this.method_6(uint_0).string_0.Replace("room_", ""),
					" = lev_",
					this.method_6(uint_0).string_0.Replace("room_", ""),
					" + 1 WHERE id = @userid LIMIT 1"
				}));
				@class.method_1("INSERT INTO user_quests (user_id,quest_id) VALUES (@userid,@questid)");
			}
			string text = this.method_6(uint_0).string_0.ToLower();
			if (text != null)
			{
				if (!(text == "identity"))
				{
					if (!(text == "room_builder"))
					{
						if (!(text == "social"))
						{
							if (text == "explore")
							{
								class16_0.method_2().int_9++;
							}
						}
						else
						{
							class16_0.method_2().int_7++;
						}
					}
					else
					{
						class16_0.method_2().int_6++;
					}
				}
				else
				{
					class16_0.method_2().int_8++;
				}
			}
			class16_0.method_2().method_25();
			GClass5 gClass = new GClass5(801u);
			Class10 class2 = this.method_6(uint_0);
			class2.method_1(gClass, class16_0, true);
			this.method_9(class16_0, gClass);
			gClass.method_9(1);
			class16_0.method_14(gClass);
			class16_0.method_2().int_3 += class2.int_2;
			class16_0.method_2().method_15(true);
			class16_0.method_2().int_5 = 0;
		}
		public void method_9(Class16 class16_0, GClass5 gclass5_0)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			foreach (Class10 current in this.list_0)
			{
				if (current.method_0() == class16_0.method_2().uint_6)
				{
					current.method_1(gclass5_0, class16_0, false);
					string text = current.string_0.ToLower();
					if (text != null)
					{
						if (!(text == "social"))
						{
							if (!(text == "room_builder"))
							{
								if (!(text == "identity"))
								{
									if (text == "explore")
									{
										flag4 = true;
									}
								}
								else
								{
									flag3 = true;
								}
							}
							else
							{
								flag2 = true;
							}
						}
						else
						{
							flag = true;
						}
					}
				}
				if (current.string_0.ToLower() == "room_builder" && num2 < class16_0.method_2().int_6)
				{
					num2 = current.int_1;
				}
				if (current.string_0.ToLower() == "social" && num < class16_0.method_2().int_7)
				{
					num = current.int_1;
				}
				if (current.string_0.ToLower() == "identity" && num3 < class16_0.method_2().int_8)
				{
					num3 = current.int_1;
				}
				if (current.string_0.ToLower() == "explore" && num4 < class16_0.method_2().int_9)
				{
					num4 = current.int_1;
				}
				if (current.string_0.ToLower() == "room_builder" && !flag2 && current.int_1 == this.method_2("room_builder") && class16_0.method_2().int_6 == this.method_2("room_builder"))
				{
					current.method_1(gclass5_0, class16_0, false);
					flag2 = true;
				}
				if (current.string_0.ToLower() == "social" && !flag && current.int_1 == this.method_2("social") && class16_0.method_2().int_7 == this.method_2("room_social"))
				{
					current.method_1(gclass5_0, class16_0, false);
					flag = true;
				}
				if (current.string_0.ToLower() == "identity" && !flag3 && current.int_1 == this.method_2("identity") && class16_0.method_2().int_8 == this.method_2("identity"))
				{
					current.method_1(gclass5_0, class16_0, false);
					flag3 = true;
				}
				if (current.string_0.ToLower() == "explore" && !flag4 && current.int_1 == this.method_2("explore") && class16_0.method_2().int_9 == this.method_2("explore"))
				{
					current.method_1(gclass5_0, class16_0, false);
					flag4 = true;
				}
				if (current.string_0.ToLower() == "room_builder" && !flag2 && current.int_1 == class16_0.method_2().int_6 + 1)
				{
					current.method_1(gclass5_0, class16_0, false);
					flag2 = true;
				}
				if (current.string_0.ToLower() == "social" && !flag && current.int_1 == class16_0.method_2().int_7 + 1)
				{
					current.method_1(gclass5_0, class16_0, false);
					flag = true;
				}
				if (current.string_0.ToLower() == "identity" && !flag3 && current.int_1 == class16_0.method_2().int_8 + 1)
				{
					current.method_1(gclass5_0, class16_0, false);
					flag3 = true;
				}
				if (current.string_0.ToLower() == "explore" && !flag4 && current.int_1 == class16_0.method_2().int_9 + 1)
				{
					current.method_1(gclass5_0, class16_0, false);
					flag4 = true;
				}
			}
			if (!flag2 || !flag || !flag3 || !flag4)
			{
				foreach (Class10 current in this.list_0)
				{
					if (current.string_0.ToLower() == "room_builder" && !flag2 && current.int_1 == num2)
					{
						current.method_1(gclass5_0, class16_0, false);
						flag2 = true;
					}
					if (current.string_0.ToLower() == "social" && !flag && current.int_1 == num)
					{
						current.method_1(gclass5_0, class16_0, false);
						flag = true;
					}
					if (current.string_0.ToLower() == "identity" && !flag3 && current.int_1 == num3)
					{
						current.method_1(gclass5_0, class16_0, false);
						flag3 = true;
					}
					if (current.string_0.ToLower() == "explore" && !flag4 && current.int_1 == num4)
					{
						current.method_1(gclass5_0, class16_0, false);
						flag4 = true;
					}
				}
			}
		}
	}
}
