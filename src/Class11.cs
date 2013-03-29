using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class11
	{
		public uint uint_0;
		public string string_0;
		public string string_1;
		public bool bool_0;
		public bool bool_1;
		public bool bool_2;
		public string string_2;
		public string string_3;
		public uint uint_1;
		public string string_4;
		public string string_5;
		public string string_6;
		public int int_0;
		public DataTable dataTable_0;
		public List<int> list_0;
		public int int_1;
		public int int_2;
		public int int_3;
		public double double_0;
		public bool bool_3;
		public int int_4;
		internal bool bool_4 = false;
		public uint uint_2;
		public bool bool_5;
		public bool bool_6;
		public uint uint_3;
		public uint uint_4;
		public bool bool_7;
		public uint uint_5;
		public List<uint> list_1;
		public List<uint> list_2;
		public List<string> list_3;
		public Dictionary<uint, int> dictionary_0;
		public List<uint> list_4;
		private Class53 class53_0;
		private Class105 class105_0;
		private Class56 class56_0;
		private Class38 class38_0;
		private Class50 class50_0;
		private Class16 class16_0;
		public List<uint> list_5;
		public uint uint_6;
		public int int_5;
		public int int_6;
		public int int_7;
		public int int_8;
		public int int_9;
		public uint uint_7;
		public int int_10;
		public bool bool_8;
		public bool bool_9;
		public bool bool_10;
		public bool bool_11;
		public bool bool_12;
		public bool bool_13;
		public bool bool_14;
		public int int_11;
		public int int_12;
		public int int_13;
		public int int_14;
		public int int_15;
		public int int_16;
		public int int_17;
		public int int_18;
		public int int_19;
		public int int_20;
		public int int_21;
		public int int_22;
		private Class12 class12_0;
		internal List<Class27> list_6;
		public int int_23;
		public DateTime dateTime_0;
		public bool bool_15;
		public int int_24;
		private bool bool_16 = false;
		public bool Boolean_0
		{
			get
			{
				return this.uint_3 >= 1u;
			}
		}
		public Class14 Class14_0
		{
			get
			{
				Class14 result;
				if (this.uint_3 <= 0u)
				{
					result = null;
				}
				else
				{
					result = Phoenix.smethod_15().method_9().method_19(this.uint_3);
				}
				return result;
			}
		}
		internal Class12 Class12_0
		{
			get
			{
				return this.class12_0;
			}
		}
		internal string String_0
		{
			get
			{
				this.bool_16 = true;
				int num = (int)Phoenix.smethod_6() - this.int_16;
				string text = string.Concat(new object[]
				{
					"UPDATE users SET last_online = UNIX_TIMESTAMP(), online = '0', activity_points_lastupdate = '",
					this.double_0,
					"' WHERE id = '",
					this.uint_0,
					"' LIMIT 1; "
				});
				object obj = text;
				return string.Concat(new object[]
				{
					obj,
					"UPDATE user_stats SET RoomVisits = '",
					this.int_14,
					"', OnlineTime = OnlineTime + ",
					num,
					", Respect = '",
					this.int_17,
					"', RespectGiven = '",
					this.int_18,
					"', GiftsGiven = '",
					this.int_19,
					"', GiftsReceived = '",
					this.int_20,
					"' WHERE id = '",
					this.uint_0,
					"' LIMIT 1; "
				});
			}
		}
		public Class11(uint uint_8, string string_7, string string_8, string string_9, uint uint_9, string string_10, string string_11, string string_12, int int_25, int int_26, double double_1, bool bool_17, uint uint_10, int int_27, bool bool_18, bool bool_19, bool bool_20, bool bool_21, int int_28, int int_29, bool bool_22, string string_13, Class16 class16_1, Class12 class12_1)
		{
			if (class16_1 != null)
			{
				Phoenix.smethod_15().method_2().method_0(uint_8, string_7, class16_1);
			}
			this.uint_0 = uint_8;
			this.string_0 = string_7;
			this.string_1 = string_8;
			this.bool_0 = Class13.bool_15;
			this.bool_1 = true;
			this.string_2 = string_9;
			this.uint_1 = uint_9;
			this.string_4 = string_10;
			this.string_5 = Phoenix.smethod_7(string_11.ToLower());
			this.string_6 = string_12.ToLower();
			this.int_2 = int_25;
			this.int_12 = int_29;
			this.int_3 = int_26;
			this.double_0 = double_1;
			this.bool_2 = bool_22;
			this.bool_3 = bool_17;
			this.uint_2 = 0u;
			this.bool_5 = false;
			this.bool_6 = false;
			this.uint_3 = 0u;
			this.uint_4 = uint_10;
			this.list_1 = new List<uint>();
			this.list_2 = new List<uint>();
			this.list_3 = new List<string>();
			this.dictionary_0 = new Dictionary<uint, int>();
			this.list_4 = new List<uint>();
			this.int_10 = int_27;
			this.bool_10 = false;
			this.bool_11 = bool_18;
			this.bool_12 = bool_19;
			this.bool_13 = bool_20;
			this.bool_14 = bool_21;
			this.int_11 = int_28;
			this.int_1 = 0;
			this.int_24 = 1;
			this.string_3 = string_13;
			this.bool_7 = false;
			this.uint_5 = 0u;
			this.class16_0 = class16_1;
			this.class12_0 = class12_1;
			this.list_6 = new List<Class27>();
			this.list_0 = new List<int>();
			DataRow dataRow = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_0("user_id", uint_8);
				dataRow = @class.method_4("SELECT * FROM user_stats WHERE id = @user_id LIMIT 1");
				if (dataRow == null)
				{
					@class.method_1("INSERT INTO user_stats (id) VALUES ('" + uint_8 + "')");
					dataRow = @class.method_4("SELECT * FROM user_stats WHERE id = @user_id LIMIT 1");
				}
				this.dataTable_0 = @class.method_3("SELECT * FROM group_memberships WHERE userid = @user_id");
				IEnumerator enumerator;
				if (this.dataTable_0 != null)
				{
					enumerator = this.dataTable_0.Rows.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator.Current;
							Class5 class2 = Class4.smethod_2((int)dataRow2["groupid"]);
							if (class2 == null)
							{
								DataTable dataTable = @class.method_3("SELECT * FROM groups WHERE id = " + (int)dataRow2["groupid"] + " LIMIT 1;");
								IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										DataRow dataRow3 = (DataRow)enumerator2.Current;
										if (!Class4.dictionary_0.ContainsKey((int)dataRow3["id"]))
										{
											Class4.dictionary_0.Add((int)dataRow3["id"], new Class5((int)dataRow3["id"], dataRow3, @class));
										}
									}
									continue;
								}
								finally
								{
									IDisposable disposable = enumerator2 as IDisposable;
									if (disposable != null)
									{
										disposable.Dispose();
									}
								}
							}
							if (!class2.list_0.Contains((int)uint_8))
							{
								class2.method_0((int)uint_8);
							}
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					int num = (int)dataRow["groupid"];
					Class5 class3 = Class4.smethod_2(num);
					if (class3 != null)
					{
						this.int_0 = num;
					}
					else
					{
						this.int_0 = 0;
					}
				}
				else
				{
					this.int_0 = 0;
				}
				DataTable dataTable2 = @class.method_3("SELECT groupid FROM group_requests WHERE userid = '" + uint_8 + "';");
				enumerator = dataTable2.Rows.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator.Current;
						this.list_0.Add((int)dataRow2["groupid"]);
					}
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
			this.int_14 = (int)dataRow["RoomVisits"];
			this.int_16 = (int)Phoenix.smethod_6();
			this.int_15 = (int)dataRow["OnlineTime"];
			this.int_17 = (int)dataRow["Respect"];
			this.int_18 = (int)dataRow["RespectGiven"];
			this.int_19 = (int)dataRow["GiftsGiven"];
			this.int_20 = (int)dataRow["GiftsReceived"];
			this.int_21 = (int)dataRow["DailyRespectPoints"];
			this.int_22 = (int)dataRow["DailyPetRespectPoints"];
			this.int_13 = (int)dataRow["AchievementScore"];
			this.list_5 = new List<uint>();
			this.uint_7 = 0u;
			this.uint_6 = (uint)dataRow["quest_id"];
			this.int_5 = (int)dataRow["quest_progress"];
			this.int_6 = (int)dataRow["lev_builder"];
			this.int_8 = (int)dataRow["lev_identity"];
			this.int_7 = (int)dataRow["lev_social"];
			this.int_9 = (int)dataRow["lev_explore"];
			if (class16_1 != null)
			{
				this.class53_0 = new Class53(uint_8, class12_1);
				this.class56_0 = new Class56(uint_8, class12_1);
				this.class38_0 = new Class38(uint_8, class16_1, class12_1);
				this.class50_0 = new Class50(uint_8, class16_1, class12_1);
				this.bool_8 = false;
				this.bool_9 = false;
				foreach (DataRow dataRow3 in class12_1.DataTable_10.Rows)
				{
					this.list_6.Add(Phoenix.smethod_15().method_9().method_17((uint)dataRow3["id"], dataRow3));
				}
			}
		}
		public void method_0(Class6 class6_0)
		{
			this.dataTable_0 = class6_0.method_3("SELECT * FROM group_memberships WHERE userid = " + this.uint_0);
			if (this.dataTable_0 != null)
			{
				foreach (DataRow dataRow in this.dataTable_0.Rows)
				{
					Class5 @class = Class4.smethod_2((int)dataRow["groupid"]);
					if (@class == null)
					{
						DataTable dataTable = class6_0.method_3("SELECT * FROM groups WHERE id = " + (int)dataRow["groupid"] + " LIMIT 1;");
						IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								DataRow dataRow2 = (DataRow)enumerator2.Current;
								if (!Class4.dictionary_0.ContainsKey((int)dataRow2["id"]))
								{
									Class4.dictionary_0.Add((int)dataRow2["id"], new Class5((int)dataRow2["id"], dataRow2, class6_0));
								}
							}
							continue;
						}
						finally
						{
							IDisposable disposable = enumerator2 as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
					}
					if (!@class.list_0.Contains((int)this.uint_0))
					{
						@class.method_0((int)this.uint_0);
					}
				}
				int num = class6_0.method_6("SELECT groupid FROM user_stats WHERE id = " + this.uint_0 + " LIMIT 1");
				Class5 class2 = Class4.smethod_2(num);
				if (class2 != null)
				{
					this.int_0 = num;
				}
				else
				{
					this.int_0 = 0;
				}
			}
			else
			{
				this.int_0 = 0;
			}
		}
		internal void method_1(Class6 class6_0)
		{
			this.list_6.Clear();
			class6_0.method_0("name", this.string_0);
			DataTable dataTable = class6_0.method_3("SELECT * FROM rooms WHERE owner = @name ORDER BY id ASC");
			foreach (DataRow dataRow in dataTable.Rows)
			{
				this.list_6.Add(Phoenix.smethod_15().method_9().method_17((uint)dataRow["id"], dataRow));
			}
		}
		public void method_2(Class12 class12_1)
		{
			this.method_8(class12_1);
			this.method_5(class12_1);
			this.method_6(class12_1);
			this.method_7(class12_1);
			this.method_25();
		}
		public bool method_3(string string_7)
		{
			bool result;
			if (Phoenix.smethod_15().method_4().method_3(this.uint_0))
			{
				result = Phoenix.smethod_15().method_4().method_4(this.uint_0, string_7);
			}
			else
			{
				result = Phoenix.smethod_15().method_4().method_1(this.uint_1, string_7);
			}
			return result;
		}
		public int method_4()
		{
			int result;
			if (this.bool_0)
			{
				result = 0;
			}
			else
			{
				result = Phoenix.smethod_15().method_4().method_2(this.uint_1);
			}
			return result;
		}
		public void method_5(Class12 class12_1)
		{
			this.list_1.Clear();
			DataTable dataTable_ = class12_1.DataTable_1;
			foreach (DataRow dataRow in dataTable_.Rows)
			{
				this.list_1.Add((uint)dataRow["room_id"]);
			}
		}
		public void method_6(Class12 class12_1)
		{
			DataTable dataTable_ = class12_1.DataTable_2;
			foreach (DataRow dataRow in dataTable_.Rows)
			{
				this.list_2.Add((uint)dataRow["ignore_id"]);
			}
		}
		public void method_7(Class12 class12_1)
		{
			this.list_3.Clear();
			DataTable dataTable_ = class12_1.DataTable_3;
			foreach (DataRow dataRow in dataTable_.Rows)
			{
				this.list_3.Add((string)dataRow["tag"]);
			}
			if (this.list_3.Count >= 5 && this.method_19() != null)
			{
				Phoenix.smethod_15().method_12().method_3(this.method_19(), 7u, 1);
			}
		}
		public void method_8(Class12 class12_1)
		{
			DataTable dataTable = class12_1.DataTable_0;
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					this.dictionary_0.Add((uint)dataRow["achievement_id"], (int)dataRow["achievement_level"]);
				}
			}
		}
		public void method_9()
		{
			if (!this.bool_9)
			{
				this.bool_9 = true;
				Phoenix.smethod_15().method_2().method_1(this.uint_0, this.string_0);
				if (!this.bool_16)
				{
					this.bool_16 = true;
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_1(string.Concat(new object[]
						{
							"UPDATE users SET last_online = UNIX_TIMESTAMP(), users.online = '0', activity_points = '",
							this.int_3,
							"', activity_points_lastupdate = '",
							this.double_0,
							"', credits = '",
							this.int_2,
							"' WHERE id = '",
							this.uint_0,
							"' LIMIT 1;"
						}));
						int num = (int)Phoenix.smethod_6() - this.int_16;
						@class.method_1(string.Concat(new object[]
						{
							"UPDATE user_stats SET RoomVisits = '",
							this.int_14,
							"', OnlineTime = OnlineTime + ",
							num,
							", Respect = '",
							this.int_17,
							"', RespectGiven = '",
							this.int_18,
							"', GiftsGiven = '",
							this.int_19,
							"', GiftsReceived = '",
							this.int_20,
							"' WHERE id = '",
							this.uint_0,
							"' LIMIT 1; "
						}));
					}
				}
				if (this.Boolean_0 && this.Class14_0 != null)
				{
					this.Class14_0.method_47(this.class16_0, false, false);
				}
				if (this.class105_0 != null)
				{
					this.class105_0.bool_0 = true;
					this.class105_0.method_5(true);
					this.class105_0 = null;
				}
				if (this.class53_0 != null)
				{
					this.class53_0.method_0();
					this.class53_0 = null;
				}
				this.class38_0.method_18();
			}
		}
		internal void method_10(uint uint_8)
		{
			if (Class13.Boolean_6)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"INSERT INTO user_roomvisits (user_id,room_id,entry_timestamp,exit_timestamp,hour,minute) VALUES ('",
						this.uint_0,
						"','",
						uint_8,
						"',UNIX_TIMESTAMP(),'0','",
						DateTime.Now.Hour,
						"','",
						DateTime.Now.Minute,
						"')"
					}));
				}
			}
			this.uint_3 = uint_8;
			if (this.Class14_0.string_3 != this.string_0 && this.uint_6 == 15u)
			{
				Phoenix.smethod_15().method_16().method_1(15u, this.method_19());
			}
			this.class105_0.method_5(false);
		}
		public void method_11()
		{
			try
			{
				if (Class13.Boolean_6)
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_1(string.Concat(new object[]
						{
							"UPDATE user_roomvisits SET exit_timestamp = UNIX_TIMESTAMP() WHERE room_id = '",
							this.uint_3,
							"' AND user_id = '",
							this.uint_0,
							"' ORDER BY entry_timestamp DESC LIMIT 1"
						}));
					}
				}
			}
			catch
			{
			}
			this.uint_3 = 0u;
			if (this.class105_0 != null)
			{
				this.class105_0.method_5(false);
			}
		}
		public void method_12()
		{
			if (this.method_21() == null)
			{
				this.class105_0 = new Class105(this.uint_0);
				this.class105_0.method_0(this.class12_0);
				this.class105_0.method_1(this.class12_0);
				Class16 @class = this.method_19();
				if (@class != null)
				{
					@class.method_14(this.class105_0.method_21());
					@class.method_14(this.class105_0.method_23());
					this.class105_0.method_5(true);
				}
			}
		}
		public void method_13(bool bool_17)
		{
			GClass5 gClass = new GClass5(6u);
			gClass.method_7(this.int_2 + ".0");
			this.class16_0.method_14(gClass);
			if (bool_17)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE users SET credits = '",
						this.int_2,
						"' WHERE id = '",
						this.uint_0,
						"' LIMIT 1;"
					}));
				}
			}
		}
		public void method_14(bool bool_17, bool bool_18)
		{
			if (bool_17)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					this.int_12 = @class.method_6("SELECT vip_points FROM users WHERE id = '" + this.uint_0 + "' LIMIT 1;");
				}
			}
			if (bool_18)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE users SET vip_points = '",
						this.int_12,
						"' WHERE id = '",
						this.uint_0,
						"' LIMIT 1;"
					}));
				}
			}
			this.method_16(0);
		}
		public void method_15(bool bool_17)
		{
			this.method_16(0);
			if (bool_17)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE users SET activity_points = '",
						this.int_3,
						"' WHERE id = '",
						this.uint_0,
						"' LIMIT 1;"
					}));
				}
			}
		}
		public void method_16(int int_25)
		{
			GClass5 gClass = new GClass5(438u);
			gClass.method_9(this.int_3);
			gClass.method_9(int_25);
			gClass.method_9(0);
			GClass5 gClass2 = new GClass5(438u);
			gClass2.method_9(this.int_12);
			gClass2.method_9(0);
			gClass2.method_9(1);
			GClass5 gClass3 = new GClass5(438u);
			gClass3.method_9(this.int_12);
			gClass3.method_9(0);
			gClass3.method_9(2);
			GClass5 gClass4 = new GClass5(438u);
			gClass4.method_9(this.int_12);
			gClass4.method_9(0);
			gClass4.method_9(3);
			GClass5 gClass5 = new GClass5(438u);
			gClass5.method_9(this.int_12);
			gClass5.method_9(0);
			gClass5.method_9(4);
			this.class16_0.method_14(gClass);
			this.class16_0.method_14(gClass2);
			this.class16_0.method_14(gClass3);
			this.class16_0.method_14(gClass4);
			this.class16_0.method_14(gClass5);
		}
		public void method_17()
		{
			if (!this.bool_3)
			{
				this.method_19().method_8("You have been muted by a moderator.");
				this.bool_3 = true;
			}
		}
		public void method_18()
		{
			if (this.bool_3)
			{
				this.bool_3 = false;
			}
		}
		private Class16 method_19()
		{
			return Phoenix.smethod_15().method_2().method_2(this.uint_0);
		}
		public Class53 method_20()
		{
			return this.class53_0;
		}
		public Class105 method_21()
		{
			return this.class105_0;
		}
		public Class56 method_22()
		{
			return this.class56_0;
		}
		public Class38 method_23()
		{
			return this.class38_0;
		}
		public Class50 method_24()
		{
			return this.class50_0;
		}
		public void method_25()
		{
			this.list_5.Clear();
			DataTable dataTable = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataTable = @class.method_3("SELECT quest_id FROM user_quests WHERE user_id = '" + this.uint_0 + "'");
			}
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					this.list_5.Add((uint)dataRow["quest_Id"]);
				}
			}
		}
		public void method_26(bool bool_17, Class16 class16_1)
		{
			GClass5 gClass = new GClass5(266u);
			gClass.method_9(-1);
			gClass.method_7(class16_1.method_2().string_5);
			gClass.method_7(class16_1.method_2().string_6.ToLower());
			gClass.method_7(class16_1.method_2().string_4);
			gClass.method_9(class16_1.method_2().int_13);
			gClass.method_7("");
			class16_1.method_14(gClass);
			if (class16_1.method_2().Boolean_0)
			{
				Class14 class14_ = class16_1.method_2().Class14_0;
				if (class14_ != null)
				{
					Class33 @class = class14_.method_53(class16_1.method_2().uint_0);
					if (@class != null)
					{
						if (bool_17)
						{
							DataRow dataRow = null;
							using (Class6 class2 = Phoenix.smethod_12().method_0())
							{
								class2.method_0("userid", class16_1.method_2().uint_0);
								dataRow = class2.method_4("SELECT * FROM users WHERE id = @userid LIMIT 1");
							}
							class16_1.method_2().string_4 = Phoenix.smethod_7((string)dataRow["motto"]);
							class16_1.method_2().string_5 = Phoenix.smethod_7((string)dataRow["look"]);
						}
						GClass5 gClass2 = new GClass5(266u);
						gClass2.method_9(@class.int_0);
						gClass2.method_7(class16_1.method_2().string_5);
						gClass2.method_7(class16_1.method_2().string_6.ToLower());
						gClass2.method_7(class16_1.method_2().string_4);
						gClass2.method_9(class16_1.method_2().int_13);
						gClass2.method_7("");
						class14_.method_59(gClass2, null);
					}
				}
			}
		}
		public void method_27()
		{
			DataRow dataRow;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataRow = @class.method_4("SELECT vip FROM users WHERE id = '" + this.uint_0 + "' LIMIT 1;");
			}
			this.bool_14 = Phoenix.smethod_3(dataRow["vip"].ToString());
			GClass5 gClass = new GClass5(2u);
			if (this.bool_14 || Class13.Boolean_3)
			{
				gClass.method_9(2);
			}
			else
			{
				if (this.method_20().method_2("habbo_club"))
				{
					gClass.method_9(1);
				}
				else
				{
					gClass.method_9(0);
				}
			}
			if (this.method_3("acc_anyroomowner"))
			{
				gClass.method_9(7);
			}
			else
			{
				if (this.method_3("acc_anyroomrights"))
				{
					gClass.method_9(5);
				}
				else
				{
					if (this.method_3("acc_supporttool"))
					{
						gClass.method_9(4);
					}
					else
					{
						if (this.bool_14 || Class13.Boolean_3 || this.method_20().method_2("habbo_club"))
						{
							gClass.method_9(2);
						}
						else
						{
							gClass.method_9(0);
						}
					}
				}
			}
			this.method_19().method_14(gClass);
		}
		public void method_28(string string_7)
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(this.uint_3);
			if (@class != null)
			{
				Class33 class2 = @class.method_53(this.uint_0);
				GClass5 gClass = new GClass5(25u);
				gClass.method_9(class2.int_0);
				gClass.method_7(string_7);
				gClass.method_13(false);
				this.method_19().method_14(gClass);
			}
		}
	}
}
