using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ns0
{
	internal sealed class Class37
	{
		private Task task_0;
		private Class16[] class16_0;
		private Hashtable hashtable_0;
		private Hashtable hashtable_1;
		private Timer timer_0;
		private List<GClass1> list_0;
		public int Int32_0
		{
			get
			{
				int result;
				if (this.class16_0 == null)
				{
					result = 0;
				}
				else
				{
					int num = 0;
					for (int i = 0; i < this.class16_0.Length; i++)
					{
						if (this.class16_0[i] != null && this.class16_0[i].method_2() != null && !string.IsNullOrEmpty(this.class16_0[i].method_2().string_0))
						{
							num++;
						}
					}
					num++;
					result = num;
				}
				return result;
			}
		}
		public Class37(int int_0)
		{
			this.hashtable_0 = new Hashtable();
			this.hashtable_1 = new Hashtable();
			this.class16_0 = new Class16[int_0];
			this.list_0 = new List<GClass1>();
			this.timer_0 = new Timer(new TimerCallback(this.method_4), null, 500, 500);
		}
		public void method_0(uint uint_0, string string_0, Class16 class16_1)
		{
			this.hashtable_0[uint_0] = class16_1;
			this.hashtable_1[string_0.ToLower()] = class16_1;
		}
		public void method_1(uint uint_0, string string_0)
		{
			this.hashtable_0[uint_0] = null;
			this.hashtable_1[string_0.ToLower()] = null;
		}
		public Class16 method_2(uint uint_0)
		{
			Class16 result;
			if (this.class16_0 == null || this.hashtable_0 == null)
			{
				result = null;
			}
			else
			{
				if (this.hashtable_0.ContainsKey(uint_0))
				{
					result = (Class16)this.hashtable_0[uint_0];
				}
				else
				{
					result = null;
				}
			}
			return result;
		}
		public Class16 method_3(string string_0)
		{
			Class16 result;
			if (this.class16_0 == null || this.hashtable_1 == null)
			{
				result = null;
			}
			else
			{
				if (this.hashtable_1.ContainsKey(string_0.ToLower()))
				{
					result = (Class16)this.hashtable_1[string_0.ToLower()];
				}
				else
				{
					result = null;
				}
			}
			return result;
		}
		private void method_4(object object_0)
		{
			try
			{
				List<GClass1> list = this.list_0;
				this.list_0 = new List<GClass1>();
				if (list != null)
				{
					foreach (GClass1 current in list)
					{
						if (current != null)
						{
							current.method_1();
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass4.smethod_6(ex.ToString(), "Disconnector task");
			}
		}
		internal void method_5(GClass1 gclass1_0)
		{
			if (!this.list_0.Contains(gclass1_0))
			{
				this.list_0.Add(gclass1_0);
			}
		}
		public void method_6()
		{
		}
		public Class16 method_7(uint uint_0)
		{
			Class16 result;
			try
			{
				result = this.class16_0[(int)((UIntPtr)uint_0)];
			}
			catch
			{
				result = null;
			}
			return result;
		}
		internal void method_8(uint uint_0, ref GClass1 gclass1_0)
		{
			this.class16_0[(int)((UIntPtr)uint_0)] = new Class16(uint_0, ref gclass1_0);
			this.class16_0[(int)((UIntPtr)uint_0)].method_3();
		}
		public void method_9(uint uint_0)
		{
			Class16 @class = this.method_7(uint_0);
			if (@class != null)
			{
				Phoenix.smethod_14().method_6(uint_0);
				@class.method_11();
				this.class16_0[(int)((UIntPtr)uint_0)] = null;
			}
		}
		public void method_10()
		{
			if (this.task_0 == null)
			{
				this.task_0 = new Task(new Action(this.method_12));
				this.task_0.Start();
			}
		}
		public void method_11()
		{
			if (this.task_0 != null)
			{
				this.task_0 = null;
			}
		}
		private void method_12()
		{
			int num = int.Parse(Phoenix.smethod_11().dictionary_0["client.ping.interval"]);
			if (num <= 100)
			{
				throw new ArgumentException("Invalid configuration value for ping interval! Must be above 100 miliseconds.");
			}
			while (true)
			{
				try
				{
					GClass5 gClass = new GClass5(50u);
					List<Class16> list = new List<Class16>();
					List<Class16> list2 = new List<Class16>();
					for (int i = 0; i < this.class16_0.Length; i++)
					{
						Class16 @class = this.class16_0[i];
						if (@class != null)
						{
							if (@class.bool_0)
							{
								@class.bool_0 = false;
								list2.Add(@class);
							}
							else
							{
								list.Add(@class);
							}
						}
					}
					foreach (Class16 @class in list)
					{
						try
						{
							@class.method_12();
						}
						catch
						{
						}
					}
					byte[] byte_ = gClass.method_14();
					foreach (Class16 @class in list2)
					{
						try
						{
							@class.method_0().method_2(byte_);
						}
						catch
						{
						}
					}
				}
				catch (Exception ex)
				{
					GClass4.smethod_6(ex.ToString(), "Connection checker task");
				}
				Thread.Sleep(num);
			}
		}
		internal void method_13()
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null)
				{
					try
					{
						@class.method_14(Class54.smethod_1(@class));
					}
					catch
					{
					}
				}
			}
		}
		internal void method_14(GClass5 gclass5_0)
		{
			byte[] byte_ = gclass5_0.method_14();
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null)
				{
					try
					{
						@class.method_0().method_2(byte_);
					}
					catch
					{
					}
				}
			}
		}
		internal void method_15(GClass5 gclass5_0, GClass5 gclass5_1)
		{
			byte[] byte_ = gclass5_0.method_14();
			byte[] byte_2 = gclass5_1.method_14();
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null)
				{
					try
					{
						if (@class.method_2().Boolean_0)
						{
							@class.method_0().method_2(byte_);
						}
						else
						{
							@class.method_0().method_2(byte_2);
						}
					}
					catch
					{
					}
				}
			}
		}
		internal void method_16(GClass5 gclass5_0, GClass5 gclass5_1)
		{
			byte[] byte_ = gclass5_0.method_14();
			byte[] byte_2 = gclass5_1.method_14();
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null)
				{
					try
					{
						if (@class.method_2().method_3("receive_sa"))
						{
							if (@class.method_2().Boolean_0)
							{
								@class.method_0().method_2(byte_);
							}
							else
							{
								@class.method_0().method_2(byte_2);
							}
						}
					}
					catch
					{
					}
				}
			}
		}
		internal void method_17(Class16 class16_1, GClass5 gclass5_0)
		{
			byte[] byte_ = gclass5_0.method_14();
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && @class != class16_1)
				{
					try
					{
						if (@class.method_2().method_3("receive_sa"))
						{
							@class.method_0().method_2(byte_);
						}
					}
					catch
					{
					}
				}
			}
		}
		internal void method_18(int int_0)
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && @class.method_2() != null)
				{
					try
					{
						@class.method_2().int_2 += int_0;
						@class.method_2().method_13(true);
						@class.method_8("You just received " + int_0 + " credits from staff!");
					}
					catch
					{
					}
				}
			}
		}
		internal void method_19(int int_0, bool bool_0)
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && @class.method_2() != null)
				{
					try
					{
						@class.method_2().int_3 += int_0;
						@class.method_2().method_15(bool_0);
						@class.method_8("You just received " + int_0 + " pixels from staff!");
					}
					catch
					{
					}
				}
			}
		}
		internal void method_20(int int_0, bool bool_0)
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && @class.method_2() != null)
				{
					try
					{
						@class.method_2().int_12 += int_0;
						@class.method_2().method_14(false, bool_0);
						@class.method_8("You just received " + int_0 + " points from staff!");
					}
					catch
					{
					}
				}
			}
		}
		internal void method_21(string string_0)
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && @class.method_2() != null)
				{
					try
					{
						@class.method_2().method_22().method_2(@class, string_0, true);
						@class.method_8("You just received a badge from hotel staff!");
					}
					catch
					{
					}
				}
			}
		}
		public void method_22(GClass5 gclass5_0, string string_0)
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null)
				{
					try
					{
						if (string_0.Length <= 0 || (@class.method_2() != null && @class.method_2().method_3(string_0)))
						{
							@class.method_14(gclass5_0);
						}
					}
					catch
					{
					}
				}
			}
		}
		public void method_23()
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && (@class.method_2() != null && @class.method_2().method_24() != null))
				{
					@class.method_2().method_24().method_7();
				}
			}
		}
		internal void method_24()
		{
			StringBuilder stringBuilder = new StringBuilder();
			bool flag = false;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				for (int i = 0; i < this.class16_0.Length; i++)
				{
					Class16 class2 = this.class16_0[i];
					if (class2 != null && class2.method_2() != null)
					{
						try
						{
							class2.method_2().method_23().method_19(@class, true);
							stringBuilder.Append(class2.method_2().String_0);
							flag = true;
						}
						catch
						{
						}
					}
				}
				if (flag)
				{
					try
					{
						@class.method_1(stringBuilder.ToString());
					}
					catch (Exception ex)
					{
						GClass4.smethod_8(ex.ToString());
					}
				}
			}
			Console.WriteLine("  " + "Done saving users inventory!");
			Console.WriteLine("  " + "Closing server connections...");
			try
			{
				for (int i = 0; i < this.class16_0.Length; i++)
				{
					Class16 class2 = this.class16_0[i];
					if (class2 != null && class2.method_0() != null)
					{
						try
						{
							class2.method_0().Dispose();
						}
						catch
						{
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass4.smethod_8(ex.ToString());
			}
			Array.Clear(this.class16_0, 0, this.class16_0.Length);
			Console.WriteLine("  " + "Connections closed!");
		}
		public void method_25(uint uint_0)
		{
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && @class.method_2() != null && @class.method_2().uint_0 == uint_0)
				{
					@class.method_12();
				}
			}
		}
		public string method_26(uint uint_0)
		{
			Class16 @class = this.method_2(uint_0);
			string result;
			if (@class != null)
			{
				result = @class.method_2().string_0;
			}
			else
			{
				DataRow dataRow = null;
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					dataRow = class2.method_4("SELECT username FROM users WHERE id = '" + uint_0 + "' LIMIT 1");
				}
				if (dataRow == null)
				{
					result = "Unknown User";
				}
				else
				{
					result = (string)dataRow[0];
				}
			}
			return result;
		}
		public uint method_27(string string_0)
		{
			Class16 @class = this.method_3(string_0);
			uint result;
			if (@class != null)
			{
				result = @class.method_2().uint_0;
			}
			else
			{
				DataRow dataRow = null;
				using (Class6 class2 = Phoenix.smethod_12().method_0())
				{
					dataRow = class2.method_4("SELECT id FROM users WHERE username = '" + string_0 + "' LIMIT 1");
				}
				if (dataRow == null)
				{
					result = 0u;
				}
				else
				{
					result = (uint)dataRow[0];
				}
			}
			return result;
		}
		public void method_28()
		{
			Dictionary<Class16, GException1> dictionary = new Dictionary<Class16, GException1>();
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null)
				{
					try
					{
						Phoenix.smethod_15().method_3().method_1(@class);
					}
					catch (GException1 value)
					{
						dictionary.Add(@class, value);
					}
				}
			}
			foreach (KeyValuePair<Class16, GException1> current in dictionary)
			{
				current.Key.method_7(current.Value.Message);
				current.Key.method_12();
			}
		}
		public void method_29()
		{
			try
			{
				if (this.class16_0 != null)
				{
					if (Phoenix.string_5 == "127.0.0.1")
					{
						Class13.bool_15 = true;
					}
					for (int i = 0; i < this.class16_0.Length; i++)
					{
						Class16 @class = this.class16_0[i];
						if (@class != null && (@class.method_2() != null && Phoenix.smethod_15().method_11().method_2(@class)))
						{
							Phoenix.smethod_15().method_11().method_3(@class);
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass4.smethod_6(ex.ToString(), "GCMExt.CheckPixelUpdates task");
			}
		}
		internal List<GClass5> method_30()
		{
			List<GClass5> list = new List<GClass5>();
			int num = 0;
			GClass5 gClass = new GClass5();
			gClass.method_2(161u);
			gClass.method_7("Users online:\r");
			for (int i = 0; i < this.class16_0.Length; i++)
			{
				Class16 @class = this.class16_0[i];
				if (@class != null && @class.method_2() != null)
				{
					if (num > 20)
					{
						list.Add(gClass);
						num = 0;
						gClass = new GClass5();
						gClass.method_2(161u);
					}
					num++;
					gClass.method_7(string.Concat(new object[]
					{
						@class.method_2().string_0,
						" {",
						@class.method_2().uint_1,
						"}\r"
					}));
				}
			}
			list.Add(gClass);
			return list;
		}
		internal void method_31(Class16 class16_1, string string_0, string string_1)
		{
			if (Class13.Boolean_5 && !class16_1.method_2().bool_0)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_0("extra_data", string_1);
					@class.method_1(string.Concat(new object[]
					{
						"INSERT INTO cmdlogs (user_id,user_name,command,extra_data,timestamp) VALUES ('",
						class16_1.method_2().uint_0,
						"','",
						class16_1.method_2().string_0,
						"','",
						string_0,
						"', @extra_data, UNIX_TIMESTAMP())"
					}));
				}
			}
		}
	}
}
