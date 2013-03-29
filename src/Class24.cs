using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
namespace ns0
{
	internal sealed class Class24
	{
		private readonly object object_0 = new object();
		private Class25 class25_0;
		private List<uint> list_0;
		private Dictionary<string, Class28> dictionary_0;
		private Hashtable hashtable_0;
		private List<Class109> list_1;
		private Task task_0;
		private DateTime dateTime_0;
		private List<uint> list_2;
		internal List<Class27> list_3;
		internal int Int32_0
		{
			get
			{
				return this.class25_0.Count;
			}
		}
		internal int Int32_1
		{
			get
			{
				int result = 0;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					result = int.Parse(@class.method_5("SELECT COUNT(*) FROM rooms"));
				}
				return result;
			}
		}
		public Class24()
		{
			this.class25_0 = new Class25();
			this.list_0 = new List<uint>();
			this.dictionary_0 = new Dictionary<string, Class28>();
			this.list_1 = new List<Class109>();
			this.list_2 = new List<uint>();
			this.hashtable_0 = new Hashtable();
			this.task_0 = new Task(new Action(this.method_7));
			this.task_0.Start();
		}
		internal void method_0()
		{
			GClass4.smethod_0("Loading Room Cache..");
			this.list_3 = new List<Class27>();
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				for (int i = 0; i < 12; i++)
				{
					DataTable dataTable = @class.method_3("SELECT * FROM rooms WHERE category = '" + i + "' AND roomtype = 'private' ORDER BY users_now DESC LIMIT 40");
					foreach (DataRow dataRow in dataTable.Rows)
					{
						this.list_3.Add(this.method_17((uint)dataRow["id"], dataRow));
					}
				}
			}
			GClass4.smethod_1("completed!");
		}
		private bool method_1(uint uint_0)
		{
			bool result;
			foreach (Class27 current in this.list_3)
			{
				if (current.uint_0 == uint_0)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		internal void method_2(uint uint_0)
		{
			if (this.method_1(uint_0))
			{
				this.method_0();
			}
		}
		internal void method_3(string string_0, uint uint_0, uint uint_1, string string_1)
		{
		}
		internal void method_4()
		{
			using (Class26 class26_ = this.class25_0.Class26_0)
			{
				IEnumerator enumerator;
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					enumerator = class26_.Values.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Class14 class2 = (Class14)enumerator.Current;
							class2.method_65(@class);
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
				if (Phoenix.smethod_11().dictionary_0["emu.messages.roommgr"] == "1")
				{
					Console.WriteLine("[RoomMgr] Done with furniture saving, disposing rooms");
				}
				enumerator = class26_.Values.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class14 class2 = (Class14)enumerator.Current;
						try
						{
							class2.method_62();
						}
						catch
						{
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
				if (Phoenix.smethod_11().dictionary_0["emu.messages.roommgr"] == "1")
				{
					Console.WriteLine("[RoomMgr] Done disposing rooms!");
				}
			}
		}
		public void method_5(Class109 class109_0)
		{
			this.list_1.Add(class109_0);
		}
		public List<Class14> method_6(int int_0)
		{
			List<Class14> list = new List<Class14>();
			try
			{
				using (Class26 class26_ = this.class25_0.Class26_0)
				{
					foreach (Class14 @class in class26_.Values)
					{
						if (@class.class21_0 != null && (int_0 <= 0 || @class.class21_0.int_0 == int_0))
						{
							list.Add(@class);
						}
					}
				}
			}
			catch
			{
			}
			return list;
		}
		private void method_7()
		{
			Thread.Sleep(5000);
			while (true)
			{
				try
				{
					if (this.list_1.Count > 0)
					{
						DateTime now = DateTime.Now;
						try
						{
							try
							{
								this.dateTime_0 = DateTime.Now;
								List<Class109> list = null;
								using (GStruct0.smethod_0(this.list_1))
								{
									list = this.list_1;
									this.list_1 = new List<Class109>();
								}
								if (list != null)
								{
									foreach (Class109 current in list)
									{
										if (current != null)
										{
											current.method_0();
										}
									}
								}
							}
							catch (Exception ex)
							{
								GClass4.smethod_2("Tele code error: " + ex.ToString());
							}
							continue;
						}
						finally
						{
							DateTime now2 = DateTime.Now;
							double num = 500.0 - (now2 - now).TotalMilliseconds;
							if (num < 0.0)
							{
								num = 0.0;
							}
							if (num > 500.0)
							{
								num = 500.0;
							}
							Thread.Sleep((int)Math.Floor(num));
						}
					}
					Thread.Sleep(500);
				}
				catch (Exception ex)
				{
					GClass4.smethod_6(ex.ToString(), "Room manager task (Process engine)");
					try
					{
						if (this.list_1 != null)
						{
							this.list_1.Clear();
						}
					}
					catch
					{
					}
					Thread.Sleep(500);
				}
			}
		}
		public void method_8(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Room Models..");
			this.dictionary_0.Clear();
			DataTable dataTable = class6_0.method_3("SELECT id,door_x,door_y,door_z,door_dir,heightmap,public_items,club_only FROM room_models");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					string text = (string)dataRow["id"];
					this.dictionary_0.Add(text, new Class28(text, (int)dataRow["door_x"], (int)dataRow["door_y"], (double)dataRow["door_z"], (int)dataRow["door_dir"], (string)dataRow["heightmap"], (string)dataRow["public_items"], Phoenix.smethod_3(dataRow["club_only"].ToString())));
				}
				GClass4.smethod_1("completed!");
			}
		}
		private Class28 method_9(uint uint_0)
		{
			DataRow dataRow;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataRow = @class.method_4("SELECT doorx,doory,height,modeldata FROM room_models_customs WHERE roomid = '" + uint_0 + "'");
			}
			return new Class28("custom", (int)dataRow["doorx"], (int)dataRow["doory"], (double)dataRow["height"], 2, (string)dataRow["modeldata"], "", false);
		}
		public Class28 method_10(string string_0, uint uint_0)
		{
			Class28 result;
			if (string_0 == "custom")
			{
				result = this.method_9(uint_0);
			}
			else
			{
				if (this.dictionary_0.ContainsKey(string_0))
				{
					result = this.dictionary_0[string_0];
				}
				else
				{
					result = null;
				}
			}
			return result;
		}
		public Class27 method_11(uint uint_0)
		{
			Class27 result;
			if (this.method_12(uint_0) != null)
			{
				result = this.method_12(uint_0);
			}
			else
			{
				Class27 @class = new Class27();
				@class.method_0(uint_0);
				result = @class;
			}
			return result;
		}
		public Class27 method_12(uint uint_0)
		{
			Class27 @class = new Class27();
			Class27 result;
			lock (this.hashtable_0)
			{
				if (this.hashtable_0.ContainsKey(uint_0))
				{
					result = (this.hashtable_0[uint_0] as Class27);
					return result;
				}
				if (this.method_13(uint_0))
				{
					result = this.method_19(uint_0).Class27_0;
					return result;
				}
				DataRow dataRow = null;
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					dataRow = class2.method_4("SELECT * FROM rooms WHERE id = '" + uint_0 + "' LIMIT 1");
				}
				if (dataRow == null)
				{
					result = null;
					return result;
				}
				@class.method_1(dataRow);
			}
			if (!this.hashtable_0.ContainsKey(uint_0))
			{
				this.hashtable_0.Add(uint_0, @class);
			}
			result = @class;
			return result;
		}
		public bool method_13(uint uint_0)
		{
			return this.class25_0.ContainsKey(uint_0);
		}
		public bool method_14(uint uint_0)
		{
			return this.list_0.Contains(uint_0);
		}
		internal Class14 method_15(uint uint_0)
		{
			Class14 @class = null;
			Class14 result;
			try
			{
				lock (this.object_0)
				{
					if (this.method_13(uint_0))
					{
						result = this.method_19(uint_0);
						return result;
					}
					Class27 class2 = this.method_12(uint_0);
					if (class2 == null)
					{
						result = null;
						return result;
					}
					@class = new Class14(class2.uint_0, class2.string_0, class2.string_1, class2.string_2, class2.string_3, class2.int_1, class2.int_0, class2.int_3, class2.string_5, class2.string_6, class2.int_4, class2.list_0, class2.bool_0, class2.bool_1, class2.bool_2, class2.bool_4, class2.Class29_0, class2.string_4, class2.string_7, class2.string_8, class2.string_9, class2, class2.bool_3, class2.int_5, class2.int_6, class2.uint_1);
					this.class25_0.Add(@class.UInt32_0, @class);
				}
			}
			catch
			{
				GClass4.smethod_1("Error while loading room " + uint_0 + ", we crashed out..");
				result = null;
				return result;
			}
			@class.method_0();
			@class.method_1();
			result = @class;
			return result;
		}
		internal void method_16(Class14 class14_0)
		{
			if (class14_0 != null)
			{
				this.class25_0.Remove(class14_0.UInt32_0);
				this.method_18(class14_0.UInt32_0);
				class14_0.method_62();
				if (Phoenix.smethod_11().dictionary_0["emu.messages.roommgr"] == "1")
				{
					GClass4.smethod_1("[RoomMgr] Unloaded room [ID: " + class14_0.UInt32_0 + "]");
				}
			}
		}
		public Class27 method_17(uint uint_0, DataRow dataRow_0)
		{
			Class27 result;
			if (this.hashtable_0.ContainsKey(uint_0))
			{
				result = (this.hashtable_0[uint_0] as Class27);
			}
			else
			{
				Class27 @class = new Class27();
				if (this.method_13(uint_0))
				{
					@class = this.method_19(uint_0).Class27_0;
				}
				else
				{
					@class.method_1(dataRow_0);
				}
				this.hashtable_0.Add(uint_0, @class);
				result = @class;
			}
			return result;
		}
		public void method_18(uint uint_0)
		{
			this.hashtable_0.Remove(uint_0);
		}
		public Class14 method_19(uint uint_0)
		{
			Class14 result;
			if (this.class25_0.ContainsKey(uint_0))
			{
				result = (this.class25_0[uint_0] as Class14);
			}
			else
			{
				result = null;
			}
			return result;
		}
		public Class27 method_20(Class16 class16_0, string string_0, string string_1)
		{
			string_0 = Phoenix.smethod_7(string_0);
			Class27 result;
			if (!this.dictionary_0.ContainsKey(string_1))
			{
				class16_0.method_8("Sorry, this room model has not been added yet. Try again later.");
				result = null;
			}
			else
			{
				if (this.dictionary_0[string_1].bool_0 && !class16_0.method_2().method_20().method_2("habbo_club") && !class16_0.method_2().method_20().method_2("habbo_vip"))
				{
					class16_0.method_8("You must be an Phoenix Club member to use that room layout.");
					result = null;
				}
				else
				{
					if (string_0.Length < 3)
					{
						class16_0.method_8("Room name is too short for room creation!");
						result = null;
					}
					else
					{
						uint uint_ = 0u;
						using (Class6 @class = Phoenix.smethod_12().method_0())
						{
							@class.method_0("caption", string_0);
							@class.method_0("model", string_1);
							@class.method_0("username", class16_0.method_2().string_0);
							@class.method_1("INSERT INTO rooms (roomtype,caption,owner,model_name) VALUES ('private',@caption,@username,@model)");
							class16_0.method_2().Class12_0.DataTable_10 = @class.method_3("SELECT * FROM rooms WHERE owner = @username ORDER BY id ASC");
							uint_ = (uint)@class.method_4("SELECT id FROM rooms WHERE owner = @username AND caption = @caption ORDER BY id DESC")[0];
							class16_0.method_2().method_1(@class);
						}
						result = this.method_12(uint_);
					}
				}
			}
			return result;
		}
		internal Dictionary<Class14, int> method_21()
		{
			Dictionary<Class14, int> dictionary = new Dictionary<Class14, int>();
			using (Class26 class26_ = this.class25_0.Class26_0)
			{
				foreach (Class14 @class in class26_.Values)
				{
					if (@class != null && @class.Int32_0 > 0 && !@class.Boolean_3)
					{
						dictionary.Add(@class, @class.Int32_0);
					}
				}
			}
			return dictionary;
		}
		internal Dictionary<Class14, int> method_22()
		{
			Dictionary<Class14, int> dictionary = new Dictionary<Class14, int>();
			using (Class26 class26_ = this.class25_0.Class26_0)
			{
				foreach (Class14 @class in class26_.Values)
				{
					if (@class != null)
					{
						dictionary.Add(@class, @class.Int32_0);
					}
				}
			}
			return dictionary;
		}
	}
}
