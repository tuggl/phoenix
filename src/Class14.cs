using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
namespace ns0
{
	internal sealed class Class14
	{
		public delegate void Delegate2(int Team);
		private uint uint_0;
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
		public bool bool_3;
		public int int_5;
		public int int_6;
		internal bool bool_4;
		internal bool bool_5;
		private Timer timer_0;
		private bool bool_6;
		private bool bool_7;
		internal Class33[] class33_0;
		public int int_7 = 0;
		private int int_8;
		public Class29 class29_0;
		public List<uint> list_1;
		internal bool bool_8;
		private Dictionary<uint, double> dictionary_0;
		public Class21 class21_0;
		public string string_7;
		public string string_8;
		public string string_9;
		private Hashtable hashtable_0;
		private Hashtable hashtable_1;
		private Hashtable hashtable_2;
		private Hashtable hashtable_3;
		private Hashtable hashtable_4;
		public Class67 class67_0;
		public List<Class64> list_2;
		public bool bool_9;
		public List<Class63> list_3;
		public List<uint> list_4;
		public List<Class63> list_5;
		public List<Class63> list_6;
		public List<Class63> list_7;
		public List<Class63> list_8;
		public List<Class63> list_9;
		public List<Class63> list_10;
		public List<Class63> list_11;
		public List<Class63> list_12;
		public List<Class63> list_13;
		public int int_9;
		public int int_10;
		public int int_11;
		public int int_12;
		public int int_13;
		private bool bool_10;
		public List<Class63> list_14;
		public List<Class63> list_15;
		public List<Class63> list_16;
		public List<Class5> list_17;
		public double[,] double_0;
		private byte[,] byte_0;
		public GStruct1[,] gstruct1_0;
		private byte[,] byte_1;
		private byte[,] byte_2;
		private double[,] double_1;
		private double[,] double_2;
		private Class28 class28_0;
		private bool bool_11;
		private int int_14;
		private int int_15;
		private Class27 class27_0;
		private int int_16;
		private bool bool_12;
		public bool Boolean_0
		{
			get
			{
				return this.class21_0 != null;
			}
		}
		public Class29 Class29_0
		{
			get
			{
				return this.class29_0;
			}
			set
			{
				this.class29_0 = value;
			}
		}
		internal bool Boolean_1
		{
			get
			{
				return this.bool_11;
			}
			set
			{
				this.bool_11 = value;
			}
		}
		public int Int32_0
		{
			get
			{
				int num = 0;
				int result;
				if (this.class33_0 == null)
				{
					result = 0;
				}
				else
				{
					for (int i = 0; i < this.class33_0.Length; i++)
					{
						if (this.class33_0[i] != null && !this.class33_0[i].Boolean_4 && !this.class33_0[i].Boolean_0)
						{
							num++;
						}
					}
					result = num;
				}
				return result;
			}
		}
		public int Int32_1
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
		public uint UInt32_0
		{
			get
			{
				return this.uint_0;
			}
		}
		public Hashtable Hashtable_0
		{
			get
			{
				Hashtable result;
				if (this.hashtable_0 != null)
				{
					result = (this.hashtable_0.Clone() as Hashtable);
				}
				else
				{
					result = null;
				}
				return result;
			}
		}
		public Hashtable Hashtable_1
		{
			get
			{
				return this.hashtable_4.Clone() as Hashtable;
			}
		}
		public bool Boolean_2
		{
			get
			{
				bool result;
				if (this.Boolean_3)
				{
					result = false;
				}
				else
				{
					Class30 @class = Phoenix.smethod_15().method_7().method_2(this.int_0);
					result = (@class != null && @class.bool_0);
				}
				return result;
			}
		}
		public bool Boolean_3
		{
			get
			{
				return this.string_2 == "public";
			}
		}
		public int Int32_2
		{
			get
			{
				int num = 0;
				for (int i = 0; i < this.class33_0.Length; i++)
				{
					Class33 @class = this.class33_0[i];
					if (@class != null && @class.Boolean_0)
					{
						num++;
					}
				}
				return num;
			}
		}
		internal Class27 Class27_0
		{
			get
			{
				this.class27_0.method_2(this);
				return this.class27_0;
			}
		}
		public byte[,] Byte_0
		{
			get
			{
				return this.byte_0;
			}
		}
		internal bool Boolean_4
		{
			get
			{
				return this.method_2().Count > 0;
			}
		}
		public Class14(uint uint_2, string string_10, string string_11, string string_12, string string_13, int int_17, int int_18, int int_19, string string_14, string string_15, int int_20, List<string> list_18, bool bool_13, bool bool_14, bool bool_15, bool bool_16, Class29 class29_1, string string_16, string string_17, string string_18, string string_19, Class27 class27_1, bool bool_17, int int_21, int int_22, uint uint_3)
		{
			if (!(Class13.String_0 == ""))
			{
				this.bool_12 = false;
				this.uint_0 = uint_2;
				this.string_0 = string_10;
				this.string_1 = string_11;
				this.string_3 = string_13;
				this.int_0 = int_17;
				this.string_2 = string_12;
				this.int_1 = int_18;
				this.int_2 = 0;
				this.int_3 = int_19;
				this.string_5 = string_14;
				this.string_6 = string_15;
				this.int_4 = int_20;
				this.list_0 = list_18;
				this.bool_0 = bool_13;
				this.bool_1 = bool_14;
				this.bool_2 = bool_15;
				this.bool_3 = bool_16;
				this.int_5 = int_21;
				this.int_6 = int_22;
				this.int_7 = 0;
				this.class33_0 = new Class33[500];
				this.class29_0 = class29_1;
				this.string_4 = string_16;
				this.dictionary_0 = new Dictionary<uint, double>();
				this.class21_0 = null;
				this.string_7 = string_17;
				this.string_8 = string_18;
				this.string_9 = string_19;
				this.hashtable_4 = new Hashtable();
				this.hashtable_0 = new Hashtable();
				this.list_2 = new List<Class64>();
				this.class28_0 = Phoenix.smethod_15().method_9().method_10(this.string_5, this.uint_0);
				this.bool_6 = false;
				this.bool_7 = false;
				this.bool_5 = true;
				this.class27_0 = class27_1;
				this.bool_8 = bool_17;
				this.list_17 = new List<Class5>();
				this.list_4 = new List<uint>();
				this.list_5 = new List<Class63>();
				this.list_9 = new List<Class63>();
				this.list_7 = new List<Class63>();
				this.list_6 = new List<Class63>();
				this.list_8 = new List<Class63>();
				this.list_10 = new List<Class63>();
				this.list_11 = new List<Class63>();
				this.list_12 = new List<Class63>();
				this.list_13 = new List<Class63>();
				this.int_10 = 0;
				this.int_11 = 0;
				this.int_9 = 0;
				this.int_12 = 0;
				this.int_13 = 0;
				this.list_3 = new List<Class63>();
				this.list_14 = new List<Class63>();
				this.list_15 = new List<Class63>();
				this.list_16 = new List<Class63>();
				this.byte_0 = new byte[this.Class28_0.int_4, this.Class28_0.int_5];
				this.double_1 = new double[this.Class28_0.int_4, this.Class28_0.int_5];
				this.double_2 = new double[this.Class28_0.int_4, this.Class28_0.int_5];
				this.timer_0 = new Timer(new TimerCallback(this.method_32), null, 480, 480);
				this.int_8 = 0;
				this.bool_4 = false;
				this.bool_9 = true;
				this.bool_11 = false;
				this.int_16 = 0;
				this.int_15 = 4;
				this.uint_1 = uint_3;
				this.bool_10 = false;
				this.hashtable_1 = new Hashtable();
				this.hashtable_2 = new Hashtable();
				this.hashtable_3 = new Hashtable();
				this.method_23();
				this.method_25();
				this.method_22();
			}
		}
		public void method_0()
		{
			List<Class34> list = Phoenix.smethod_15().method_14().method_2(this.UInt32_0);
			foreach (Class34 current in list)
			{
				this.method_3(current);
			}
		}
		public void method_1()
		{
			new List<Class15>();
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_0("roomid", this.UInt32_0);
				DataTable dataTable = @class.method_3("SELECT id, user_id, room_id, name, type, race, color, expirience, energy, nutrition, respect, createstamp, x, y, z FROM user_pets WHERE room_id = @roomid;");
				if (dataTable != null)
				{
					foreach (DataRow dataRow_ in dataTable.Rows)
					{
						Class15 class2 = Phoenix.smethod_15().method_6().method_12(dataRow_);
						List<Class36> list = new List<Class36>();
						List<Class35> list2 = new List<Class35>();
						this.method_4(new Class34(class2.uint_0, this.UInt32_0, Enum2.const_0, "freeroam", class2.string_0, "", class2.String_0, class2.int_4, class2.int_5, (int)class2.double_0, 0, 0, 0, 0, 0, ref list, ref list2, 0), class2);
					}
				}
			}
		}
		internal List<Class15> method_2()
		{
			List<Class15> list = new List<Class15>();
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				if (this.class33_0[i] != null && this.class33_0[i].Boolean_0)
				{
					list.Add(this.class33_0[i].class15_0);
				}
			}
			return list;
		}
		public Class33 method_3(Class34 class34_0)
		{
			return this.method_4(class34_0, null);
		}
		public Class33 method_4(Class34 class34_0, Class15 class15_0)
		{
			int num = this.method_5();
			Class33 @class = new Class33(Convert.ToUInt32(num + 100000), this.UInt32_0, this.int_7++, true);
			@class.int_20 = num;
			this.class33_0[num] = @class;
			if (class34_0.int_1 > 0 && class34_0.int_2 > 0 && class34_0.int_1 < this.Class28_0.int_4 && class34_0.int_2 < this.Class28_0.int_5)
			{
				@class.method_7(class34_0.int_1, class34_0.int_2, class34_0.double_0);
				@class.method_9(class34_0.int_3);
			}
			else
			{
				class34_0.int_1 = this.Class28_0.int_0;
				class34_0.int_2 = this.Class28_0.int_1;
				@class.method_7(this.Class28_0.int_0, this.Class28_0.int_1, this.Class28_0.double_0);
				@class.method_9(this.Class28_0.int_2);
			}
			@class.class34_0 = class34_0;
			@class.class99_0 = class34_0.method_4(@class.int_0);
			if (@class.Boolean_0)
			{
				@class.class99_0.method_0((int)class34_0.uint_0, @class.int_0, this.UInt32_0);
				@class.class15_0 = class15_0;
				@class.class15_0.int_0 = @class.int_0;
			}
			else
			{
				@class.class99_0.method_0(-1, @class.int_0, this.UInt32_0);
			}
			this.method_87(@class, true, true);
			@class.bool_7 = true;
			GClass5 gClass = new GClass5(28u);
			gClass.method_9(1);
			@class.method_14(gClass);
			this.method_59(gClass, null);
			@class.class99_0.vmethod_0();
			return @class;
		}
		private int method_5()
		{
			return Array.IndexOf<Class33>(this.class33_0, null);
		}
		public void method_6(int int_17, bool bool_13)
		{
			Class33 @class = this.method_52(int_17);
			if (@class != null && @class.Boolean_4)
			{
				@class.class99_0.vmethod_1(bool_13);
				GClass5 gClass = new GClass5(29u);
				gClass.method_10(@class.int_0);
				this.method_59(gClass, null);
				uint num = @class.uint_0;
				for (int i = 0; i < this.class33_0.Length; i++)
				{
					Class33 class2 = this.class33_0[i];
					if (class2 != null && class2.uint_0 == num)
					{
						this.class33_0[i] = null;
					}
				}
			}
		}
		public void method_7(Class33 class33_1, string string_10, bool bool_13)
		{
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && @class.Boolean_4)
				{
					if (bool_13)
					{
						@class.class99_0.vmethod_5(class33_1, string_10);
					}
					else
					{
						@class.class99_0.vmethod_4(class33_1, string_10);
					}
				}
			}
		}
		public void method_8(Class33 class33_1)
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_enterroom")
					{
						this.method_21(class33_1, current, "");
					}
				}
			}
			catch
			{
			}
		}
		public bool method_9(Class33 class33_1, string string_10)
		{
			bool result = false;
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_onsay" && this.method_21(class33_1, current, string_10.ToLower()))
					{
						result = true;
					}
				}
			}
			catch
			{
			}
			return result;
		}
		public void method_10(Class33 class33_1, Class63 class63_0)
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_furnistate")
					{
						this.method_21(class33_1, current, Convert.ToString(class63_0.uint_0));
					}
				}
			}
			catch
			{
			}
		}
		public void method_11(Class33 class33_1, Class63 class63_0)
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_onfurni")
					{
						this.method_21(class33_1, current, Convert.ToString(class63_0.uint_0));
					}
				}
			}
			catch
			{
			}
		}
		public void method_12(Class33 class33_1, Class63 class63_0)
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_offfurni")
					{
						this.method_21(class33_1, current, Convert.ToString(class63_0.uint_0));
					}
				}
			}
			catch
			{
			}
		}
		public void method_13()
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_gameend")
					{
						this.method_21(null, current, "GameEnded");
					}
				}
			}
			catch
			{
			}
		}
		public void method_14(Class33 class33_1)
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_gamestart")
					{
						this.method_21(class33_1, current, "GameBegun");
					}
				}
			}
			catch
			{
			}
		}
		public void method_15(Class63 class63_0)
		{
			this.method_21(null, class63_0, "Timer");
		}
		public void method_16(double double_3)
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_attime" && current.string_2.Length > 0 && Convert.ToDouble(current.string_2) == double_3)
					{
						this.method_21(null, current, "AtTime");
					}
				}
			}
			catch
			{
			}
		}
		public void method_17(int int_17)
		{
			try
			{
				foreach (Class63 current in this.list_14)
				{
					if (current.method_7().string_2.ToLower() == "wf_trg_atscore" && current.string_2 != "" && Convert.ToDouble(current.string_2) == (double)int_17)
					{
						this.method_21(null, current, "TheScore");
					}
				}
			}
			catch
			{
			}
		}
		public bool method_18(Class33 class33_1, string string_10, string string_11)
		{
			string_11 = this.method_20(class33_1, string_11);
			bool result;
			if (string_10 != null)
			{
				if (Class23.dictionary_4 == null)
				{
					Class23.dictionary_4 = new Dictionary<string, int>(39)
					{

						{
							"roomuserseq",
							0
						},

						{
							"roomuserslt",
							1
						},

						{
							"roomusersmt",
							2
						},

						{
							"roomusersmte",
							3
						},

						{
							"roomuserslte",
							4
						},

						{
							"userhasachievement",
							5
						},

						{
							"userhasntachievement",
							6
						},

						{
							"userhasbadge",
							7
						},

						{
							"userhasntbadge",
							8
						},

						{
							"userhasvip",
							9
						},

						{
							"userhasntvip",
							10
						},

						{
							"userhaseffect",
							11
						},

						{
							"userhasnteffect",
							12
						},

						{
							"userrankeq",
							13
						},

						{
							"userrankmt",
							14
						},

						{
							"userrankmte",
							15
						},

						{
							"userranklt",
							16
						},

						{
							"userranklte",
							17
						},

						{
							"usercreditseq",
							18
						},

						{
							"usercreditsmt",
							19
						},

						{
							"usercreditsmte",
							20
						},

						{
							"usercreditslt",
							21
						},

						{
							"usercreditslte",
							22
						},

						{
							"userpixelseq",
							23
						},

						{
							"userpixelsmt",
							24
						},

						{
							"userpixelsmte",
							25
						},

						{
							"userpixelslt",
							26
						},

						{
							"userpixelslte",
							27
						},

						{
							"userpointseq",
							28
						},

						{
							"userpointsmt",
							29
						},

						{
							"userpointsmte",
							30
						},

						{
							"userpointslt",
							31
						},

						{
							"userpointslte",
							32
						},

						{
							"usergroupeq",
							33
						},

						{
							"userisingroup",
							34
						},

						{
							"wearing",
							35
						},

						{
							"notwearing",
							36
						},

						{
							"carrying",
							37
						},

						{
							"notcarrying",
							38
						}
					};
				}
				int num;
				if (Class23.dictionary_4.TryGetValue(string_10, out num))
				{
					switch (num)
					{
					case 0:
						if (this.Int32_0 == Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 1:
						if (this.Int32_0 < Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 2:
						if (this.Int32_0 > Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 3:
						if (this.Int32_0 >= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 4:
						if (this.Int32_0 <= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 5:
						result = Phoenix.smethod_15().method_12().method_1(class33_1.method_16(), (uint)Convert.ToUInt16(string_11), 1);
						return result;
					case 6:
						if (!Phoenix.smethod_15().method_12().method_1(class33_1.method_16(), (uint)Convert.ToUInt16(string_11), 1))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 7:
						result = class33_1.method_16().method_2().method_22().method_1(string_11);
						return result;
					case 8:
						if (!class33_1.method_16().method_2().method_22().method_1(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 9:
						result = class33_1.method_16().method_2().bool_14;
						return result;
					case 10:
						if (!class33_1.method_16().method_2().bool_14)
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 11:
						if (class33_1.method_16().method_2().method_24().int_0 == Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 12:
						if (class33_1.method_16().method_2().method_24().int_0 != Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 13:
						if ((ulong)class33_1.method_16().method_2().uint_1 == (ulong)((long)Convert.ToInt32(string_11)))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 14:
						if ((ulong)class33_1.method_16().method_2().uint_1 > (ulong)((long)Convert.ToInt32(string_11)))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 15:
						if ((ulong)class33_1.method_16().method_2().uint_1 >= (ulong)((long)Convert.ToInt32(string_11)))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 16:
						if ((ulong)class33_1.method_16().method_2().uint_1 < (ulong)((long)Convert.ToInt32(string_11)))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 17:
						if ((ulong)class33_1.method_16().method_2().uint_1 <= (ulong)((long)Convert.ToInt32(string_11)))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 18:
						if (class33_1.method_16().method_2().int_2 == Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 19:
						if (class33_1.method_16().method_2().int_2 > Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 20:
						if (class33_1.method_16().method_2().int_2 >= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 21:
						if (class33_1.method_16().method_2().int_2 < Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 22:
						if (class33_1.method_16().method_2().int_2 <= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 23:
						if (class33_1.method_16().method_2().int_3 == Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 24:
						if (class33_1.method_16().method_2().int_3 > Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 25:
						if (class33_1.method_16().method_2().int_3 >= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 26:
						if (class33_1.method_16().method_2().int_3 < Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 27:
						if (class33_1.method_16().method_2().int_3 <= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 28:
						if (class33_1.method_16().method_2().int_12 == Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 29:
						if (class33_1.method_16().method_2().int_12 > Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 30:
						if (class33_1.method_16().method_2().int_12 >= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 31:
						if (class33_1.method_16().method_2().int_12 < Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 32:
						if (class33_1.method_16().method_2().int_12 <= Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 33:
						if (class33_1.method_16().method_2().int_0 == Convert.ToInt32(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 34:
					{
						IEnumerator enumerator = class33_1.method_16().method_2().dataTable_0.Rows.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								if ((int)dataRow["groupid"] == Convert.ToInt32(string_11))
								{
									result = true;
									return result;
								}
							}
							goto IL_89E;
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
					case 35:
						break;
					case 36:
						if (!class33_1.method_16().method_2().string_5.Contains(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 37:
						if (this.method_53(class33_1.method_16().method_2().uint_0).int_5 == (int)Convert.ToInt16(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					case 38:
						if (this.method_53(class33_1.method_16().method_2().uint_0).int_5 != (int)Convert.ToInt16(string_11))
						{
							result = true;
							return result;
						}
						goto IL_89E;
					default:
						goto IL_89E;
					}
					if (class33_1.method_16().method_2().string_5.Contains(string_11))
					{
						result = true;
						return result;
					}
				}
			}
			IL_89E:
			result = false;
			return result;
		}
		public void method_19(Class33 class33_1, string string_10, string string_11)
		{
			string_11 = this.method_20(class33_1, string_11);
			if (string_10 != null)
			{
				if (Class23.dictionary_5 == null)
				{
					Class23.dictionary_5 = new Dictionary<string, int>(13)
					{

						{
							"sql",
							0
						},

						{
							"badge",
							1
						},

						{
							"effect",
							2
						},

						{
							"award",
							3
						},

						{
							"dance",
							4
						},

						{
							"send",
							5
						},

						{
							"credits",
							6
						},

						{
							"pixels",
							7
						},

						{
							"points",
							8
						},

						{
							"rank",
							9
						},

						{
							"respect",
							10
						},

						{
							"handitem",
							11
						},

						{
							"alert",
							12
						}
					};
				}
				int num;
				if (Class23.dictionary_5.TryGetValue(string_10, out num))
				{
					switch (num)
					{
					case 0:
						using (Class6 @class = Phoenix.smethod_12().method_0())
						{
							@class.method_1(string_11);
							return;
						}
					case 1:
						break;
					case 2:
						if (class33_1.method_16() != null)
						{
							class33_1.method_16().method_2().method_24().method_0(Convert.ToInt32(string_11), 3600);
							class33_1.method_16().method_2().method_24().method_3(Convert.ToInt32(string_11));
							return;
						}
						return;
					case 3:
						if (class33_1.method_16() != null)
						{
							Phoenix.smethod_15().method_12().method_2(class33_1.method_16(), Convert.ToUInt32(string_11));
							return;
						}
						return;
					case 4:
						if (class33_1.method_16() != null)
						{
							Class33 class2 = this.method_53(class33_1.method_16().method_2().uint_0);
							class2.int_15 = Convert.ToInt32(string_11);
							GClass5 gClass = new GClass5(480u);
							gClass.method_9(class2.int_0);
							gClass.method_9(Convert.ToInt32(string_11));
							this.method_59(gClass, null);
							return;
						}
						return;
					case 5:
					{
						if (class33_1.method_16() == null)
						{
							return;
						}
						uint num2 = Convert.ToUInt32(string_11);
						Class14 class3;
						if (Phoenix.smethod_15().method_9().method_13(num2) || Phoenix.smethod_15().method_9().method_14(num2))
						{
							class3 = Phoenix.smethod_15().method_9().method_19(num2);
						}
						else
						{
							class3 = Phoenix.smethod_15().method_9().method_15(num2);
						}
						if (class33_1 == null)
						{
							return;
						}
						if (class3 == null)
						{
							this.method_47(class33_1.method_16(), true, false);
							return;
						}
						GClass5 gClass2 = new GClass5(286u);
						gClass2.method_13(class3.Boolean_3);
						gClass2.method_11(Convert.ToUInt32(string_11));
						class33_1.method_16().method_14(gClass2);
						return;
					}
					case 6:
						if (class33_1.method_16() != null)
						{
							class33_1.method_16().method_2().int_2 = class33_1.method_16().method_2().int_2 + Convert.ToInt32(string_11);
							class33_1.method_16().method_2().method_13(true);
							return;
						}
						return;
					case 7:
						if (class33_1.method_16() != null)
						{
							class33_1.method_16().method_2().int_3 = class33_1.method_16().method_2().int_3 + Convert.ToInt32(string_11);
							class33_1.method_16().method_2().method_15(true);
							return;
						}
						return;
					case 8:
						if (class33_1.method_16() != null)
						{
							class33_1.method_16().method_2().int_12 = class33_1.method_16().method_2().int_12 + Convert.ToInt32(string_11);
							class33_1.method_16().method_2().method_14(false, true);
							return;
						}
						return;
					case 9:
						if (class33_1.method_16() != null && (int)Convert.ToUInt16(string_11) < Phoenix.smethod_15().method_4().method_9())
						{
							using (Class6 @class = Phoenix.smethod_12().method_0())
							{
								@class.method_1(string.Concat(new object[]
								{
									"UPDATE users SET rank = '",
									Convert.ToUInt16(string_11),
									"' WHERE id = ",
									class33_1.method_16().method_2().uint_0,
									" LIMIT 1;"
								}));
							}
							class33_1.method_16().method_12();
							return;
						}
						return;
					case 10:
					{
						if (class33_1.method_16() == null)
						{
							return;
						}
						class33_1.method_16().method_2().int_17++;
						using (Class6 @class = Phoenix.smethod_12().method_0())
						{
							@class.method_1("UPDATE user_stats SET Respect = respect + 1 WHERE id = '" + class33_1.method_16().method_2().uint_0 + "' LIMIT 1");
						}
						GClass5 gClass3 = new GClass5(440u);
						gClass3.method_11(class33_1.method_16().method_2().uint_0);
						gClass3.method_9(class33_1.method_16().method_2().int_17);
						this.method_59(gClass3, null);
						int int_ = class33_1.method_16().method_2().int_17;
						if (int_ <= 166)
						{
							if (int_ <= 6)
							{
								if (int_ == 1)
								{
									Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 1);
									return;
								}
								if (int_ != 6)
								{
									return;
								}
								Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 2);
								return;
							}
							else
							{
								if (int_ == 16)
								{
									Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 3);
									return;
								}
								if (int_ == 66)
								{
									Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 4);
									return;
								}
								if (int_ != 166)
								{
									return;
								}
								Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 5);
								return;
							}
						}
						else
						{
							if (int_ <= 566)
							{
								if (int_ == 366)
								{
									Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 6);
									return;
								}
								if (int_ != 566)
								{
									return;
								}
								Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 7);
								return;
							}
							else
							{
								if (int_ == 766)
								{
									Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 8);
									return;
								}
								if (int_ == 966)
								{
									Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 9);
									return;
								}
								if (int_ != 1116)
								{
									return;
								}
								Phoenix.smethod_15().method_12().method_3(class33_1.method_16(), 14u, 10);
								return;
							}
						}
					}
					case 11:
						if (class33_1.method_16() != null)
						{
							this.method_53(class33_1.method_16().method_2().uint_0).method_8((int)Convert.ToInt16(string_11));
							return;
						}
						return;
					case 12:
						if (class33_1.method_16() != null)
						{
							class33_1.method_16().method_8(string_11);
							return;
						}
						return;
					default:
						return;
					}
					if (class33_1.method_16() != null)
					{
						class33_1.method_16().method_2().method_22().method_2(class33_1.method_16(), Phoenix.smethod_7(string_11), true);
						class33_1.method_16().method_14(class33_1.method_16().method_2().method_22().method_7());
					}
				}
			}
		}
		public string method_20(Class33 class33_1, string string_10)
		{
			if (class33_1 != null)
			{
				if (string_10.ToUpper().Contains("#USERNAME#"))
				{
					string_10 = Regex.Replace(string_10, "#USERNAME#", class33_1.method_16().method_2().string_0, RegexOptions.IgnoreCase);
				}
				if (string_10.ToUpper().Contains("#USERID#"))
				{
					string_10 = Regex.Replace(string_10, "#USERID#", class33_1.method_16().method_2().uint_0.ToString(), RegexOptions.IgnoreCase);
				}
				if (string_10.ToUpper().Contains("#USERRANK#"))
				{
					string_10 = Regex.Replace(string_10, "#USERRANK#", class33_1.method_16().method_2().uint_1.ToString(), RegexOptions.IgnoreCase);
				}
			}
			if (string_10.ToUpper().Contains("#ROOMNAME#"))
			{
				string_10 = Regex.Replace(string_10, "#ROOMNAME#", this.string_0, RegexOptions.IgnoreCase);
			}
			if (string_10.ToUpper().Contains("#ROOMID#"))
			{
				string_10 = Regex.Replace(string_10, "#ROOMID#", this.uint_0.ToString(), RegexOptions.IgnoreCase);
			}
			int num = Phoenix.smethod_15().method_2().Int32_0 + -1;
			int int32_ = Phoenix.smethod_15().method_9().Int32_0;
			if (string_10.ToUpper().Contains("#ONLINECOUNT#"))
			{
				string_10 = Regex.Replace(string_10, "#ONLINECOUNT#", num.ToString(), RegexOptions.IgnoreCase);
			}
			if (string_10.ToUpper().Contains("#ROOMSLOADED#"))
			{
				string_10 = Regex.Replace(string_10, "#ROOMSLOADED#", int32_.ToString(), RegexOptions.IgnoreCase);
			}
			return string_10;
		}
		public bool method_21(Class33 class33_1, Class63 class63_0, string string_10)
		{
			bool result;
			try
			{
				if (this.bool_6 || this.bool_7)
				{
					result = false;
				}
				else
				{
					bool flag = false;
					int num = 0;
					int num2 = 0;
					bool flag2 = false;
					string text = class63_0.method_7().string_2.ToLower();
					switch (text)
					{
					case "wf_trg_onsay":
						if (string_10.Contains(class63_0.string_2.ToLower()))
						{
							flag = true;
						}
						break;
					case "wf_trg_enterroom":
						if (class63_0.string_2 == "" || class63_0.string_2 == class33_1.method_16().method_2().string_0)
						{
							flag = true;
						}
						break;
					case "wf_trg_furnistate":
						if (class63_0.string_3.Length > 0)
						{
							string[] collection = class63_0.string_3.Split(new char[]
							{
								','
							});
							List<string> list = new List<string>(collection);
							foreach (string current in list)
							{
								if (current == string_10)
								{
									flag = true;
								}
							}
						}
						break;
					case "wf_trg_onfurni":
						if (class63_0.string_3.Length > 0)
						{
							string[] collection = class63_0.string_3.Split(new char[]
							{
								','
							});
							List<string> list = new List<string>(collection);
							List<string> list2 = list;
							foreach (string current in list)
							{
								if (!(current != string_10))
								{
									Class63 @class = this.method_28(Convert.ToUInt32(string_10));
									if (@class != null)
									{
										flag = true;
									}
									else
									{
										list2.Remove(current);
									}
								}
							}
							class63_0.string_3 = string.Join(",", list2.ToArray());
						}
						break;
					case "wf_trg_offfurni":
						if (class63_0.string_3.Length > 0)
						{
							string[] collection = class63_0.string_3.Split(new char[]
							{
								','
							});
							List<string> list = new List<string>(collection);
							List<string> list2 = list;
							foreach (string current in list)
							{
								if (!(current != string_10))
								{
									Class63 @class = this.method_28(Convert.ToUInt32(string_10));
									if (@class != null)
									{
										flag = true;
									}
									else
									{
										list2.Remove(current);
									}
								}
							}
							class63_0.string_3 = string.Join(",", list2.ToArray());
						}
						break;
					case "wf_trg_gameend":
						if (string_10 == "GameEnded")
						{
							flag = true;
						}
						break;
					case "wf_trg_gamestart":
						if (string_10 == "GameBegun")
						{
							flag = true;
						}
						break;
					case "wf_trg_timer":
						if (string_10 == "Timer")
						{
							flag = true;
						}
						break;
					case "wf_trg_attime":
						if (string_10 == "AtTime")
						{
							flag = true;
						}
						break;
					case "wf_trg_atscore":
						if (string_10 == "TheScore")
						{
							flag = true;
						}
						break;
					}
					try
					{
						List<Class63> list3 = this.method_93(class63_0.Int32_0, class63_0.Int32_1);
						if (list3 == null)
						{
							result = false;
							return result;
						}
						foreach (Class63 current2 in list3)
						{
							text = current2.method_7().string_2.ToLower();
							if (text != null)
							{
								int num4;
								if (!(text == "wf_cnd_phx"))
								{
									if (!(text == "wf_cnd_trggrer_on_frn"))
									{
										string[] collection;
										List<string> list;
										List<Class63> list4;
										if (!(text == "wf_cnd_furnis_hv_avtrs"))
										{
											if (!(text == "wf_cnd_has_furni_on"))
											{
												continue;
											}
											num4 = num2;
											num++;
											current2.string_0 = "1";
											current2.method_5(false, true);
											current2.method_3(1);
											current2.method_10();
											if (current2.string_3.Length <= 0)
											{
												continue;
											}
											collection = current2.string_3.Split(new char[]
											{
												','
											});
											list = new List<string>(collection);
											list4 = new List<Class63>();
											foreach (string current3 in list)
											{
												list4.Add(this.method_28(Convert.ToUInt32(current3)));
											}
											using (List<Class63>.Enumerator enumerator3 = list4.GetEnumerator())
											{
												while (enumerator3.MoveNext())
												{
													Class63 current4 = enumerator3.Current;
													if (current4 != null)
													{
														Dictionary<int, GClass10> dictionary = current4.Dictionary_0;
														if (dictionary == null)
														{
															dictionary = new Dictionary<int, GClass10>();
														}
														List<Class63> list5 = new List<Class63>(this.method_45(current4.Int32_0, current4.Int32_1));
														if (list5.Count > 1 && num4 + 1 != num2)
														{
															num2++;
															break;
														}
														foreach (GClass10 current5 in dictionary.Values)
														{
															list5 = new List<Class63>(this.method_45(current5.Int32_0, current5.Int32_1));
															if (list5.Count > 1 && num4 + 1 != num2)
															{
																num2++;
																break;
															}
														}
													}
												}
												continue;
											}
										}
										num++;
										current2.string_0 = "1";
										current2.method_5(false, true);
										current2.method_3(1);
										current2.method_10();
										if (current2.string_3.Length <= 0)
										{
											continue;
										}
										collection = current2.string_3.Split(new char[]
										{
											','
										});
										list = new List<string>(collection);
										list4 = new List<Class63>();
										foreach (string current3 in list)
										{
											list4.Add(this.method_28(Convert.ToUInt32(current3)));
										}
										bool flag3 = true;
										foreach (Class63 current4 in list4)
										{
											if (current4 != null)
											{
												bool flag4 = false;
												Dictionary<int, GClass10> dictionary = current4.Dictionary_0;
												if (dictionary == null)
												{
													dictionary = new Dictionary<int, GClass10>();
												}
												if (this.method_96(current4.Int32_0, current4.Int32_1))
												{
													flag4 = true;
												}
												foreach (GClass10 current5 in dictionary.Values)
												{
													if (this.method_96(current5.Int32_0, current5.Int32_1))
													{
														flag4 = true;
														break;
													}
												}
												if (!flag4)
												{
													flag3 = false;
												}
											}
										}
										if (flag3)
										{
											num2++;
											continue;
										}
										continue;
									}
									else
									{
										num4 = num2;
										num++;
										current2.string_0 = "1";
										current2.method_5(false, true);
										current2.method_3(1);
										current2.method_10();
										if (current2.string_3.Length <= 0)
										{
											continue;
										}
										string[] collection = current2.string_3.Split(new char[]
										{
											','
										});
										List<string> list = new List<string>(collection);
										List<Class63> list4 = new List<Class63>();
										foreach (string current3 in list)
										{
											list4.Add(this.method_28(Convert.ToUInt32(current3)));
										}
										if (class33_1 == null)
										{
											continue;
										}
										using (List<Class63>.Enumerator enumerator3 = list4.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												Class63 current4 = enumerator3.Current;
												if (current4 != null)
												{
													Dictionary<int, GClass10> dictionary = current4.Dictionary_0;
													if (dictionary == null)
													{
														dictionary = new Dictionary<int, GClass10>();
													}
													if (class33_1.int_3 == current4.Int32_0 && class33_1.int_4 == current4.Int32_1 && num4 + 1 != num2)
													{
														num2++;
														break;
													}
													foreach (GClass10 current5 in dictionary.Values)
													{
														if (class33_1.int_3 == current5.Int32_0 && class33_1.int_4 == current5.Int32_1 && num4 + 1 != num2)
														{
															num2++;
															break;
														}
													}
												}
											}
											continue;
										}
									}
								}
								num4 = num2;
								num++;
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								if (current2.string_2.Length > 0)
								{
									string string_11 = current2.string_2.Split(new char[]
									{
										':'
									})[0].ToLower();
									string string_12 = current2.string_2.Split(new char[]
									{
										':'
									})[1];
									if (class33_1 != null)
									{
										if (!class33_1.Boolean_4 && this.method_18(class33_1, string_11, string_12))
										{
											num2++;
										}
									}
									else
									{
										Class33[] array = this.class33_0;
										for (int i = 0; i < array.Length; i++)
										{
											Class33 class2 = array[i];
											if (class2 != null && !class2.Boolean_4 && this.method_18(class2, string_11, string_12) && num4 + 1 != num2)
											{
												num2++;
												break;
											}
										}
									}
								}
							}
						}
						if (num != num2)
						{
							result = false;
							return result;
						}
					}
					catch
					{
					}
					if (flag && num == num2)
					{
						class63_0.string_0 = "1";
						class63_0.method_5(false, true);
						class63_0.method_3(1);
						List<Class63> list6 = this.method_93(class63_0.Int32_0, class63_0.Int32_1);
						if (list6 == null)
						{
							result = false;
							return result;
						}
						bool flag5 = false;
						foreach (Class63 current2 in list6)
						{
							if (current2.method_7().string_2.ToLower() == "wf_xtra_random")
							{
								flag5 = true;
								break;
							}
						}
						if (flag5)
						{
							List<Class63> list7 = new List<Class63>();
							Random random = new Random();
							while (list6.Count != 0)
							{
								int index = random.Next(0, list6.Count);
								list7.Add(list6[index]);
								list6.RemoveAt(index);
							}
							list6 = list7;
						}
						foreach (Class63 current2 in list6)
						{
							if (flag5 && flag2)
							{
								break;
							}
							text = current2.method_7().string_2.ToLower();
							switch (text)
							{
							case "wf_act_give_phx":
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								if (current2.string_2.Length > 0)
								{
									string string_11 = current2.string_2.Split(new char[]
									{
										':'
									})[0].ToLower();
									string string_12 = current2.string_2.Split(new char[]
									{
										':'
									})[1];
									if (class33_1 != null)
									{
										if (!class33_1.Boolean_4)
										{
											this.method_19(class33_1, string_11, string_12);
										}
									}
									else
									{
										Class33[] array = this.class33_0;
										for (int i = 0; i < array.Length; i++)
										{
											Class33 class2 = array[i];
											if (class2 != null && !class2.Boolean_4)
											{
												this.method_19(class2, string_11, string_12);
											}
										}
									}
									flag2 = true;
								}
								break;
							case "wf_act_saymsg":
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								if (current2.string_2.Length > 0)
								{
									string text2 = current2.string_2;
									text2 = Class58.smethod_4(text2);
									if (text2.Length > 100)
									{
										text2 = text2.Substring(0, 100);
									}
									if (class33_1 != null)
									{
										if (!class33_1.Boolean_4)
										{
											class33_1.method_16().method_2().method_28(text2);
										}
									}
									else
									{
										Class33[] array = this.class33_0;
										for (int i = 0; i < array.Length; i++)
										{
											Class33 class2 = array[i];
											if (class2 != null && !class2.Boolean_4)
											{
												class2.method_16().method_2().method_28(text2);
											}
										}
									}
									flag2 = true;
								}
								break;
							case "wf_act_moveuser":
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								current2.method_10();
								if (current2.string_3.Length > 0)
								{
									string[] collection = current2.string_3.Split(new char[]
									{
										','
									});
									List<string> list = new List<string>(collection);
									Random random2 = new Random();
									int num5 = random2.Next(0, list.Count - 1);
									Class63 class3 = this.method_28(Convert.ToUInt32(list[num5]));
									if (class3 != null)
									{
										if (class33_1 != null)
										{
											this.byte_0[class33_1.int_3, class33_1.int_4] = 1;
											this.byte_0[class33_1.int_12, class33_1.int_13] = 1;
											this.byte_0[class3.Int32_0, class3.Int32_1] = 1;
											class33_1.bool_6 = false;
											class33_1.int_12 = class3.Int32_0;
											class33_1.int_13 = class3.Int32_1;
											class33_1.double_1 = class3.Double_0;
											class33_1.method_7(class3.Int32_0, class3.Int32_1, class3.Double_0);
											class33_1.bool_7 = true;
											if (!current2.dictionary_1.ContainsKey(class33_1))
											{
												current2.dictionary_1.Add(class33_1, 10);
											}
											if (class33_1.class34_1 != null)
											{
												class33_1.class34_1.class33_0 = null;
												class33_1.class33_0 = null;
												class33_1.class34_1 = null;
											}
											this.method_87(class33_1, true, false);
										}
										else
										{
											Class33[] array = this.class33_0;
											for (int i = 0; i < array.Length; i++)
											{
												Class33 class2 = array[i];
												if (class2 != null)
												{
													this.byte_0[class2.int_3, class2.int_4] = 1;
													this.byte_0[class3.Int32_0, class3.Int32_1] = 1;
													class2.method_7(class3.Int32_0, class3.Int32_1, class3.Double_0);
													class2.bool_7 = true;
													if (!current2.dictionary_1.ContainsKey(class2))
													{
														current2.dictionary_1.Add(class2, 10);
													}
												}
											}
										}
										flag2 = true;
									}
								}
								break;
							case "wf_act_togglefurni":
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								if (current2.string_3.Length > 0)
								{
									string[] collection = current2.string_3.Split(new char[]
									{
										','
									});
									IEnumerable<string> enumerable = new List<string>(collection);
									List<string> list2 = enumerable.ToList<string>();
									foreach (string current in enumerable)
									{
										Class63 class3 = this.method_28(Convert.ToUInt32(current));
										if (class3 != null)
										{
											class3.Class69_0.vmethod_2(null, class3, 0, true);
										}
										else
										{
											list2.Remove(current);
										}
									}
									flag2 = true;
								}
								break;
							case "wf_act_givepoints":
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								if (class33_1 != null && current2.string_2.Length > 0)
								{
									this.method_88(class33_1.int_14 + 2, Convert.ToInt32(current2.string_2), current2);
									flag2 = true;
								}
								break;
							case "wf_act_moverotate":
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								current2.method_9();
								if (current2.string_4.Length > 0)
								{
									string[] collection = current2.string_4.Split(new char[]
									{
										','
									});
									IEnumerable<string> enumerable2 = new List<string>(collection);
									foreach (string current in enumerable2)
									{
										Class63 class3 = this.method_28(Convert.ToUInt32(current));
										if (class3 != null)
										{
											if (current2.string_2 != "0" && current2.string_2 != "")
											{
												GStruct1 gstruct1_ = class3.GStruct1_1;
												int num5 = 0;
												int num6 = 0;
												int num7 = 0;
												if (current2.string_2 == "1")
												{
													Random random3 = new Random();
													num5 = random3.Next(1, 5);
												}
												else
												{
													if (current2.string_2 == "2")
													{
														Random random3 = new Random();
														num6 = random3.Next(1, 3);
													}
													else
													{
														if (current2.string_2 == "3")
														{
															Random random3 = new Random();
															num7 = random3.Next(1, 3);
														}
													}
												}
												if (current2.string_2 == "4" || num5 == 1 || num7 == 1)
												{
													gstruct1_ = class3.method_1(4);
												}
												else
												{
													if (current2.string_2 == "5" || num5 == 2 || num6 == 1)
													{
														gstruct1_ = class3.method_1(6);
													}
													else
													{
														if (current2.string_2 == "6" || num5 == 3 || num7 == 2)
														{
															gstruct1_ = class3.method_1(0);
														}
														else
														{
															if (current2.string_2 == "7" || num5 == 4 || num6 == 2)
															{
																gstruct1_ = class3.method_1(2);
															}
														}
													}
												}
												if (this.method_37(gstruct1_.int_0, gstruct1_.int_1, true, true, false, true, false) && class3.method_7().string_2 != "wf_trg_timer")
												{
													this.method_41(class3, gstruct1_, current2.uint_0, class3.Double_0);
												}
											}
											if (current2.string_3.Length > 0 && current2.string_3 != "0" && current2.string_3 != "")
											{
												int num5 = 0;
												if (current2.string_3 == "1")
												{
													num5 = class3.int_3 + 2;
													if (num5 > 6)
													{
														num5 = 0;
													}
												}
												else
												{
													if (current2.string_3 == "2")
													{
														num5 = class3.int_3 - 2;
														if (num5 < 0)
														{
															num5 = 6;
														}
													}
													else
													{
														if (current2.string_3 == "3")
														{
															Random random3 = new Random();
															num5 = random3.Next(1, 5);
															if (num5 == 1)
															{
																num5 = 0;
															}
															else
															{
																if (num5 == 2)
																{
																	num5 = 2;
																}
																else
																{
																	if (num5 == 3)
																	{
																		num5 = 4;
																	}
																	else
																	{
																		if (num5 == 4)
																		{
																			num5 = 6;
																		}
																	}
																}
															}
														}
													}
												}
												if (current2.method_8().method_79(null, class3, class3.Int32_0, class3.Int32_1, num5, false, true, false))
												{
													flag2 = true;
												}
											}
										}
									}
									flag2 = true;
								}
								break;
							case "wf_act_matchfurni":
								current2.string_0 = "1";
								current2.method_5(false, true);
								current2.method_3(1);
								current2.method_9();
								if (current2.string_4.Length > 0 && current2.string_2.Length > 0)
								{
									string[] collection = current2.string_4.Split(new char[]
									{
										','
									});
									IEnumerable<string> enumerable = new List<string>(collection);
									string[] collection2 = current2.string_2.Split(new char[]
									{
										';'
									});
									List<string> list8 = new List<string>(collection2);
									int num8 = 0;
									foreach (string current in enumerable)
									{
										Class63 class3 = this.method_28(Convert.ToUInt32(current));
										if (class3 != null && !(class3.method_7().string_2.ToLower() == "dice"))
										{
											string[] collection3 = list8[num8].Split(new char[]
											{
												','
											});
											List<string> list9 = new List<string>(collection3);
											bool flag6 = false;
											bool flag7 = false;
											if (current2.string_3 != "" && class3 != null)
											{
												int int_ = class3.Int32_0;
												int int_2 = class3.Int32_1;
												if (current2.string_3.StartsWith("I"))
												{
													class3.string_0 = list9[4];
													flag7 = true;
												}
												if (current2.string_3.Substring(1, 1) == "I")
												{
													class3.int_3 = Convert.ToInt32(list9[3]);
													flag6 = true;
												}
												if (current2.string_3.EndsWith("I"))
												{
													int_ = Convert.ToInt32(list9[0]);
													int_2 = Convert.ToInt32(list9[1]);
													flag6 = true;
												}
												if (flag6)
												{
													this.method_40(class3, int_, int_2, current2.uint_0, class3.Double_0);
												}
												if (flag7)
												{
													class3.method_5(false, true);
												}
												this.method_22();
											}
											num8++;
										}
									}
								}
								flag2 = true;
								break;
							}
						}
					}
					result = flag2;
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}
		internal void method_22()
		{
			this.gstruct1_0 = new GStruct1[this.Class28_0.int_4, this.Class28_0.int_5];
			this.double_0 = new double[this.Class28_0.int_4, this.Class28_0.int_5];
			this.byte_2 = new byte[this.Class28_0.int_4, this.Class28_0.int_5];
			this.byte_1 = new byte[this.Class28_0.int_4, this.Class28_0.int_5];
			this.byte_0 = new byte[this.Class28_0.int_4, this.Class28_0.int_5];
			this.double_1 = new double[this.Class28_0.int_4, this.Class28_0.int_5];
			this.double_2 = new double[this.Class28_0.int_4, this.Class28_0.int_5];
			for (int i = 0; i < this.Class28_0.int_5; i++)
			{
				for (int j = 0; j < this.Class28_0.int_4; j++)
				{
					this.double_0[j, i] = 0.0;
					this.byte_0[j, i] = 0;
					this.byte_2[j, i] = 0;
					this.byte_1[j, i] = 0;
					this.gstruct1_0[j, i] = new GStruct1(j, i);
					if (j == this.Class28_0.int_0 && i == this.Class28_0.int_1)
					{
						this.byte_0[j, i] = 3;
					}
					else
					{
						if (this.Class28_0.genum0_0[j, i] == GEnum0.const_0)
						{
							this.byte_0[j, i] = 1;
						}
						else
						{
							if (this.Class28_0.genum0_0[j, i] == GEnum0.const_2)
							{
								this.byte_0[j, i] = 3;
							}
						}
					}
				}
			}
			foreach (Class63 @class in this.Hashtable_0.Values)
			{
				try
				{
					if (@class.method_7().char_0 == 's')
					{
						if (@class.Int32_0 >= this.Class28_0.int_4 || @class.Int32_1 >= this.Class28_0.int_5 || @class.Int32_1 < 0 || @class.Int32_0 < 0)
						{
							this.method_29(null, @class.uint_0, true, false);
							Class16 class2 = Phoenix.smethod_15().method_2().method_3(this.string_3);
							if (class2 != null)
							{
								class2.method_2().method_23().method_11(@class.uint_0, @class.uint_2, @class.string_0, true);
							}
						}
						else
						{
							if (@class.Double_1 > this.double_1[@class.Int32_0, @class.Int32_1])
							{
								this.double_1[@class.Int32_0, @class.Int32_1] = @class.Double_1;
							}
							if (@class.method_7().bool_2)
							{
								this.double_2[@class.Int32_0, @class.Int32_1] = @class.Double_1;
							}
							if (@class.method_7().double_0 > 0.0 || @class.method_7().byte_1 != 0 || @class.method_7().byte_0 != 0 || @class.method_7().bool_2 || !(@class.method_7().string_2.ToLower() != "bed"))
							{
								if (this.double_0[@class.Int32_0, @class.Int32_1] <= @class.Double_0)
								{
									this.double_0[@class.Int32_0, @class.Int32_1] = @class.Double_0;
									if (@class.method_7().byte_1 > 0)
									{
										this.byte_2[@class.Int32_0, @class.Int32_1] = @class.method_7().byte_1;
									}
									else
									{
										if (this.byte_1[@class.Int32_0, @class.Int32_1] != 0)
										{
											this.byte_2[@class.Int32_0, @class.Int32_1] = 0;
										}
									}
									if (@class.method_7().byte_0 > 0)
									{
										this.byte_1[@class.Int32_0, @class.Int32_1] = @class.method_7().byte_0;
									}
									else
									{
										if (this.byte_1[@class.Int32_0, @class.Int32_1] != 0)
										{
											this.byte_1[@class.Int32_0, @class.Int32_1] = 0;
										}
									}
									if (@class.method_7().bool_1)
									{
										if (this.byte_0[@class.Int32_0, @class.Int32_1] != 3)
										{
											this.byte_0[@class.Int32_0, @class.Int32_1] = 1;
										}
									}
									else
									{
										if (@class.Double_0 <= this.Class28_0.double_1[@class.Int32_0, @class.Int32_1] + 0.1 && @class.method_7().string_2.ToLower() == "gate" && @class.string_0 == "1")
										{
											if (this.byte_0[@class.Int32_0, @class.Int32_1] != 3)
											{
												this.byte_0[@class.Int32_0, @class.Int32_1] = 1;
											}
										}
										else
										{
											if (@class.method_7().bool_2 || @class.method_7().string_2.ToLower() == "bed")
											{
												this.byte_0[@class.Int32_0, @class.Int32_1] = 3;
											}
											else
											{
												if (this.byte_0[@class.Int32_0, @class.Int32_1] != 3)
												{
													this.byte_0[@class.Int32_0, @class.Int32_1] = 0;
												}
											}
										}
									}
								}
								if (@class.method_7().bool_2 || @class.method_7().string_2.ToLower() == "bed")
								{
									this.byte_0[@class.Int32_0, @class.Int32_1] = 3;
								}
								Dictionary<int, GClass10> dictionary = @class.Dictionary_0;
								if (dictionary == null)
								{
									dictionary = new Dictionary<int, GClass10>();
								}
								foreach (GClass10 current in dictionary.Values)
								{
									if (@class.Double_1 > this.double_1[current.Int32_0, current.Int32_1])
									{
										this.double_1[current.Int32_0, current.Int32_1] = @class.Double_1;
									}
									if (@class.method_7().bool_2)
									{
										this.double_2[current.Int32_0, current.Int32_1] = @class.Double_1;
									}
									if (this.double_0[current.Int32_0, current.Int32_1] <= @class.Double_0)
									{
										this.double_0[current.Int32_0, current.Int32_1] = @class.Double_0;
										if (@class.method_7().byte_1 > 0)
										{
											this.byte_2[current.Int32_0, current.Int32_1] = @class.method_7().byte_1;
										}
										else
										{
											if (this.byte_1[current.Int32_0, current.Int32_1] != 0)
											{
												this.byte_2[current.Int32_0, current.Int32_1] = 0;
											}
										}
										if (@class.method_7().byte_0 > 0)
										{
											this.byte_1[current.Int32_0, current.Int32_1] = @class.method_7().byte_0;
										}
										else
										{
											if (this.byte_1[current.Int32_0, current.Int32_1] != 0)
											{
												this.byte_1[current.Int32_0, current.Int32_1] = 0;
											}
											else
											{
												if (@class.method_7().bool_1)
												{
													if (this.byte_0[current.Int32_0, current.Int32_1] != 3)
													{
														this.byte_0[current.Int32_0, current.Int32_1] = 1;
													}
												}
												else
												{
													if (@class.Double_0 <= this.Class28_0.double_1[@class.Int32_0, @class.Int32_1] + 0.1 && @class.method_7().string_2.ToLower() == "gate" && @class.string_0 == "1")
													{
														if (this.byte_0[current.Int32_0, current.Int32_1] != 3)
														{
															this.byte_0[current.Int32_0, current.Int32_1] = 1;
														}
													}
													else
													{
														if (@class.method_7().bool_2 || @class.method_7().string_2.ToLower() == "bed")
														{
															this.byte_0[current.Int32_0, current.Int32_1] = 3;
														}
														else
														{
															if (this.byte_0[current.Int32_0, current.Int32_1] != 3)
															{
																this.byte_0[current.Int32_0, current.Int32_1] = 0;
															}
														}
													}
												}
											}
										}
									}
									if (@class.method_7().bool_2 || @class.method_7().string_2.ToLower() == "bed")
									{
										this.byte_0[current.Int32_0, current.Int32_1] = 3;
									}
									if (@class.method_7().string_2.ToLower() == "bed")
									{
										this.byte_0[current.Int32_0, current.Int32_1] = 3;
										if (@class.int_3 == 0 || @class.int_3 == 4)
										{
											this.gstruct1_0[current.Int32_0, current.Int32_1].int_1 = @class.Int32_1;
										}
										if (@class.int_3 == 2 || @class.int_3 == 6)
										{
											this.gstruct1_0[current.Int32_0, current.Int32_1].int_0 = @class.Int32_0;
										}
									}
								}
							}
						}
					}
				}
				catch
				{
					this.method_29(null, @class.uint_0, true, false);
					Class16 class2 = Phoenix.smethod_15().method_2().method_3(this.string_3);
					if (class2 != null)
					{
						class2.method_2().method_23().method_11(@class.uint_0, @class.uint_2, @class.string_0, true);
					}
				}
			}
			if (!this.bool_2)
			{
				for (int k = 0; k < this.class33_0.Length; k++)
				{
					Class33 class3 = this.class33_0[k];
					if (class3 != null)
					{
						this.byte_0[class3.int_3, class3.int_4] = 0;
					}
				}
			}
			this.byte_0[this.Class28_0.int_0, this.Class28_0.int_1] = 3;
		}
		public void method_23()
		{
			this.list_1 = new List<uint>();
			DataTable dataTable = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataTable = @class.method_3("SELECT room_rights.user_id FROM room_rights WHERE room_id = '" + this.uint_0 + "'");
			}
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					this.list_1.Add((uint)dataRow["user_id"]);
				}
			}
		}
		internal List<Class63> method_24(Class16 class16_0)
		{
			List<Class63> list = new List<Class63>();
			foreach (Class63 @class in this.Hashtable_0.Values)
			{
				@class.Class69_0.vmethod_1(class16_0, @class);
				GClass5 gClass = new GClass5(94u);
				gClass.method_12(@class.uint_0);
				gClass.method_7("");
				gClass.method_13(false);
				this.method_59(gClass, null);
				list.Add(@class);
			}
			foreach (Class63 @class in this.Hashtable_1.Values)
			{
				@class.Class69_0.vmethod_1(class16_0, @class);
				GClass5 gClass = new GClass5(84u);
				gClass.method_12(@class.uint_0);
				gClass.method_7("");
				gClass.method_13(false);
				this.method_59(gClass, null);
				list.Add(@class);
			}
			this.hashtable_4.Clear();
			this.hashtable_0.Clear();
			this.hashtable_1.Clear();
			this.hashtable_2.Clear();
			this.hashtable_3.Clear();
			using (Class6 class2 = Phoenix.smethod_12().method_0())
			{
				class2.method_1(string.Concat(new object[]
				{
					"UPDATE items SET room_id = 0, user_id = '",
					class16_0.method_2().uint_0,
					"' WHERE room_id = '",
					this.UInt32_0,
					"'"
				}));
			}
			this.method_22();
			this.method_83();
			return list;
		}
		public void method_25()
		{
			this.hashtable_0.Clear();
			this.hashtable_4.Clear();
			DataTable dataTable;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				dataTable = @class.method_3("SELECT id, base_item, extra_data, x, y, z, rot, wall_pos FROM items WHERE room_id = '" + this.uint_0 + "' ORDER BY room_id DESC");
			}
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Class63 class2 = new Class63((uint)dataRow["id"], this.UInt32_0, (uint)dataRow["base_item"], (string)dataRow["extra_data"], (int)dataRow["x"], (int)dataRow["y"], (double)dataRow["z"], (int)dataRow["rot"], (string)dataRow["wall_pos"], this);
					if (class2.Boolean_0)
					{
						this.bool_11 = true;
					}
					if (class2.method_7().string_2.ToLower().Contains("wf_") || class2.method_7().string_2.ToLower().Contains("fbgate"))
					{
						DataRow dataRow2;
						using (Class6 @class = Phoenix.smethod_12().method_0())
						{
							dataRow2 = @class.method_4("SELECT extra1,extra2,extra3,extra4,extra5 FROM wired_items WHERE item_id = '" + class2.uint_0 + "'");
						}
						if (dataRow2 != null)
						{
							class2.string_2 = (string)dataRow2["extra1"];
							class2.string_3 = (string)dataRow2["extra2"];
							class2.string_4 = (string)dataRow2["extra3"];
							class2.string_5 = (string)dataRow2["extra4"];
							class2.string_6 = (string)dataRow2["extra5"];
						}
					}
					string text = class2.method_7().string_2.ToLower();
					switch (text)
					{
					case "dice":
						if (class2.string_0 == "-1")
						{
							class2.string_0 = "0";
						}
						break;
					case "fbgate":
						if (class2.string_0 != "" && class2.string_0.Contains(','))
						{
							class2.string_2 = class2.string_0.Split(new char[]
							{
								','
							})[0];
							class2.string_3 = class2.string_0.Split(new char[]
							{
								','
							})[1];
						}
						break;
					case "dimmer":
						if (this.class67_0 == null)
						{
							this.class67_0 = new Class67(class2.uint_0);
						}
						break;
					case "bb_patch":
						this.list_5.Add(class2);
						if (class2.string_0 == "5")
						{
							this.list_6.Add(class2);
						}
						else
						{
							if (class2.string_0 == "8")
							{
								this.list_7.Add(class2);
							}
							else
							{
								if (class2.string_0 == "11")
								{
									this.list_9.Add(class2);
								}
								else
								{
									if (class2.string_0 == "14")
									{
										this.list_8.Add(class2);
									}
								}
							}
						}
						break;
					case "blue_score":
						this.list_12.Add(class2);
						break;
					case "green_score":
						this.list_13.Add(class2);
						break;
					case "red_score":
						this.list_10.Add(class2);
						break;
					case "yellow_score":
						this.list_11.Add(class2);
						break;
					case "stickiepole":
						this.list_3.Add(class2);
						break;
					case "wf_trg_onsay":
					case "wf_trg_enterroom":
					case "wf_trg_furnistate":
					case "wf_trg_onfurni":
					case "wf_trg_offfurni":
					case "wf_trg_gameend":
					case "wf_trg_gamestart":
					case "wf_trg_attime":
					case "wf_trg_atscore":
						if (!this.list_14.Contains(class2))
						{
							this.list_14.Add(class2);
						}
						break;
					case "wf_trg_timer":
						if (class2.string_2.Length <= 0)
						{
							class2.string_2 = "10";
						}
						if (!this.list_14.Contains(class2))
						{
							this.list_14.Add(class2);
						}
						class2.bool_0 = true;
						class2.method_3(1);
						break;
					case "wf_act_saymsg":
					case "wf_act_moveuser":
					case "wf_act_togglefurni":
					case "wf_act_givepoints":
					case "wf_act_moverotate":
					case "wf_act_matchfurni":
					case "wf_act_give_phx":
						if (!this.list_15.Contains(class2))
						{
							this.list_15.Add(class2);
						}
						break;
					case "wf_cnd_trggrer_on_frn":
					case "wf_cnd_furnis_hv_avtrs":
					case "wf_cnd_has_furni_on":
					case "wf_cnd_phx":
						if (!this.list_16.Contains(class2))
						{
							this.list_16.Add(class2);
						}
						break;
					}
					if (this.hashtable_0.Contains(class2.uint_0))
					{
						this.hashtable_0.Remove(class2.uint_0);
					}
					if (this.hashtable_4.Contains(class2.uint_0))
					{
						this.hashtable_4.Remove(class2.uint_0);
					}
					if (class2.Boolean_2)
					{
						this.hashtable_0.Add(class2.uint_0, class2);
					}
					else
					{
						this.hashtable_4.Add(class2.uint_0, class2);
					}
				}
			}
		}
		public bool method_26(Class16 class16_0)
		{
			return this.method_27(class16_0, false);
		}
		public bool method_27(Class16 class16_0, bool bool_13)
		{
			bool result;
			try
			{
				if (class16_0.method_2().string_0.ToLower() == this.string_3.ToLower())
				{
					result = true;
					return result;
				}
				if (class16_0.method_2().method_3("acc_anyroomowner") && bool_13)
				{
					result = true;
					return result;
				}
				if (!bool_13)
				{
					if (class16_0.method_2().method_3("acc_anyroomrights"))
					{
						result = true;
						return result;
					}
					if (this.list_1.Contains(class16_0.method_2().uint_0))
					{
						result = true;
						return result;
					}
					if (this.bool_8)
					{
						result = true;
						return result;
					}
				}
			}
			catch
			{
			}
			result = false;
			return result;
		}
		public Class63 method_28(uint uint_2)
		{
			Class63 result;
			if ((this.hashtable_0 != null && this.hashtable_0.ContainsKey(uint_2)) || (this.hashtable_4 != null && this.hashtable_4.ContainsKey(uint_2)))
			{
				Class63 @class = this.hashtable_0[uint_2] as Class63;
				if (@class != null)
				{
					result = @class;
				}
				else
				{
					result = (this.hashtable_4[uint_2] as Class63);
				}
			}
			else
			{
				result = null;
			}
			return result;
		}
		public void method_29(Class16 class16_0, uint uint_2, bool bool_13, bool bool_14)
		{
			Class63 @class = this.method_28(uint_2);
			if (@class != null)
			{
				Dictionary<int, GClass10> dictionary = this.method_94(@class.method_7().int_2, @class.method_7().int_1, @class.Int32_0, @class.Int32_1, @class.int_3);
				@class.Class69_0.vmethod_1(class16_0, @class);
				if (@class.Boolean_1)
				{
					GClass5 gClass = new GClass5(84u);
					gClass.method_12(@class.uint_0);
					gClass.method_7("");
					gClass.method_13(false);
					this.method_59(gClass, null);
				}
				else
				{
					if (@class.Boolean_2)
					{
						GClass5 gClass = new GClass5(94u);
						gClass.method_12(@class.uint_0);
						gClass.method_7("");
						gClass.method_13(false);
						this.method_59(gClass, null);
						string text = @class.method_7().string_2.ToLower();
						switch (text)
						{
						case "bb_patch":
							this.list_5.Remove(@class);
							if (@class.string_0 == "5")
							{
								this.list_6.Remove(@class);
							}
							else
							{
								if (@class.string_0 == "8")
								{
									this.list_7.Remove(@class);
								}
								else
								{
									if (@class.string_0 == "11")
									{
										this.list_9.Remove(@class);
									}
									else
									{
										if (@class.string_0 == "14")
										{
											this.list_8.Remove(@class);
										}
									}
								}
							}
							break;
						case "blue_score":
							this.list_12.Remove(@class);
							break;
						case "green_score":
							this.list_13.Remove(@class);
							break;
						case "red_score":
							this.list_10.Remove(@class);
							break;
						case "yellow_score":
							this.list_11.Remove(@class);
							break;
						case "stickiepole":
							this.list_3.Remove(@class);
							break;
						case "wf_trg_onsay":
						case "wf_trg_enterroom":
						case "wf_trg_furnistate":
						case "wf_trg_onfurni":
						case "wf_trg_offfurni":
						case "wf_trg_gameend":
						case "wf_trg_gamestart":
						case "wf_trg_attime":
						case "wf_trg_atscore":
							this.list_14.Remove(@class);
							break;
						case "wf_trg_timer":
							@class.bool_0 = false;
							this.list_14.Remove(@class);
							break;
						case "wf_act_saymsg":
						case "wf_act_moveuser":
						case "wf_act_togglefurni":
						case "wf_act_givepoints":
						case "wf_act_moverotate":
						case "wf_act_matchfurni":
						case "wf_act_give_phx":
							this.list_15.Remove(@class);
							break;
						case "wf_cnd_trggrer_on_frn":
						case "wf_cnd_furnis_hv_avtrs":
						case "wf_cnd_has_furni_on":
						case "wf_cnd_phx":
							this.list_16.Remove(@class);
							break;
						}
					}
				}
				if (@class.Boolean_1)
				{
					this.hashtable_4.Remove(@class.uint_0);
				}
				else
				{
					this.hashtable_0.Remove(@class.uint_0);
				}
				if (this.hashtable_3.Contains(@class.uint_0))
				{
					this.hashtable_3.Remove(@class.uint_0);
				}
				if (this.hashtable_2.Contains(@class.uint_0))
				{
					this.hashtable_2.Remove(@class.uint_0);
				}
				if (!this.hashtable_1.Contains(@class.uint_0))
				{
					this.hashtable_1.Add(@class.uint_0, @class);
				}
				if (bool_13)
				{
					using (Class6 class2 = Phoenix.smethod_12().method_0())
					{
						class2.method_1("DELETE FROM items WHERE id = '" + uint_2 + "' LIMIT 1");
					}
				}
				if (bool_14)
				{
					this.method_22();
				}
				this.method_87(this.method_43(@class.Int32_0, @class.Int32_1), true, true);
				foreach (GClass10 current in dictionary.Values)
				{
					this.method_87(this.method_43(current.Int32_0, current.Int32_1), true, true);
				}
			}
		}
		public bool method_30(int int_17, int int_18, double double_3, bool bool_13, bool bool_14)
		{
			return this.bool_2 || bool_14 || this.method_43(int_17, int_18) == null;
		}
		private void method_31(string string_10)
		{
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && !@class.Boolean_4)
				{
					@class.method_16().method_8(string_10);
				}
			}
		}
		private void method_32(object object_0)
		{
			this.method_33();
		}
		private void method_33()
		{
			int num = 0;
			if (!this.bool_6 && !this.bool_7)
			{
				try
				{
					this.int_14++;
					if (this.bool_10 && this.int_14 >= 30)
					{
						using (Class6 @class = Phoenix.smethod_12().method_0())
						{
							@class.method_1(string.Concat(new object[]
							{
								"UPDATE rooms SET users_now = '",
								this.Int32_0,
								"' WHERE id = '",
								this.uint_0,
								"' LIMIT 1"
							}));
						}
						this.int_14 = 0;
					}
					this.method_35();
					int num2 = 0;
					try
					{
						if (this.hashtable_0 != null)
						{
							foreach (Class63 class2 in this.Hashtable_0.Values)
							{
								if (class2.bool_1)
								{
									class2.method_2();
								}
							}
						}
					}
					catch (Exception ex)
					{
						GClass4.smethod_6(ex.ToString(), "Room [ID: " + this.UInt32_0 + "] cycle task -- Process Floor Items");
						this.method_34();
					}
					try
					{
						if (this.hashtable_4 != null)
						{
							foreach (Class63 class2 in this.Hashtable_1.Values)
							{
								if (class2.bool_1)
								{
									class2.method_2();
								}
							}
						}
					}
					catch (Exception ex)
					{
						GClass4.smethod_6(ex.ToString(), "Room [ID: " + this.UInt32_0 + "] cycle task -- Process Wall Items");
						this.method_34();
					}
					List<uint> list = new List<uint>();
					int num3 = 0;
					if (this.class33_0 != null)
					{
						try
						{
							for (int i = 0; i < this.class33_0.Length; i++)
							{
								Class33 class3 = this.class33_0[i];
								if (class3 != null)
								{
									num = 1;
									if (!class3.Boolean_4 && class3.method_16() != null)
									{
										num3++;
										if (class3.method_16().method_2() != null && class3.method_16().method_2().int_4 > 0)
										{
											class3.method_16().method_2().int_4--;
											if (class3.method_16().method_2().int_4 == 0)
											{
												class3.method_16().method_2().bool_3 = false;
											}
										}
									}
									class3.int_1++;
									num = 2;
									if (!class3.bool_8 && class3.int_1 >= Class13.int_14)
									{
										class3.bool_8 = true;
										GClass5 gClass = new GClass5(486u);
										gClass.method_9(class3.int_0);
										gClass.method_13(true);
										this.method_59(gClass, null);
									}
									num = 3;
									if (class3.method_16() == null && !class3.Boolean_4)
									{
										this.class33_0[i] = null;
										if (!class3.bool_1)
										{
											this.byte_0[class3.int_3, class3.int_4] = class3.byte_0;
										}
										GClass5 gClass2 = new GClass5(29u);
										gClass2.method_10(class3.int_0);
										this.method_59(gClass2, null);
										this.method_50();
									}
									num = 4;
									if (class3.Boolean_2 && !list.Contains(class3.uint_0))
									{
										list.Add(class3.uint_0);
									}
									num = 5;
									if (class3.int_5 > 0)
									{
										class3.int_6--;
										if (class3.int_6 <= 0)
										{
											class3.method_8(0);
										}
									}
									num = 6;
									if (class3.bool_4 && class3.class34_1 == null)
									{
										num = 7;
										if (class3.Boolean_4 && class3.class34_0.class33_0 != null && this.method_30(class3.int_12, class3.int_13, 0.0, true, true))
										{
											num = 8;
											this.method_85(class3);
											class3.int_3 = class3.int_12;
											class3.int_4 = class3.int_13;
											class3.double_0 = class3.double_1;
											class3.class34_0.class33_0.int_3 = class3.int_12;
											class3.class34_0.class33_0.int_4 = class3.int_13;
											class3.class34_0.class33_0.double_0 = class3.double_1 + 1.0;
											class3.class34_0.class33_0.bool_4 = false;
											class3.class34_0.class33_0.method_12("mv");
											if (class3.int_3 == this.Class28_0.int_0 && class3.int_4 == this.Class28_0.int_1 && !list.Contains(class3.class34_0.class33_0.uint_0))
											{
												list.Add(class3.class34_0.class33_0.uint_0);
											}
											this.method_87(class3, true, true);
										}
										else
										{
											if (this.method_30(class3.int_12, class3.int_13, 0.0, true, class3.bool_1))
											{
												num = 8;
												this.method_85(class3);
												class3.int_3 = class3.int_12;
												class3.int_4 = class3.int_13;
												class3.double_0 = class3.double_1;
												if (class3.int_3 == this.Class28_0.int_0 && class3.int_4 == this.Class28_0.int_1 && !list.Contains(class3.uint_0) && !class3.Boolean_4)
												{
													list.Add(class3.uint_0);
												}
												this.method_87(class3, true, true);
											}
										}
										class3.bool_4 = false;
									}
									num = 9;
									if (class3.bool_6 && !class3.bool_5 && class3.class34_1 == null)
									{
										num = 10;
										Struct1 @struct = Class108.smethod_0(class3.int_3, class3.int_4, class3.int_10, class3.int_11, this.byte_0, this.double_1, this.class28_0.double_1, this.double_2, this.class28_0.int_4, this.class28_0.int_5, class3.bool_1, this.bool_5);
										num = 11;
										if (@struct.Int32_0 != class3.int_3 || @struct.Int32_1 != class3.int_4)
										{
											num = 12;
											int int32_ = @struct.Int32_0;
											int int32_2 = @struct.Int32_1;
											class3.method_12("mv");
											double num4 = this.method_84(int32_, int32_2, this.method_93(int32_, int32_2));
											class3.dictionary_0.Remove("lay");
											class3.dictionary_0.Remove("sit");
											class3.method_11("mv", string.Concat(new object[]
											{
												int32_,
												",",
												int32_2,
												",",
												num4.ToString().Replace(',', '.')
											}));
											num = 13;
											if (class3.Boolean_4 && class3.class34_0.class33_0 != null)
											{
												class3.class34_0.class33_0.method_11("mv", string.Concat(new object[]
												{
													int32_,
													",",
													int32_2,
													",",
													(num4 + 1.0).ToString().Replace(',', '.')
												}));
											}
											int num5;
											if (class3.bool_3)
											{
												num5 = Class107.smethod_1(class3.int_3, class3.int_4, int32_, int32_2);
											}
											else
											{
												num5 = Class107.smethod_0(class3.int_3, class3.int_4, int32_, int32_2);
											}
											class3.int_8 = num5;
											class3.int_7 = num5;
											class3.bool_4 = true;
											class3.int_12 = int32_;
											class3.int_13 = int32_2;
											class3.double_1 = num4;
											num = 14;
											if (class3.Boolean_4 && class3.class34_0.class33_0 != null)
											{
												class3.class34_0.class33_0.int_8 = num5;
												class3.class34_0.class33_0.int_7 = num5;
												class3.class34_0.class33_0.bool_4 = true;
												class3.class34_0.class33_0.int_12 = int32_;
												class3.class34_0.class33_0.int_13 = int32_2;
												class3.class34_0.class33_0.double_1 = num4 + 1.0;
											}
											try
											{
												num = 15;
												if (!class3.Boolean_4)
												{
													if (class3.method_16().method_2().string_6.ToLower() == "m" && this.byte_1[int32_, int32_2] > 0 && class3.byte_1 != this.byte_1[int32_, int32_2])
													{
														class3.method_16().method_2().method_24().method_2((int)this.byte_1[int32_, int32_2], true);
														class3.byte_1 = this.byte_1[int32_, int32_2];
													}
													else
													{
														if (class3.method_16().method_2().string_6.ToLower() == "f" && this.byte_2[int32_, int32_2] > 0 && class3.byte_1 != this.byte_2[int32_, int32_2])
														{
															class3.method_16().method_2().method_24().method_2((int)this.byte_2[int32_, int32_2], true);
															class3.byte_1 = this.byte_2[int32_, int32_2];
														}
													}
												}
												else
												{
													if (!class3.Boolean_0)
													{
														if (this.byte_1[int32_, int32_2] > 0)
														{
															class3.class34_0.int_0 = (int)this.byte_1[int32_, int32_2];
															class3.byte_1 = this.byte_1[int32_, int32_2];
														}
														GClass5 gClass3 = new GClass5(485u);
														gClass3.method_9(class3.int_0);
														gClass3.method_9(class3.class34_0.int_0);
														this.method_59(gClass3, null);
													}
												}
												goto IL_CE1;
											}
											catch
											{
												goto IL_CE1;
											}
											IL_B8B:
											this.method_87(class3, false, true);
											class3.bool_7 = true;
											if (class3.Boolean_4 && class3.class34_0.class33_0 != null)
											{
												this.method_87(class3.class34_0.class33_0, true, true);
												class3.class34_0.class33_0.bool_7 = true;
												goto IL_BE0;
											}
											goto IL_BE0;
											IL_CE1:
											num = 16;
											this.byte_0[class3.int_3, class3.int_4] = class3.byte_0;
											class3.byte_0 = this.byte_0[class3.int_12, class3.int_13];
											if (this.bool_2)
											{
												goto IL_B8B;
											}
											this.byte_0[int32_, int32_2] = 0;
											goto IL_B8B;
										}
										num = 12;
										class3.bool_6 = false;
										class3.method_12("mv");
										class3.bool_10 = false;
										if (class3.Boolean_4 && class3.class34_0.class33_0 != null)
										{
											class3.class34_0.class33_0.method_12("mv");
											class3.class34_0.class33_0.bool_6 = false;
											class3.class34_0.class33_0.bool_10 = false;
											class3.class34_0.class33_0.bool_7 = true;
										}
										IL_BE0:
										class3.bool_7 = true;
									}
									else
									{
										num = 17;
										if (class3.dictionary_0.ContainsKey("mv") && class3.class34_1 == null)
										{
											num = 18;
											class3.method_12("mv");
											class3.bool_7 = true;
											if (class3.Boolean_4 && class3.class34_0.class33_0 != null)
											{
												class3.class34_0.class33_0.method_12("mv");
												class3.class34_0.class33_0.bool_7 = true;
											}
										}
									}
									if (class3.Boolean_4 || class3.Boolean_0)
									{
										try
										{
											class3.class99_0.vmethod_6();
											goto IL_C9F;
										}
										catch
										{
											goto IL_C9F;
										}
									}
									goto IL_C9B;
									IL_C9F:
									if (class3.int_9 > 0)
									{
										if (class3.int_9 == 1)
										{
											this.method_87(class3, true, true);
										}
										class3.int_9--;
										goto IL_CD6;
									}
									goto IL_CD6;
									IL_C9B:
									num2++;
									goto IL_C9F;
								}
								IL_CD6:;
							}
						}
						catch (Exception ex)
						{
							GClass4.smethod_6(ex.ToString(), string.Concat(new object[]
							{
								"Room [ID: ",
								this.UInt32_0,
								"] [Part: ",
								num,
								" cycle task -- Process Users Updates"
							}));
							this.method_34();
						}
					}
					try
					{
						foreach (uint current in list)
						{
							this.method_47(Phoenix.smethod_15().method_2().method_2(current), true, false);
						}
					}
					catch (Exception ex)
					{
						GClass4.smethod_6(ex.ToString(), "Room [ID: " + this.UInt32_0 + "] cycle task -- Remove Users");
						this.method_34();
					}
					if (num2 >= 1)
					{
						this.int_8 = 0;
					}
					else
					{
						this.int_8++;
					}
					if (!this.bool_6 && !this.bool_7)
					{
						try
						{
							if (this.int_8 >= 60)
							{
								Phoenix.smethod_15().method_9().method_16(this);
								return;
							}
							GClass5 gClass4 = this.method_67(false);
							if (gClass4 != null)
							{
								this.method_59(gClass4, null);
							}
						}
						catch (Exception ex)
						{
							GClass4.smethod_6(ex.ToString(), "Room [ID: " + this.UInt32_0 + "] cycle task -- Cycle End");
							this.method_34();
						}
					}
					this.class27_0.int_2 = num3;
				}
				catch (Exception ex)
				{
					GClass4.smethod_6(ex.ToString(), "Room [ID: " + this.UInt32_0 + "] cycle task");
				}
			}
		}
		private void method_34()
		{
			if (!this.bool_7 && Class13.bool_18)
			{
				this.bool_7 = true;
				try
				{
					this.method_31(Class8.smethod_1("error_roomunload"));
				}
				catch
				{
				}
				Phoenix.smethod_15().method_9().method_16(this);
			}
		}
		private void method_35()
		{
			if (this.bool_11)
			{
				if (this.int_16 >= this.int_15 || this.int_15 == 0)
				{
					Hashtable hashtable = this.hashtable_0.Clone() as Hashtable;
					List<uint> list = new List<uint>();
					List<uint> list2 = new List<uint>();
					foreach (Class63 @class in hashtable.Values)
					{
						if (@class.Boolean_0)
						{
							GStruct1 gStruct1_ = @class.GStruct1_1;
							if (gStruct1_.int_0 >= this.Class28_0.int_4 || gStruct1_.int_1 >= this.Class28_0.int_5 || gStruct1_.int_0 < 0 || gStruct1_.int_1 < 0)
							{
								return;
							}
							List<Class63> list3 = this.method_45(@class.Int32_0, @class.Int32_1);
							Class33 class2 = this.method_43(@class.Int32_0, @class.Int32_1);
							if (list3.Count > 0 || class2 != null)
							{
								List<Class63> list4 = this.method_45(gStruct1_.int_0, gStruct1_.int_1);
								double num = this.Class28_0.double_1[gStruct1_.int_0, gStruct1_.int_1];
								int num2 = 0;
								int num3 = 0;
								bool flag = false;
								foreach (Class63 current in list4)
								{
									if (current.Double_1 > num)
									{
										num = current.Double_1;
									}
									if (!current.Boolean_0)
									{
										num2++;
									}
									else
									{
										num3++;
									}
									if (!flag && current.method_7().string_2.ToLower() == "wf_trg_timer")
									{
										flag = true;
									}
								}
								bool flag2 = num2 > 0;
								if (this.method_43(gStruct1_.int_0, gStruct1_.int_1) != null)
								{
									flag2 = true;
								}
								bool flag3 = num3 > 0;
								foreach (Class63 current in list3)
								{
									bool flag4 = current.method_7().string_2.ToLower() == "wf_trg_timer";
									if (!current.Boolean_0 && !list.Contains(current.uint_0) && this.method_36(gStruct1_.int_0, gStruct1_.int_1) && (!flag2 || !flag3) && @class.Double_0 < current.Double_0 && this.method_43(gStruct1_.int_0, gStruct1_.int_1) == null && (!flag4 || !flag))
									{
										double double_;
										if (flag3)
										{
											double_ = current.Double_0;
										}
										else
										{
											double_ = current.Double_0 - @class.Double_1 + this.Class28_0.double_1[gStruct1_.int_0, gStruct1_.int_1];
										}
										this.method_41(current, gStruct1_, @class.uint_0, double_);
										list.Add(current.uint_0);
									}
								}
								if (class2 != null && (!flag2 || !flag3) && this.method_37(gStruct1_.int_0, gStruct1_.int_1, false, true, false, true, true) && !list2.Contains(class2.uint_0) && !class2.bool_6)
								{
									if (this.double_2[gStruct1_.int_0, gStruct1_.int_1] > 0.0)
									{
										num = this.method_84(gStruct1_.int_0, gStruct1_.int_1, this.method_93(gStruct1_.int_0, gStruct1_.int_1));
									}
									if (class2.Boolean_4 && class2.class34_0.class33_0 != null)
									{
										this.method_42(class2, gStruct1_, @class.uint_0, num);
										list2.Add(class2.uint_0);
										this.method_42(class2.class34_0.class33_0, gStruct1_, @class.uint_0, num + 1.0);
										list2.Add(class2.class34_0.class33_0.uint_0);
									}
									else
									{
										if (class2.class34_1 == null)
										{
											this.method_42(class2, gStruct1_, @class.uint_0, num);
											list2.Add(class2.uint_0);
										}
									}
								}
							}
						}
					}
					hashtable.Clear();
					hashtable = null;
					list.Clear();
					list2.Clear();
					this.int_16 = 0;
				}
				else
				{
					this.int_16++;
				}
			}
		}
		public bool method_36(int int_17, int int_18)
		{
			bool result;
			if (!this.method_92(int_17, int_18))
			{
				result = false;
			}
			else
			{
				if (this.Class28_0.genum0_0[int_17, int_18] == GEnum0.const_1)
				{
					result = false;
				}
				else
				{
					List<Class63> list = this.method_93(int_17, int_18);
					if (list.Count > 1)
					{
						foreach (Class63 current in list)
						{
							if (current.Boolean_0)
							{
								result = true;
								return result;
							}
						}
					}
					result = true;
				}
			}
			return result;
		}
		public bool method_37(int int_17, int int_18, bool bool_13, bool bool_14, bool bool_15, bool bool_16, bool bool_17)
		{
			bool result;
			if (!this.method_92(int_17, int_18))
			{
				result = false;
			}
			else
			{
				if (this.Class28_0.genum0_0[int_17, int_18] == GEnum0.const_1)
				{
					result = false;
				}
				else
				{
					if (bool_17 && this.double_2[int_17, int_18] > 0.0)
					{
						result = true;
					}
					else
					{
						if (bool_13 && this.method_97(int_17, int_18))
						{
							result = false;
						}
						else
						{
							if (bool_14)
							{
								List<Class63> list = this.method_93(int_17, int_18);
								if (list.Count > 0)
								{
									if (!bool_15 && !bool_16 && !bool_17)
									{
										result = false;
										return result;
									}
									if (bool_15)
									{
										foreach (Class63 current in list)
										{
											if (!current.method_7().bool_0)
											{
												result = false;
												return result;
											}
										}
									}
									if (bool_16 && bool_17)
									{
										using (List<Class63>.Enumerator enumerator = list.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												Class63 current = enumerator.Current;
												if (!current.method_7().bool_1 && !current.method_7().bool_2)
												{
													result = false;
													return result;
												}
											}
											goto IL_1DD;
										}
									}
									if (bool_16)
									{
										using (List<Class63>.Enumerator enumerator = list.GetEnumerator())
										{
											while (enumerator.MoveNext())
											{
												Class63 current = enumerator.Current;
												if (!current.method_7().bool_1)
												{
													result = false;
													return result;
												}
											}
											goto IL_1DD;
										}
									}
									if (bool_17)
									{
										foreach (Class63 current in list)
										{
											if (!current.method_7().bool_2)
											{
												result = false;
												return result;
											}
										}
									}
								}
							}
							IL_1DD:
							result = true;
						}
					}
				}
			}
			return result;
		}
		internal void method_38(int int_17, int int_18)
		{
			this.byte_0[int_17, int_18] = 1;
		}
		internal void method_39(int int_17, int int_18)
		{
			this.byte_0[int_17, int_18] = 0;
		}
		private void method_40(Class63 class63_0, int int_17, int int_18, uint uint_2, double double_3)
		{
			GClass5 gClass = new GClass5();
			gClass.method_2(230u);
			gClass.method_9(class63_0.Int32_0);
			gClass.method_9(class63_0.Int32_1);
			gClass.method_9(int_17);
			gClass.method_9(int_18);
			gClass.method_9(1);
			gClass.method_11(class63_0.uint_0);
			gClass.method_7(class63_0.Double_0.ToString().Replace(',', '.'));
			gClass.method_7(double_3.ToString().Replace(',', '.'));
			gClass.method_11(uint_2);
			this.method_59(gClass, null);
			this.method_81(class63_0, int_17, int_18, double_3);
		}
		private void method_41(Class63 class63_0, GStruct1 gstruct1_1, uint uint_2, double double_3)
		{
			this.method_40(class63_0, gstruct1_1.int_0, gstruct1_1.int_1, uint_2, double_3);
		}
		private void method_42(Class33 class33_1, GStruct1 gstruct1_1, uint uint_2, double double_3)
		{
			GClass5 gClass = new GClass5();
			gClass.method_2(230u);
			gClass.method_9(class33_1.int_3);
			gClass.method_9(class33_1.int_4);
			gClass.method_9(gstruct1_1.int_0);
			gClass.method_9(gstruct1_1.int_1);
			gClass.method_9(0);
			gClass.method_11(uint_2);
			gClass.method_6("J");
			gClass.method_9(class33_1.int_0);
			gClass.method_7(class33_1.double_0.ToString().Replace(',', '.'));
			gClass.method_7(double_3.ToString().Replace(',', '.'));
			this.method_59(gClass, null);
			this.byte_0[class33_1.int_3, class33_1.int_4] = 1;
			class33_1.int_3 = gstruct1_1.int_0;
			class33_1.int_4 = gstruct1_1.int_1;
			class33_1.double_0 = double_3;
			class33_1.int_12 = gstruct1_1.int_0;
			class33_1.int_13 = gstruct1_1.int_1;
			class33_1.double_1 = double_3;
			class33_1.int_9 = 2;
			this.byte_0[class33_1.int_3, class33_1.int_4] = 0;
			this.method_87(class33_1, false, true);
		}
		internal Class33 method_43(int int_17, int int_18)
		{
			Class33 result;
			if (this.class33_0 != null)
			{
				for (int i = 0; i < this.class33_0.Length; i++)
				{
					Class33 @class = this.class33_0[i];
					if (@class != null && (@class.int_3 == int_17 && @class.int_4 == int_18))
					{
						result = @class;
						return result;
					}
				}
			}
			result = null;
			return result;
		}
		internal Class33 method_44(int int_17, int int_18)
		{
			Class33 result;
			if (this.class33_0 != null)
			{
				for (int i = 0; i < this.class33_0.Length; i++)
				{
					Class33 @class = this.class33_0[i];
					if (@class != null)
					{
						if (@class.int_3 == int_17 && @class.int_4 == int_18)
						{
							result = @class;
							return result;
						}
						if (@class.int_12 == int_17 && @class.int_13 == int_18)
						{
							result = @class;
							return result;
						}
					}
				}
			}
			result = null;
			return result;
		}
		private List<Class63> method_45(int int_17, int int_18)
		{
			List<Class63> list = new List<Class63>();
			foreach (Class63 @class in this.Hashtable_0.Values)
			{
				if (@class.Int32_0 == int_17 && @class.Int32_1 == int_18)
				{
					list.Add(@class);
				}
			}
			return list;
		}
		public void method_46(Class16 class16_0, bool bool_13)
		{
			Class33 @class = new Class33(class16_0.method_2().uint_0, this.UInt32_0, this.int_7++, class16_0.method_2().bool_1);
			if (@class != null && @class.method_16() != null && @class.method_16().method_2() != null)
			{
				if (bool_13 || !@class.bool_12)
				{
					@class.bool_11 = true;
				}
				else
				{
					@class.method_7(this.Class28_0.int_0, this.Class28_0.int_1, this.Class28_0.double_0);
					@class.method_9(this.Class28_0.int_2);
					if (this.method_27(class16_0, true))
					{
						@class.method_11("flatctrl", "useradmin");
					}
					else
					{
						if (this.method_26(class16_0))
						{
							@class.method_11("flatctrl", "");
						}
					}
					if (!@class.Boolean_4 && @class.method_16().method_2().bool_7)
					{
						Class63 class2 = this.method_28(@class.method_16().method_2().uint_5);
						if (class2 != null)
						{
							@class.method_7(class2.Int32_0, class2.Int32_1, class2.Double_0);
							@class.method_9(class2.int_3);
							class2.uint_4 = class16_0.method_2().uint_0;
							class2.string_0 = "2";
							class2.method_5(false, true);
						}
					}
					@class.method_16().method_2().bool_7 = false;
					@class.method_16().method_2().uint_5 = 0u;
					GClass5 gClass = new GClass5(28u);
					gClass.method_9(1);
					@class.method_14(gClass);
					this.method_59(gClass, null);
				}
				int num = this.method_5();
				@class.int_20 = num;
				this.class33_0[num] = @class;
				if (!bool_13)
				{
					this.bool_10 = true;
				}
				class16_0.method_2().uint_3 = this.uint_0;
				class16_0.method_2().method_21().method_5(false);
				class16_0.method_2().int_14++;
				int num2 = class16_0.method_2().int_14;
				if (num2 <= 500)
				{
					if (num2 <= 50)
					{
						if (num2 != 5)
						{
							if (num2 == 50)
							{
								Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 2);
							}
						}
						else
						{
							Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 1);
						}
					}
					else
					{
						if (num2 != 100)
						{
							if (num2 != 200)
							{
								if (num2 == 500)
								{
									Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 5);
								}
							}
							else
							{
								Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 4);
							}
						}
						else
						{
							Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 3);
						}
					}
				}
				else
				{
					if (num2 <= 1500)
					{
						if (num2 != 750)
						{
							if (num2 == 1500)
							{
								Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 7);
							}
						}
						else
						{
							Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 6);
						}
					}
					else
					{
						if (num2 != 2500)
						{
							if (num2 != 4000)
							{
								if (num2 == 5000)
								{
									Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 10);
								}
							}
							else
							{
								Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 9);
							}
						}
						else
						{
							Phoenix.smethod_15().method_12().method_3(class16_0, 13u, 8);
						}
					}
				}
				class16_0.method_2().method_10(this.uint_0);
				if (class16_0.method_2().int_0 > 0)
				{
					Class5 class3 = Class4.smethod_2(class16_0.method_2().int_0);
					if (class3 != null && !this.list_17.Contains(class3))
					{
						this.list_17.Add(class3);
						GClass5 gClass2 = new GClass5(309u);
						gClass2.method_9(this.list_17.Count);
						foreach (Class5 current in this.list_17)
						{
							gClass2.method_9(current.int_0);
							gClass2.method_7(current.string_2);
						}
						this.method_59(gClass2, null);
					}
				}
				if (!bool_13)
				{
					this.method_51();
					for (int i = 0; i < this.class33_0.Length; i++)
					{
						Class33 class4 = this.class33_0[i];
						if (class4 != null && class4.Boolean_4)
						{
							class4.class99_0.vmethod_2(@class);
						}
					}
				}
			}
		}
		public void method_47(Class16 class16_0, bool bool_13, bool bool_14)
		{
			int num = 1;
			if (!bool_14 || !class16_0.method_2().bool_0)
			{
				if (this.bool_12)
				{
					if (bool_13 && class16_0 != null)
					{
						if (bool_14)
						{
							GClass5 gClass = new GClass5(33u);
							gClass.method_9(4008);
							class16_0.method_14(gClass);
						}
						GClass5 gclass5_ = new GClass5(18u);
						class16_0.method_14(gclass5_);
					}
				}
				else
				{
					try
					{
						if (class16_0 != null && class16_0.method_2() != null)
						{
							num = 2;
							Class33 @class = this.method_53(class16_0.method_2().uint_0);
							if (@class != null)
							{
								this.class33_0[@class.int_20] = null;
								@class.int_20 = -1;
								this.byte_0[@class.int_3, @class.int_4] = @class.byte_0;
							}
							num = 3;
							if (bool_13)
							{
								if (bool_14)
								{
									GClass5 gClass = new GClass5(33u);
									gClass.method_9(4008);
									class16_0.method_14(gClass);
								}
								GClass5 gclass5_ = new GClass5(18u);
								class16_0.method_14(gclass5_);
							}
							num = 4;
							if (@class != null && !@class.bool_11)
							{
								if (@class.byte_1 > 0 && @class.method_16() != null)
								{
									@class.method_16().method_2().method_24().int_0 = -1;
								}
								this.byte_0[@class.int_3, @class.int_4] = @class.byte_0;
								if (!this.Boolean_3)
								{
									GClass5 gClass2 = new GClass5(700u);
									gClass2.method_13(false);
									class16_0.method_14(gClass2);
								}
								GClass5 gClass3 = new GClass5(29u);
								gClass3.method_10(@class.int_0);
								this.method_59(gClass3, null);
								if (this.method_74(class16_0.method_2().uint_0))
								{
									this.method_78(class16_0.method_2().uint_0);
								}
								num = 5;
								if (class16_0.method_2().string_0.ToLower() == this.string_3.ToLower() && this.Boolean_0)
								{
									this.class21_0 = null;
									GClass5 gClass4 = new GClass5(370u);
									gClass4.method_7("-1");
									this.method_59(gClass4, null);
								}
								num = 6;
								if (@class.class34_1 != null)
								{
									@class.class34_1.class33_0 = null;
									@class.class34_1 = null;
									class16_0.method_2().method_24().int_0 = -1;
								}
								class16_0.method_2().method_11();
								this.bool_10 = true;
								this.method_51();
								List<Class33> list = new List<Class33>();
								for (int i = 0; i < this.class33_0.Length; i++)
								{
									Class33 class2 = this.class33_0[i];
									if (class2 != null && class2.Boolean_4)
									{
										list.Add(class2);
									}
								}
								num = 7;
								foreach (Class33 current in list)
								{
									current.class99_0.vmethod_3(class16_0);
								}
							}
						}
					}
					catch (Exception ex)
					{
						GClass4.smethod_3(string.Concat(new object[]
						{
							"Error during removing user from room [Part: ",
							num,
							"]: ",
							ex.ToString()
						}));
					}
				}
			}
		}
		public Class33 method_48(uint uint_2)
		{
			Class33 result;
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && @class.Boolean_4 && @class.Boolean_0 && @class.class15_0 != null && @class.class15_0.uint_0 == uint_2)
				{
					result = @class;
					return result;
				}
			}
			result = null;
			return result;
		}
		public bool method_49(uint uint_2)
		{
			return this.method_48(uint_2) != null;
		}
		public void method_50()
		{
			this.int_2 = this.Int32_0;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_1(string.Concat(new object[]
				{
					"UPDATE rooms SET users_now = '",
					this.Int32_0,
					"' WHERE id = '",
					this.uint_0,
					"' LIMIT 1"
				}));
			}
		}
		public void method_51()
		{
			this.int_2 = this.Int32_0;
		}
		public Class33 method_52(int int_17)
		{
			Class33 result;
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && @class.int_0 == int_17)
				{
					result = @class;
					return result;
				}
			}
			result = null;
			return result;
		}
		public Class33 method_53(uint uint_2)
		{
			Class33 result;
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && !@class.Boolean_4 && @class.uint_0 == uint_2)
				{
					result = @class;
					return result;
				}
			}
			result = null;
			return result;
		}
		public void method_54()
		{
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && (!@class.Boolean_4 && @class.class34_1 == null))
				{
					@class.int_15 = 1;
					GClass5 gClass = new GClass5(480u);
					gClass.method_9(@class.int_0);
					gClass.method_9(1);
					this.method_59(gClass, null);
				}
			}
		}
		public void method_55()
		{
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && (!@class.Boolean_4 && @class.class34_1 == null) && (!@class.dictionary_0.ContainsKey("sit") && !@class.dictionary_0.ContainsKey("lay") && @class.int_8 != 1 && @class.int_8 != 3 && @class.int_8 != 5 && @class.int_8 != 7))
				{
					@class.method_11("sit", ((@class.double_0 + 1.0) / 2.0 - @class.double_0 * 0.5).ToString());
					@class.bool_7 = true;
				}
			}
		}
		public Class33 method_56(string string_10)
		{
			Class33 result;
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && !@class.Boolean_4 && @class.method_16().method_2() != null && @class.method_16().method_2().string_0.ToLower() == string_10.ToLower())
				{
					result = @class;
					return result;
				}
			}
			result = null;
			return result;
		}
		public Class33 method_57(string string_10)
		{
			Class33 result;
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null && @class.Boolean_4 && @class.class34_0.string_1.ToLower() == string_10.ToLower())
				{
					result = @class;
					return result;
				}
			}
			result = null;
			return result;
		}
		internal void method_58(GClass5 gclass5_0, List<uint> list_18, uint uint_2)
		{
			List<uint> list = new List<uint>();
			if (list_18 != null)
			{
				if (this.class33_0 == null)
				{
					return;
				}
				for (int i = 0; i < this.class33_0.Length; i++)
				{
					Class33 @class = this.class33_0[i];
					if (@class != null && !@class.Boolean_4)
					{
						Class16 class2 = @class.method_16();
						if (class2 != null && class2.method_2().uint_0 != uint_2 && class2.method_2().list_2.Contains(uint_2))
						{
							list.Add(class2.method_2().uint_0);
						}
					}
				}
			}
			this.method_59(gclass5_0, list);
		}
		internal void method_59(GClass5 gclass5_0, List<uint> list_18)
		{
			try
			{
				if (this.class33_0 != null)
				{
					byte[] array = gclass5_0.method_14();
					for (int i = 0; i < this.class33_0.Length; i++)
					{
						Class33 @class = this.class33_0[i];
						if (@class != null && !@class.Boolean_4)
						{
							Class16 class2 = @class.method_16();
							if (class2 != null && (list_18 == null || !list_18.Contains(class2.method_2().uint_0)))
							{
								try
								{
									class2.method_0().method_2(array);
								}
								catch
								{
								}
							}
						}
					}
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		internal void method_60(GClass5 gclass5_0, int int_17)
		{
			try
			{
				byte[] array = gclass5_0.method_14();
				for (int i = 0; i < this.class33_0.Length; i++)
				{
					Class33 @class = this.class33_0[i];
					if (@class != null && !@class.Boolean_4)
					{
						Class16 class2 = @class.method_16();
						if (class2 != null && class2.method_2() != null && (ulong)class2.method_2().uint_1 >= (ulong)((long)int_17))
						{
							try
							{
								class2.method_0().method_2(array);
							}
							catch
							{
							}
						}
					}
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		public void method_61(GClass5 gclass5_0)
		{
			try
			{
				byte[] array = gclass5_0.method_14();
				for (int i = 0; i < this.class33_0.Length; i++)
				{
					Class33 @class = this.class33_0[i];
					if (@class != null && !@class.Boolean_4)
					{
						Class16 class2 = @class.method_16();
						if (class2 != null && this.method_26(class2))
						{
							try
							{
								class2.method_0().method_2(array);
							}
							catch
							{
							}
						}
					}
				}
			}
			catch (InvalidOperationException)
			{
			}
		}
		public void method_62()
		{
			this.method_59(new GClass5(18u), null);
			this.method_63();
		}
		public void method_63()
		{
			this.method_66(true);
			GC.SuppressFinalize(this);
		}
		internal void method_64()
		{
			StringBuilder stringBuilder = new StringBuilder();
			Dictionary<uint, bool> dictionary = new Dictionary<uint, bool>();
			try
			{
				try
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						if (this.list_14.Count > 0)
						{
							lock (this.list_14)
							{
								foreach (Class63 class2 in this.list_14)
								{
									try
									{
										if (!dictionary.ContainsKey(class2.uint_0))
										{
											if (class2.string_2 != "" || class2.string_3 != "" || class2.string_4 != "" || class2.string_5 != "" || class2.string_6 != "")
											{
												@class.method_0(class2.uint_0 + "Extra1", class2.string_2);
												@class.method_0(class2.uint_0 + "Extra2", class2.string_3);
												@class.method_0(class2.uint_0 + "Extra3", class2.string_4);
												@class.method_0(class2.uint_0 + "Extra4", class2.string_5);
												@class.method_0(class2.uint_0 + "Extra5", class2.string_6);
												stringBuilder.Append(string.Concat(new object[]
												{
													"DELETE FROM wired_items WHERE item_id = '",
													class2.uint_0,
													"' LIMIT 1; INSERT INTO wired_items (item_id,extra1,extra2,extra3,extra4,extra5) VALUES ('",
													class2.uint_0,
													"',@",
													class2.uint_0,
													"Extra1,@",
													class2.uint_0,
													"Extra2,@",
													class2.uint_0,
													"Extra3,@",
													class2.uint_0,
													"Extra4,@",
													class2.uint_0,
													"Extra5); "
												}));
											}
											dictionary.Add(class2.uint_0, true);
										}
									}
									catch
									{
									}
								}
							}
						}
						if (this.list_15.Count > 0)
						{
							lock (this.list_15)
							{
								foreach (Class63 class2 in this.list_15)
								{
									try
									{
										if (!dictionary.ContainsKey(class2.uint_0))
										{
											if (class2.string_2 != "" || class2.string_3 != "" || class2.string_4 != "" || class2.string_5 != "" || class2.string_6 != "")
											{
												@class.method_0(class2.uint_0 + "Extra1", class2.string_2);
												@class.method_0(class2.uint_0 + "Extra2", class2.string_3);
												@class.method_0(class2.uint_0 + "Extra3", class2.string_4);
												@class.method_0(class2.uint_0 + "Extra4", class2.string_5);
												@class.method_0(class2.uint_0 + "Extra5", class2.string_6);
												stringBuilder.Append(string.Concat(new object[]
												{
													"DELETE FROM wired_items WHERE item_id = '",
													class2.uint_0,
													"' LIMIT 1; INSERT INTO wired_items (item_id,extra1,extra2,extra3,extra4,extra5) VALUES ('",
													class2.uint_0,
													"',@",
													class2.uint_0,
													"Extra1,@",
													class2.uint_0,
													"Extra2,@",
													class2.uint_0,
													"Extra3,@",
													class2.uint_0,
													"Extra4,@",
													class2.uint_0,
													"Extra5); "
												}));
											}
											dictionary.Add(class2.uint_0, true);
										}
									}
									catch
									{
									}
								}
							}
						}
						if (this.list_16.Count > 0)
						{
							lock (this.list_16)
							{
								foreach (Class63 class2 in this.list_16)
								{
									try
									{
										if (!dictionary.ContainsKey(class2.uint_0))
										{
											if (class2.string_2 != "" || class2.string_3 != "" || class2.string_4 != "" || class2.string_5 != "" || class2.string_6 != "")
											{
												@class.method_0(class2.uint_0 + "Extra1", class2.string_2);
												@class.method_0(class2.uint_0 + "Extra2", class2.string_3);
												@class.method_0(class2.uint_0 + "Extra3", class2.string_4);
												@class.method_0(class2.uint_0 + "Extra4", class2.string_5);
												@class.method_0(class2.uint_0 + "Extra5", class2.string_6);
												stringBuilder.Append(string.Concat(new object[]
												{
													"DELETE FROM wired_items WHERE item_id = '",
													class2.uint_0,
													"' LIMIT 1; INSERT INTO wired_items (item_id,extra1,extra2,extra3,extra4,extra5) VALUES ('",
													class2.uint_0,
													"',@",
													class2.uint_0,
													"Extra1,@",
													class2.uint_0,
													"Extra2,@",
													class2.uint_0,
													"Extra3,@",
													class2.uint_0,
													"Extra4,@",
													class2.uint_0,
													"Extra5); "
												}));
											}
											dictionary.Add(class2.uint_0, true);
										}
									}
									catch
									{
									}
								}
							}
						}
						if (stringBuilder.Length > 0)
						{
							@class.method_1(stringBuilder.ToString());
						}
						dictionary.Clear();
					}
				}
				catch (Exception ex)
				{
					GClass4.smethod_3(string.Concat(new object[]
					{
						"Error during saving wired items for room ",
						this.UInt32_0,
						". Stack: ",
						ex.ToString(),
						"\rQuery: ",
						stringBuilder.ToString()
					}));
				}
				if (this.hashtable_3.Count > 0 || this.hashtable_1.Count > 0 || this.hashtable_2.Count > 0 || this.Boolean_4)
				{
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						stringBuilder.Clear();
						lock (this.hashtable_1)
						{
							foreach (Class63 class2 in this.hashtable_1.Values)
							{
								stringBuilder.Append(string.Concat(new object[]
								{
									"UPDATE items SET room_id = '0' WHERE id = '",
									class2.uint_0,
									"' AND room_id = '",
									this.UInt32_0,
									"' LIMIT 1; "
								}));
							}
						}
						this.hashtable_1.Clear();
						lock (this.hashtable_3)
						{
							if (this.hashtable_3.Count > 0)
							{
								int num = 0;
								int num2 = 0;
								foreach (Class63 class2 in this.hashtable_3.Values)
								{
									if (class2.Boolean_2)
									{
										num2++;
									}
									else
									{
										num++;
									}
								}
								if (num2 > 0)
								{
									foreach (Class63 class2 in this.hashtable_3.Values)
									{
										if (class2.Boolean_2)
										{
											@class.method_0("extra_data" + class2.uint_0, class2.string_0);
											stringBuilder.Append(string.Concat(new object[]
											{
												"UPDATE items SET room_id = '",
												this.UInt32_0,
												"', base_item = '",
												class2.uint_2,
												"', extra_data = @extra_data",
												class2.uint_0,
												", x = '",
												class2.Int32_0,
												"', y = '",
												class2.Int32_1,
												"', z = '",
												class2.Double_0,
												"', rot = '",
												class2.int_3,
												"', wall_pos = '' WHERE id = '",
												class2.uint_0,
												"' LIMIT 1; "
											}));
										}
									}
								}
								if (num > 0)
								{
									foreach (Class63 class2 in this.hashtable_3.Values)
									{
										if (class2.Boolean_1)
										{
											@class.method_0("extra_data" + class2.uint_0, class2.string_0);
											@class.method_0("pos" + class2.uint_0, class2.string_7);
											stringBuilder.Append(string.Concat(new object[]
											{
												"UPDATE items SET room_id = '",
												this.UInt32_0,
												"', base_item = '",
												class2.uint_2,
												"', extra_data = @extra_data",
												class2.uint_0,
												", x = '0', y = '0', z = '0', rot = '0', wall_pos = @pos",
												class2.uint_0,
												" WHERE id = '",
												class2.uint_0,
												"' LIMIT 1; "
											}));
										}
									}
								}
							}
						}
						this.hashtable_3.Clear();
						lock (this.hashtable_2)
						{
							foreach (Class63 class2 in this.hashtable_2.Values)
							{
								@class.method_0("mextra_data" + class2.uint_0, class2.string_0);
								stringBuilder.Append(string.Concat(new object[]
								{
									"UPDATE items SET x = '",
									class2.Int32_0,
									"', y = '",
									class2.Int32_1,
									"', z = '",
									class2.Double_0,
									"', rot = '",
									class2.int_3,
									"', wall_pos = '",
									class2.string_7,
									"', extra_data = @mextra_data",
									class2.uint_0,
									" WHERE id = '",
									class2.uint_0,
									"' LIMIT 1; "
								}));
							}
						}
						this.hashtable_2.Clear();
						lock (this.method_2())
						{
							foreach (Class15 current in this.method_2())
							{
								if (current.enum3_0 == Enum3.const_2)
								{
									@class.method_0("petname" + current.uint_0, current.string_0);
									@class.method_0("petcolor" + current.uint_0, current.string_2);
									@class.method_0("petrace" + current.uint_0, current.string_1);
									stringBuilder.Append(string.Concat(new object[]
									{
										"INSERT INTO `user_pets` VALUES ('",
										current.uint_0,
										"', '",
										current.uint_1,
										"', '",
										current.uint_3,
										"', @petname",
										current.uint_0,
										", @petrace",
										current.uint_0,
										", @petcolor",
										current.uint_0,
										", '",
										current.uint_2,
										"', '",
										current.int_1,
										"', '",
										current.int_2,
										"', '",
										current.int_3,
										"', '",
										current.int_6,
										"', '",
										current.double_1,
										"', '",
										current.int_4,
										"', '",
										current.int_5,
										"', '",
										current.double_0,
										"'); "
									}));
								}
								else
								{
									if (current.enum3_0 == Enum3.const_1)
									{
										stringBuilder.Append(string.Concat(new object[]
										{
											"UPDATE user_pets SET room_id = '",
											current.uint_3,
											"', expirience = '",
											current.int_1,
											"', energy = '",
											current.int_2,
											"', nutrition = '",
											current.int_3,
											"', respect = '",
											current.int_6,
											"', x = '",
											current.int_4,
											"', y = '",
											current.int_5,
											"', z = '",
											current.double_0,
											"' WHERE id = '",
											current.uint_0,
											"' LIMIT 1; "
										}));
									}
								}
								current.enum3_0 = Enum3.const_0;
							}
						}
						if (stringBuilder.Length > 0)
						{
							@class.method_1(stringBuilder.ToString());
						}
					}
				}
			}
			catch (Exception ex)
			{
				GClass4.smethod_3(string.Concat(new object[]
				{
					"Error during saving furniture for room ",
					this.UInt32_0,
					". Stack: ",
					ex.ToString(),
					"\r Query: ",
					stringBuilder.ToString()
				}));
			}
		}
		internal void method_65(Class6 class6_0)
		{
			try
			{
				Dictionary<uint, bool> dictionary = new Dictionary<uint, bool>();
				StringBuilder stringBuilder = new StringBuilder();
				if (this.list_14.Count > 0)
				{
					foreach (Class63 @class in this.list_14)
					{
						if (@class.string_2 != "" || @class.string_3 != "" || @class.string_4 != "" || @class.string_5 != "" || @class.string_6 != "")
						{
							try
							{
								if (!dictionary.ContainsKey(@class.uint_0))
								{
									if (@class.string_2 != "" || @class.string_3 != "" || @class.string_4 != "" || @class.string_5 != "" || @class.string_6 != "")
									{
										class6_0.method_0(@class.uint_0 + "Extra1", @class.string_2);
										class6_0.method_0(@class.uint_0 + "Extra2", @class.string_3);
										class6_0.method_0(@class.uint_0 + "Extra3", @class.string_4);
										class6_0.method_0(@class.uint_0 + "Extra4", @class.string_5);
										class6_0.method_0(@class.uint_0 + "Extra5", @class.string_6);
										stringBuilder.Append(string.Concat(new object[]
										{
											"DELETE FROM wired_items WHERE item_id = '",
											@class.uint_0,
											"' LIMIT 1; INSERT INTO wired_items (item_id,extra1,extra2,extra3,extra4,extra5) VALUES ('",
											@class.uint_0,
											"',@",
											@class.uint_0,
											"Extra1,@",
											@class.uint_0,
											"Extra2,@",
											@class.uint_0,
											"Extra3,@",
											@class.uint_0,
											"Extra4,@",
											@class.uint_0,
											"Extra5); "
										}));
									}
									dictionary.Add(@class.uint_0, true);
								}
							}
							catch
							{
							}
						}
					}
				}
				if (this.list_15.Count > 0)
				{
					foreach (Class63 @class in this.list_15)
					{
						if (@class.string_2 != "" || @class.string_3 != "" || @class.string_4 != "" || @class.string_5 != "" || @class.string_6 != "")
						{
							try
							{
								if (!dictionary.ContainsKey(@class.uint_0))
								{
									if (@class.string_2 != "" || @class.string_3 != "" || @class.string_4 != "" || @class.string_5 != "" || @class.string_6 != "")
									{
										class6_0.method_0(@class.uint_0 + "Extra1", @class.string_2);
										class6_0.method_0(@class.uint_0 + "Extra2", @class.string_3);
										class6_0.method_0(@class.uint_0 + "Extra3", @class.string_4);
										class6_0.method_0(@class.uint_0 + "Extra4", @class.string_5);
										class6_0.method_0(@class.uint_0 + "Extra5", @class.string_6);
										stringBuilder.Append(string.Concat(new object[]
										{
											"DELETE FROM wired_items WHERE item_id = '",
											@class.uint_0,
											"' LIMIT 1; INSERT INTO wired_items (item_id,extra1,extra2,extra3,extra4,extra5) VALUES ('",
											@class.uint_0,
											"',@",
											@class.uint_0,
											"Extra1,@",
											@class.uint_0,
											"Extra2,@",
											@class.uint_0,
											"Extra3,@",
											@class.uint_0,
											"Extra4,@",
											@class.uint_0,
											"Extra5); "
										}));
									}
									dictionary.Add(@class.uint_0, true);
								}
							}
							catch
							{
							}
						}
					}
				}
				if (this.list_16.Count > 0)
				{
					foreach (Class63 @class in this.list_16)
					{
						if (@class.string_2 != "" || @class.string_3 != "" || @class.string_4 != "" || @class.string_5 != "" || @class.string_6 != "")
						{
							try
							{
								if (!dictionary.ContainsKey(@class.uint_0))
								{
									if (@class.string_2 != "" || @class.string_3 != "" || @class.string_4 != "" || @class.string_5 != "" || @class.string_6 != "")
									{
										class6_0.method_0(@class.uint_0 + "Extra1", @class.string_2);
										class6_0.method_0(@class.uint_0 + "Extra2", @class.string_3);
										class6_0.method_0(@class.uint_0 + "Extra3", @class.string_4);
										class6_0.method_0(@class.uint_0 + "Extra4", @class.string_5);
										class6_0.method_0(@class.uint_0 + "Extra5", @class.string_6);
										stringBuilder.Append(string.Concat(new object[]
										{
											"DELETE FROM wired_items WHERE item_id = '",
											@class.uint_0,
											"' LIMIT 1; INSERT INTO wired_items (item_id,extra1,extra2,extra3,extra4,extra5) VALUES ('",
											@class.uint_0,
											"',@",
											@class.uint_0,
											"Extra1,@",
											@class.uint_0,
											"Extra2,@",
											@class.uint_0,
											"Extra3,@",
											@class.uint_0,
											"Extra4,@",
											@class.uint_0,
											"Extra5); "
										}));
									}
									dictionary.Add(@class.uint_0, true);
								}
							}
							catch
							{
							}
						}
					}
				}
				dictionary.Clear();
				if (this.hashtable_3.Count > 0 || this.hashtable_1.Count > 0 || this.hashtable_2.Count > 0 || this.Boolean_4)
				{
					foreach (Class63 @class in this.hashtable_1.Values)
					{
						stringBuilder.Append(string.Concat(new object[]
						{
							"UPDATE items SET room_id = 0 WHERE id = '",
							@class.uint_0,
							"' AND room_id = '",
							this.UInt32_0,
							"' LIMIT 1; "
						}));
					}
					this.hashtable_1.Clear();
					IEnumerator enumerator2;
					if (this.hashtable_3.Count > 0)
					{
						enumerator2 = this.hashtable_3.Values.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Class63 @class = (Class63)enumerator2.Current;
								stringBuilder.Append("UPDATE items SET room_id = 0 WHERE id = '" + @class.uint_0 + "' LIMIT 1; ");
							}
						}
						finally
						{
							IDisposable disposable = enumerator2 as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
						int num = 0;
						int num2 = 0;
						enumerator2 = this.hashtable_3.Values.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								Class63 @class = (Class63)enumerator2.Current;
								if (@class.Boolean_2)
								{
									num2++;
								}
								else
								{
									num++;
								}
							}
						}
						finally
						{
							IDisposable disposable = enumerator2 as IDisposable;
							if (disposable != null)
							{
								disposable.Dispose();
							}
						}
						if (num2 > 0)
						{
							enumerator2 = this.hashtable_3.Values.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									Class63 @class = (Class63)enumerator2.Current;
									if (@class.Boolean_2)
									{
										class6_0.method_0("extra_data" + @class.uint_0, @class.string_0);
										stringBuilder.Append(string.Concat(new object[]
										{
											"UPDATE items SET room_id = '",
											this.UInt32_0,
											"', base_item = '",
											@class.uint_2,
											"', extra_data = @extra_data",
											@class.uint_0,
											", x = '",
											@class.Int32_0,
											"', y = '",
											@class.Int32_1,
											"', z = '",
											@class.Double_0,
											"', rot = '",
											@class.int_3,
											"', wall_pos = '' WHERE id = '",
											@class.uint_0,
											"' LIMIT 1; "
										}));
									}
								}
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
						if (num > 0)
						{
							enumerator2 = this.hashtable_3.Values.GetEnumerator();
							try
							{
								while (enumerator2.MoveNext())
								{
									Class63 @class = (Class63)enumerator2.Current;
									if (@class.Boolean_1)
									{
										class6_0.method_0("extra_data" + @class.uint_0, @class.string_0);
										class6_0.method_0("pos" + @class.uint_0, @class.string_7);
										stringBuilder.Append(string.Concat(new object[]
										{
											"UPDATE items SET room_id = '",
											this.UInt32_0,
											"', base_item = '",
											@class.uint_2,
											"', extra_data = @extra_data",
											@class.uint_0,
											", x = '0', y = '0', z = '0', rot = '0', wall_pos = @pos",
											@class.uint_0,
											" WHERE id = '",
											@class.uint_0,
											"' LIMIT 1; "
										}));
									}
								}
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
						this.hashtable_3.Clear();
					}
					enumerator2 = this.hashtable_2.Values.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							Class63 @class = (Class63)enumerator2.Current;
							stringBuilder.Append(string.Concat(new object[]
							{
								"UPDATE items SET x = '",
								@class.Int32_0,
								"', y = '",
								@class.Int32_1,
								"', z = '",
								@class.Double_0,
								"', rot = '",
								@class.int_3,
								"', wall_pos = '' WHERE id = '",
								@class.uint_0,
								"' LIMIT 1; "
							}));
						}
					}
					finally
					{
						IDisposable disposable = enumerator2 as IDisposable;
						if (disposable != null)
						{
							disposable.Dispose();
						}
					}
					this.hashtable_2.Clear();
					foreach (Class15 current in this.method_2())
					{
						if (current.enum3_0 == Enum3.const_2)
						{
							class6_0.method_0("petname" + current.uint_0, current.string_0);
							class6_0.method_0("petcolor" + current.uint_0, current.string_2);
							class6_0.method_0("petrace" + current.uint_0, current.string_1);
							stringBuilder.Append(string.Concat(new object[]
							{
								"INSERT INTO `user_pets` VALUES ('",
								current.uint_0,
								"', '",
								current.uint_1,
								"', '",
								current.uint_3,
								"', @petname",
								current.uint_0,
								", @petrace",
								current.uint_0,
								", @petcolor",
								current.uint_0,
								", '",
								current.uint_2,
								"', '",
								current.int_1,
								"', '",
								current.int_2,
								"', '",
								current.int_3,
								"', '",
								current.int_6,
								"', '",
								current.double_1,
								"', '",
								current.int_4,
								"', '",
								current.int_5,
								"', '",
								current.double_0,
								"');"
							}));
						}
						else
						{
							if (current.enum3_0 == Enum3.const_1)
							{
								stringBuilder.Append(string.Concat(new object[]
								{
									"UPDATE user_pets SET room_id = '",
									current.uint_3,
									"', expirience = '",
									current.int_1,
									"', energy = '",
									current.int_2,
									"', nutrition = '",
									current.int_3,
									"', respect = '",
									current.int_6,
									"', x = '",
									current.int_4,
									"', y = '",
									current.int_5,
									"', z = '",
									current.double_0,
									"' WHERE id = '",
									current.uint_0,
									"' LIMIT 1; "
								}));
							}
						}
						current.enum3_0 = Enum3.const_0;
					}
				}
				if (stringBuilder.Length > 0)
				{
					class6_0.method_1(stringBuilder.ToString());
				}
			}
			catch (Exception ex)
			{
				GClass4.smethod_3(string.Concat(new object[]
				{
					"Error during saving furniture for room ",
					this.UInt32_0,
					". Stack: ",
					ex.ToString()
				}));
			}
		}
		private void method_66(bool bool_13)
		{
			if (!this.bool_12)
			{
				this.bool_12 = true;
				if (bool_13)
				{
					this.bool_11 = false;
					if (this.timer_0 != null)
					{
						this.bool_6 = true;
						this.timer_0.Change(-1, -1);
					}
					this.method_64();
					using (Class6 @class = Phoenix.smethod_12().method_0())
					{
						@class.method_1(string.Concat(new object[]
						{
							"UPDATE user_pets SET room_id = 0 WHERE room_id = ",
							this.uint_0,
							" AND NOT user_id = ",
							Phoenix.smethod_15().method_2().method_27(this.string_3)
						}));
					}
					this.timer_0.Dispose();
					this.timer_0 = null;
					this.bool_9 = false;
					if (this.list_0 != null)
					{
						this.list_0.Clear();
					}
					this.list_0 = null;
					if (this.class33_0 != null)
					{
						Array.Clear(this.class33_0, 0, this.class33_0.Length);
					}
					this.class33_0 = null;
					this.class29_0 = null;
					if (this.list_1 != null)
					{
						this.list_1.Clear();
					}
					this.class29_0 = null;
					if (this.dictionary_0 != null)
					{
						this.dictionary_0.Clear();
					}
					this.dictionary_0 = null;
					this.string_7 = null;
					this.string_8 = null;
					this.string_9 = null;
					if (this.hashtable_0 != null)
					{
						this.hashtable_0.Clear();
					}
					this.hashtable_0 = null;
					if (this.hashtable_4 != null)
					{
						this.hashtable_4.Clear();
					}
					this.hashtable_4 = null;
					this.class67_0 = null;
					if (this.list_2 != null)
					{
						this.list_2.Clear();
					}
					this.list_2 = null;
				}
			}
		}
		public GClass5 method_67(bool bool_13)
		{
			List<Class33> list = new List<Class33>();
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null)
				{
					if (!bool_13)
					{
						if (!@class.bool_7)
						{
							goto IL_35;
						}
						@class.bool_7 = false;
					}
					list.Add(@class);
				}
				IL_35:;
			}
			GClass5 result;
			if (list.Count == 0)
			{
				result = null;
			}
			else
			{
				GClass5 gClass = new GClass5(34u);
				gClass.method_9(list.Count);
				foreach (Class33 @class in list)
				{
					@class.method_15(gClass);
				}
				result = gClass;
			}
			return result;
		}
		public bool method_68(uint uint_2)
		{
			return this.dictionary_0.ContainsKey(uint_2);
		}
		public void method_69(uint uint_2)
		{
			this.dictionary_0.Remove(uint_2);
		}
		public void method_70(uint uint_2)
		{
			this.dictionary_0.Add(uint_2, Phoenix.smethod_6());
		}
		public bool method_71(uint uint_2)
		{
			bool result;
			if (!this.method_68(uint_2))
			{
				result = true;
			}
			else
			{
				double num = Phoenix.smethod_6() - this.dictionary_0[uint_2];
				result = (num > 900.0);
			}
			return result;
		}
		public int method_72(string string_10)
		{
			int num = 0;
			foreach (Class63 @class in this.Hashtable_1.Values)
			{
				if (@class.method_7().string_2.ToLower() == string_10.ToLower())
				{
					num++;
				}
			}
			foreach (Class63 @class in this.Hashtable_0.Values)
			{
				if (@class.method_7().string_2.ToLower() == string_10.ToLower())
				{
					num++;
				}
			}
			return num;
		}
		public bool method_73(Class33 class33_1)
		{
			return !class33_1.Boolean_4 && this.method_74(class33_1.method_16().method_2().uint_0);
		}
		public bool method_74(uint uint_2)
		{
			bool result;
			using (GStruct0.smethod_0(this.list_2))
			{
				foreach (Class64 current in this.list_2)
				{
					if (current.method_0(uint_2))
					{
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}
		public Class64 method_75(Class33 class33_1)
		{
			Class64 result;
			if (class33_1.Boolean_4)
			{
				result = null;
			}
			else
			{
				result = this.method_76(class33_1.method_16().method_2().uint_0);
			}
			return result;
		}
		public Class64 method_76(uint uint_2)
		{
			Class64 result;
			using (GStruct0.smethod_0(this.list_2))
			{
				foreach (Class64 current in this.list_2)
				{
					if (current.method_0(uint_2))
					{
						result = current;
						return result;
					}
				}
			}
			result = null;
			return result;
		}
		public void method_77(Class33 class33_1, Class33 class33_2)
		{
			if (class33_1 != null && class33_2 != null && (!class33_1.Boolean_4 || class33_1.class34_0.Boolean_1) && (!class33_2.Boolean_4 || class33_2.class34_0.Boolean_1) && !class33_1.Boolean_3 && !class33_2.Boolean_3 && !this.method_73(class33_1) && !this.method_73(class33_2))
			{
				this.list_2.Add(new Class64(class33_1.method_16().method_2().uint_0, class33_2.method_16().method_2().uint_0, this.UInt32_0));
			}
		}
		public void method_78(uint uint_2)
		{
			Class64 @class = this.method_76(uint_2);
			if (@class != null)
			{
				@class.method_12(uint_2);
				this.list_2.Remove(@class);
			}
		}
		public bool method_79(Class16 class16_0, Class63 class63_0, int int_17, int int_18, int int_19, bool bool_13, bool bool_14, bool bool_15)
		{
			Dictionary<int, GClass10> dictionary = this.method_94(class63_0.method_7().int_2, class63_0.method_7().int_1, int_17, int_18, int_19);
			bool result;
			if (!this.method_92(int_17, int_18))
			{
				result = false;
			}
			else
			{
				foreach (GClass10 current in dictionary.Values)
				{
					if (!this.method_92(current.Int32_0, current.Int32_1))
					{
						result = false;
						return result;
					}
				}
				double num = this.Class28_0.double_1[int_17, int_18];
				if (!bool_14)
				{
					if (class63_0.int_3 == int_19 && class63_0.Int32_0 == int_17 && class63_0.Int32_1 == int_18 && class63_0.Double_0 != num)
					{
						result = false;
						return result;
					}
					if (this.Class28_0.genum0_0[int_17, int_18] != GEnum0.const_0)
					{
						result = false;
						return result;
					}
					foreach (GClass10 current in dictionary.Values)
					{
						if (this.Class28_0.genum0_0[current.Int32_0, current.Int32_1] != GEnum0.const_0)
						{
							result = false;
							return result;
						}
					}
					if (class63_0.method_7().bool_2 || class63_0.Boolean_0)
					{
						goto IL_1FE;
					}
					if (this.method_97(int_17, int_18))
					{
						result = false;
						return result;
					}
					using (Dictionary<int, GClass10>.ValueCollection.Enumerator enumerator = dictionary.Values.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							GClass10 current = enumerator.Current;
							if (this.method_97(current.Int32_0, current.Int32_1))
							{
								result = false;
								return result;
							}
						}
						goto IL_1FE;
					}
				}
				if (this.Class28_0.genum0_0[int_17, int_18] != GEnum0.const_0)
				{
					result = false;
					return result;
				}
				if (!bool_15 && this.method_97(int_17, int_18))
				{
					result = false;
					return result;
				}
				IL_1FE:
				List<Class63> list = this.method_93(int_17, int_18);
				List<Class63> list2 = new List<Class63>();
				List<Class63> list3 = new List<Class63>();
				foreach (GClass10 current in dictionary.Values)
                {
                    List<Class63> list4 = this.method_93(current.Int32_0, current.Int32_1);
					if (list4 != null)
					{
						list2.AddRange(list4);
					}
				}
				if (list == null)
				{
					list = new List<Class63>();
				}
				list3.AddRange(list);
				list3.AddRange(list2);
				int num2 = 0;
				foreach (Class63 current2 in list3)
				{
					if (current2 != null && current2.uint_0 != class63_0.uint_0 && current2.method_7() != null)
					{
						if (!current2.method_7().bool_0)
						{
							result = false;
							return result;
						}
						if (class63_0.method_7().string_2.ToLower() == "wf_trg_timer" && current2.method_7().string_2.ToLower() == "wf_trg_timer")
						{
							result = false;
							return result;
						}
						if (class63_0.method_7().string_2.ToLower() == "ball")
						{
							if (current2.method_7().string_2.ToLower() == "blue_goal")
							{
								num2 = 11;
							}
							if (current2.method_7().string_2.ToLower() == "red_goal")
							{
								num2 = 5;
							}
							if (current2.method_7().string_2.ToLower() == "yellow_goal")
							{
								num2 = 14;
							}
							if (current2.method_7().string_2.ToLower() == "green_goal")
							{
								num2 = 8;
							}
						}
					}
				}
				if (num2 > 0)
				{
					this.method_89(num2, class63_0, false);
				}
				if (!class63_0.Boolean_0)
				{
					if (class63_0.int_3 != int_19 && class63_0.Int32_0 == int_17 && class63_0.Int32_1 == int_18)
					{
						num = class63_0.Double_0;
					}
					foreach (Class63 current2 in list3)
					{
						if (current2.uint_0 != class63_0.uint_0 && current2.Double_1 > num)
						{
							num = current2.Double_1;
						}
					}
				}
				if (int_19 != 0 && int_19 != 2 && int_19 != 4 && int_19 != 6 && int_19 != 8)
				{
					int_19 = 0;
				}
				Dictionary<int, GClass10> dictionary2 = new Dictionary<int, GClass10>();
				dictionary2 = this.method_94(class63_0.method_7().int_2, class63_0.method_7().int_1, class63_0.Int32_0, class63_0.Int32_1, class63_0.int_3);
				int num3 = 0;
				int num4 = 0;
				if (!bool_13)
				{
					num3 = class63_0.Int32_0;
					num4 = class63_0.Int32_1;
				}
				class63_0.int_3 = int_19;
				class63_0.method_0(int_17, int_18, num);
				if (!bool_14 && class16_0 != null)
				{
					class63_0.Class69_0.vmethod_0(class16_0, class63_0);
				}
				if (bool_13)
				{
					if (this.hashtable_1.Contains(class63_0.uint_0))
					{
						this.hashtable_1.Remove(class63_0.uint_0);
					}
					if (this.hashtable_3.Contains(class63_0.uint_0))
					{
						result = false;
						return result;
					}
					this.hashtable_3.Add(class63_0.uint_0, class63_0);
					if (class63_0.Boolean_2)
					{
						if (this.hashtable_0.Contains(class63_0.uint_0))
						{
							this.hashtable_0.Remove(class63_0.uint_0);
						}
						this.hashtable_0.Add(class63_0.uint_0, class63_0);
					}
					else
					{
						if (this.hashtable_4.Contains(class63_0.uint_0))
						{
							this.hashtable_4.Remove(class63_0.uint_0);
						}
						this.hashtable_4.Add(class63_0.uint_0, class63_0);
					}
					GClass5 gclass5_ = new GClass5(93u);
					class63_0.method_6(gclass5_);
					this.method_59(gclass5_, null);
					string text = class63_0.method_7().string_2.ToLower();
					switch (text)
					{
					case "bb_patch":
						this.list_5.Add(class63_0);
						if (class63_0.string_0 == "5")
						{
							this.list_6.Add(class63_0);
						}
						else
						{
							if (class63_0.string_0 == "8")
							{
								this.list_7.Add(class63_0);
							}
							else
							{
								if (class63_0.string_0 == "11")
								{
									this.list_9.Add(class63_0);
								}
								else
								{
									if (class63_0.string_0 == "14")
									{
										this.list_8.Add(class63_0);
									}
								}
							}
						}
						break;
					case "blue_score":
						this.list_12.Add(class63_0);
						break;
					case "green_score":
						this.list_13.Add(class63_0);
						break;
					case "red_score":
						this.list_10.Add(class63_0);
						break;
					case "yellow_score":
						this.list_11.Add(class63_0);
						break;
					case "stickiepole":
						this.list_3.Add(class63_0);
						break;
					case "wf_trg_onsay":
					case "wf_trg_enterroom":
					case "wf_trg_furnistate":
					case "wf_trg_onfurni":
					case "wf_trg_offfurni":
					case "wf_trg_gameend":
					case "wf_trg_gamestart":
					case "wf_trg_attime":
					case "wf_trg_atscore":
						if (!this.list_14.Contains(class63_0))
						{
							this.list_14.Add(class63_0);
						}
						break;
					case "wf_trg_timer":
						if (class63_0.string_2.Length <= 0)
						{
							class63_0.string_2 = "10";
						}
						if (!this.list_14.Contains(class63_0))
						{
							this.list_14.Add(class63_0);
						}
						class63_0.bool_0 = true;
						class63_0.method_3(1);
						break;
					case "wf_act_saymsg":
					case "wf_act_moveuser":
					case "wf_act_togglefurni":
					case "wf_act_givepoints":
					case "wf_act_moverotate":
					case "wf_act_matchfurni":
					case "wf_act_give_phx":
						if (!this.list_15.Contains(class63_0))
						{
							this.list_15.Add(class63_0);
						}
						break;
					case "wf_cnd_trggrer_on_frn":
					case "wf_cnd_furnis_hv_avtrs":
					case "wf_cnd_has_furni_on":
					case "wf_cnd_phx":
						if (!this.list_16.Contains(class63_0))
						{
							this.list_16.Add(class63_0);
						}
						break;
					}
				}
				else
				{
					if (!this.hashtable_2.Contains(class63_0.uint_0) && !this.hashtable_3.ContainsKey(class63_0.uint_0))
					{
						this.hashtable_2.Add(class63_0.uint_0, class63_0);
					}
					if (class63_0.method_7().string_2.ToLower() == "wf_act_give_phx" && class16_0 != null)
					{
						string text2 = class63_0.string_2.Split(new char[]
						{
							':'
						})[0].ToLower();
						if (!Phoenix.smethod_15().method_4().method_12(text2, class16_0))
						{
							class63_0.string_2 = "";
						}
					}
					if (class63_0.method_7().string_2.ToLower() == "wf_cnd_phx" && class16_0 != null)
					{
						string text2 = class63_0.string_2.Split(new char[]
						{
							':'
						})[0].ToLower();
						if (!Phoenix.smethod_15().method_4().method_11(text2, class16_0))
						{
							class63_0.string_2 = "";
						}
					}
					GClass5 gclass5_ = new GClass5(95u);
					class63_0.method_6(gclass5_);
					this.method_59(gclass5_, null);
				}
				this.method_22();
				if (!bool_14)
				{
					this.method_87(this.method_43(int_17, int_18), true, true);
					foreach (GClass10 current in dictionary.Values)
					{
						this.method_87(this.method_43(current.Int32_0, current.Int32_1), true, true);
					}
					if (num3 > 0 || num4 > 0)
					{
						this.method_87(this.method_43(num3, num4), true, true);
					}
					foreach (GClass10 current in dictionary2.Values)
					{
						this.method_87(this.method_43(current.Int32_0, current.Int32_1), true, true);
					}
				}
				result = true;
			}
			return result;
		}
		internal void method_80(Class63 class63_0)
		{
			if (!this.hashtable_2.Contains(class63_0.uint_0) && !this.hashtable_3.ContainsKey(class63_0.uint_0))
			{
				this.hashtable_2.Add(class63_0.uint_0, class63_0);
			}
		}
		public bool method_81(Class63 class63_0, int int_17, int int_18, double double_3)
		{
			Dictionary<int, GClass10> dictionary = this.method_94(class63_0.method_7().int_2, class63_0.method_7().int_1, int_17, int_18, class63_0.int_3);
			class63_0.method_0(int_17, int_18, double_3);
			if (!this.hashtable_2.Contains(class63_0.uint_0))
			{
				this.hashtable_2.Add(class63_0.uint_0, class63_0);
			}
			this.method_22();
			this.method_87(this.method_43(int_17, int_18), true, true);
			foreach (GClass10 current in dictionary.Values)
			{
				this.method_87(this.method_43(current.Int32_0, current.Int32_1), true, true);
			}
			return true;
		}
		public bool method_82(Class16 class16_0, Class63 class63_0, bool bool_13, string string_10)
		{
			if (bool_13)
			{
				class63_0.Class69_0.vmethod_0(class16_0, class63_0);
				string text = class63_0.method_7().string_2.ToLower();
				if (text != null && text == "dimmer" && this.class67_0 == null)
				{
					this.class67_0 = new Class67(class63_0.uint_0);
					class63_0.string_0 = this.class67_0.method_7();
				}
				if (!this.hashtable_3.ContainsKey(class63_0.uint_0))
				{
					this.hashtable_3.Add(class63_0.uint_0, class63_0);
					if (class63_0.Boolean_2)
					{
						this.hashtable_0.Add(class63_0.uint_0, class63_0);
					}
					else
					{
						if (!this.hashtable_4.Contains(class63_0.uint_0))
						{
							this.hashtable_4.Add(class63_0.uint_0, class63_0);
						}
					}
				}
				GClass5 gclass5_ = new GClass5(83u);
				class63_0.method_6(gclass5_);
				this.method_59(gclass5_, null);
			}
			else
			{
				if (!this.hashtable_2.Contains(class63_0.uint_0))
				{
					this.hashtable_2.Add(class63_0.uint_0, class63_0);
				}
			}
			if (!bool_13)
			{
				class63_0.string_7 = string_10;
				GClass5 gclass5_ = new GClass5(85u);
				class63_0.method_6(gclass5_);
				this.method_59(gclass5_, null);
			}
			return true;
		}
		public void method_83()
		{
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null)
				{
					this.method_87(@class, true, true);
				}
			}
		}
		public double method_84(int int_17, int int_18, List<Class63> list_18)
		{
			double result;
			try
			{
				bool flag = false;
				if (this.double_2[int_17, int_18] != 0.0)
				{
					flag = true;
				}
				double num = 0.0;
				bool flag2 = false;
				double num2 = 0.0;
				if (list_18 == null)
				{
					list_18 = new List<Class63>();
				}
				if (list_18 != null)
				{
					foreach (Class63 current in list_18)
					{
						if ((current.method_7().bool_2 || current.method_7().string_2.ToLower() == "bed") && flag)
						{
							result = current.Double_0;
							return result;
						}
						if (current.Double_1 > num)
						{
							if (current.method_7().bool_2 || current.method_7().string_2.ToLower() == "bed")
							{
								if (flag)
								{
									result = current.Double_0;
									return result;
								}
								flag2 = true;
								num2 = current.method_7().double_0;
							}
							else
							{
								flag2 = false;
							}
							num = current.Double_1;
						}
					}
				}
				double num3 = this.Class28_0.double_1[int_17, int_18];
				double num4 = num - this.Class28_0.double_1[int_17, int_18];
				if (flag2)
				{
					num4 -= num2;
				}
				if (num4 < 0.0)
				{
					num4 = 0.0;
				}
				result = num3 + num4;
			}
			catch
			{
				result = 0.0;
			}
			return result;
		}
		public void method_85(Class33 class33_1)
		{
			List<Class63> list = this.method_93(class33_1.int_3, class33_1.int_4);
			foreach (Class63 current in list)
			{
				this.method_12(class33_1, current);
				if (current.method_7().string_2.ToLower() == "pressure_pad")
				{
					current.string_0 = "0";
					current.method_5(false, true);
				}
			}
			this.byte_0[class33_1.int_3, class33_1.int_4] = 1;
		}
		public void method_86(Class33 class33_1)
		{
			List<Class63> list = this.method_93(class33_1.int_3, class33_1.int_4);
			foreach (Class63 current in list)
			{
				string text = current.method_7().string_2.ToLower();
				if (text != null)
				{
					if (!(text == "pressure_pad"))
					{
						if (text == "fbgate" && (!string.IsNullOrEmpty(current.string_2) || !string.IsNullOrEmpty(current.string_3)))
						{
							class33_1 = this.method_43(current.GStruct1_0.int_0, current.GStruct1_0.int_1);
							if (class33_1 != null && !class33_1.Boolean_4 && current.string_2 != null && current.string_3 != null)
							{
								string a = class33_1.method_16().method_2().string_6;
								if (a == "m")
								{
									Class98.smethod_1(class33_1, current.string_2);
								}
								else
								{
									Class98.smethod_1(class33_1, current.string_3);
								}
								GClass5 gClass = new GClass5(266u);
								gClass.method_9(class33_1.int_0);
								gClass.method_7(class33_1.method_16().method_2().string_5);
								gClass.method_7(class33_1.method_16().method_2().string_6.ToLower());
								gClass.method_7(class33_1.method_16().method_2().string_4);
								gClass.method_9(class33_1.method_16().method_2().int_13);
								gClass.method_7("");
								this.method_59(gClass, null);
							}
						}
					}
					else
					{
						current.string_0 = "1";
						current.method_5(false, true);
					}
				}
			}
		}
		public void method_87(Class33 class33_1, bool bool_13, bool bool_14)
		{
			int num = 0;
			try
			{
				if (class33_1 != null)
				{
					num = 1;
					if (class33_1.Boolean_0)
					{
						class33_1.class15_0.int_4 = class33_1.int_3;
						class33_1.class15_0.int_5 = class33_1.int_4;
						class33_1.class15_0.double_0 = class33_1.double_0;
					}
					else
					{
						if (class33_1.Boolean_4)
						{
							class33_1.class34_0.int_1 = class33_1.int_3;
							class33_1.class34_0.int_2 = class33_1.int_4;
							class33_1.class34_0.double_0 = class33_1.double_0;
						}
						else
						{
							if (class33_1.class34_1 != null && class33_1.class33_0 != null)
							{
								return;
							}
						}
					}
					num = 2;
					if (!class33_1.bool_12)
					{
						class33_1.bool_7 = false;
					}
					else
					{
						num = 3;
						if (bool_13)
						{
							num = 4;
							if (class33_1.byte_1 > 0)
							{
								num = 5;
								if (class33_1.Boolean_4)
								{
									if (this.byte_1[class33_1.int_3, class33_1.int_4] == 0)
									{
										class33_1.class34_0.int_0 = -1;
										class33_1.byte_1 = 0;
									}
								}
								else
								{
									num = 6;
									if ((class33_1.method_16().method_2().string_6.ToLower() == "m" && this.byte_1[class33_1.int_3, class33_1.int_4] == 0) || (class33_1.method_16().method_2().string_6.ToLower() == "f" && this.byte_2[class33_1.int_3, class33_1.int_4] == 0))
									{
										class33_1.method_16().method_2().method_24().method_2(-1, true);
										class33_1.byte_1 = 0;
									}
								}
							}
							num = 7;
							if (class33_1.dictionary_0.ContainsKey("lay") || class33_1.dictionary_0.ContainsKey("sit"))
							{
								class33_1.dictionary_0.Remove("lay");
								class33_1.dictionary_0.Remove("sit");
								class33_1.bool_7 = true;
							}
							List<Class63> list = this.method_93(class33_1.int_3, class33_1.int_4);
							double num2 = this.method_84(class33_1.int_3, class33_1.int_4, list);
							if (num2 != class33_1.double_0)
							{
								class33_1.double_0 = num2;
								class33_1.bool_7 = true;
							}
							num = 8;
							if (this.Class28_0.genum0_0[class33_1.int_3, class33_1.int_4] == GEnum0.const_2)
							{
								if (!class33_1.dictionary_0.ContainsKey("sit"))
								{
									class33_1.dictionary_0.Add("sit", "1.0");
									if (class33_1.byte_1 > 0)
									{
										if (!class33_1.Boolean_4)
										{
											class33_1.method_16().method_2().method_24().method_2(-1, true);
										}
										else
										{
											class33_1.class34_0.int_0 = -1;
										}
										class33_1.byte_1 = 0;
									}
								}
								num = 9;
								class33_1.double_0 = this.Class28_0.double_1[class33_1.int_3, class33_1.int_4];
								class33_1.int_7 = this.Class28_0.int_3[class33_1.int_3, class33_1.int_4];
								class33_1.int_8 = this.Class28_0.int_3[class33_1.int_3, class33_1.int_4];
								if (class33_1.Boolean_4 && class33_1.class34_0.class33_0 != null)
								{
									class33_1.class34_0.class33_0.double_0 = class33_1.double_0 + 1.0;
									class33_1.class34_0.class33_0.int_7 = class33_1.int_7;
									class33_1.class34_0.class33_0.int_8 = class33_1.int_8;
								}
								class33_1.bool_7 = true;
							}
							if (list.Count < 1 && this.list_4.Contains(class33_1.uint_0))
							{
								class33_1.method_16().method_2().method_24().method_2(-1, false);
								this.list_4.Remove(class33_1.uint_0);
								class33_1.int_14 = 0;
								class33_1.bool_7 = true;
							}
							num = 10;
							lock (list)
							{
								foreach (Class63 current in list)
								{
									num = 11;
									if (current.method_7().bool_2 && (!class33_1.Boolean_0 || class33_1.class34_0.class33_0 == null))
									{
										if (!class33_1.dictionary_0.ContainsKey("sit"))
										{
											double num3;
											try
											{
												if (current.method_7().list_0.Count > 1)
												{
													num3 = current.method_7().list_0[(int)Convert.ToInt16(current.string_0)];
												}
												else
												{
													num3 = current.method_7().double_0;
												}
												goto IL_BCA;
											}
											catch
											{
												num3 = current.method_7().double_0;
												goto IL_BCA;
											}
											IL_51B:
											if (class33_1.byte_1 > 0)
											{
												if (!class33_1.Boolean_4)
												{
													class33_1.method_16().method_2().method_24().method_2(-1, true);
												}
												else
												{
													class33_1.class34_0.int_0 = -1;
												}
												class33_1.byte_1 = 0;
												goto IL_55D;
											}
											goto IL_55D;
											IL_BCA:
											if (class33_1.dictionary_0.ContainsKey("sit"))
											{
												goto IL_51B;
											}
											class33_1.dictionary_0.Add("sit", num3.ToString().Replace(',', '.'));
											goto IL_51B;
										}
										IL_55D:
										class33_1.double_0 = current.Double_0;
										class33_1.int_7 = current.int_3;
										class33_1.int_8 = current.int_3;
										if (class33_1.Boolean_4 && class33_1.class34_0.class33_0 != null)
										{
											class33_1.class34_0.class33_0.double_0 = class33_1.double_0 + 1.0;
											class33_1.class34_0.class33_0.int_7 = class33_1.int_7;
											class33_1.class34_0.class33_0.int_8 = class33_1.int_8;
										}
										class33_1.bool_7 = true;
									}
									num = 12;
									if (current.method_7().string_2.ToLower() == "bed")
									{
										if (!class33_1.dictionary_0.ContainsKey("lay"))
										{
											double num3;
											try
											{
												if (current.method_7().list_0.Count > 1)
												{
													num3 = current.method_7().list_0[(int)Convert.ToInt16(current.string_0)];
												}
												else
												{
													num3 = current.method_7().double_0;
												}
											}
											catch
											{
												num3 = current.method_7().double_0;
											}
											if (!class33_1.dictionary_0.ContainsKey("lay"))
											{
												class33_1.dictionary_0.Add("lay", num3.ToString().Replace(',', '.') + " null");
											}
											if (class33_1.byte_1 > 0)
											{
												if (!class33_1.Boolean_4)
												{
													class33_1.method_16().method_2().method_24().method_2(-1, true);
												}
												else
												{
													class33_1.class34_0.int_0 = -1;
												}
												class33_1.byte_1 = 0;
											}
										}
										class33_1.double_0 = current.Double_0;
										class33_1.int_7 = current.int_3;
										class33_1.int_8 = current.int_3;
										if (class33_1.Boolean_4 && class33_1.class34_0.class33_0 != null)
										{
											class33_1.class34_0.class33_0.double_0 = class33_1.double_0 + 1.0;
											class33_1.class34_0.class33_0.int_7 = class33_1.int_7;
											class33_1.class34_0.class33_0.int_8 = class33_1.int_8;
										}
										class33_1.bool_7 = true;
									}
									num = 13;
									if (current.method_7().string_2.ToLower().IndexOf("bb_") > -1 && !class33_1.Boolean_4)
									{
										if (current.method_7().string_2.ToLower().IndexOf("_gate") > -1)
										{
											int num4 = 0;
											int num5 = 0;
											if (current.method_7().string_2.ToLower() == "bb_yellow_gate")
											{
												num5 = 12;
												num4 = 36;
											}
											else
											{
												if (current.method_7().string_2.ToLower() == "bb_red_gate")
												{
													num5 = 3;
													num4 = 33;
												}
												else
												{
													if (current.method_7().string_2.ToLower() == "bb_green_gate")
													{
														num5 = 6;
														num4 = 34;
													}
													else
													{
														if (current.method_7().string_2.ToLower() == "bb_blue_gate")
														{
															num5 = 9;
															num4 = 35;
														}
													}
												}
											}
											if (!this.list_4.Contains(class33_1.uint_0))
											{
												class33_1.method_16().method_2().method_24().method_2(num4, true);
												class33_1.bool_7 = true;
												class33_1.int_14 = num5;
												this.list_4.Add(class33_1.uint_0);
											}
											else
											{
												class33_1.method_16().method_2().method_24().method_2(-1, false);
												class33_1.bool_7 = true;
												class33_1.int_14 = 0;
												this.list_4.Remove(class33_1.uint_0);
											}
										}
										if (current.method_7().string_2.ToLower() == "bb_teleport")
										{
											this.method_91(current, class33_1);
										}
										if (current.method_7().string_2.ToLower() == "bb_patch" && class33_1.int_14 > 0 && class33_1.bool_6 && current.string_0 != "14" && current.string_0 != "5" && current.string_0 != "8" && current.string_0 != "11" && current.string_0 != "1")
										{
											if (current.string_0 == "0" || current.string_0 == "")
											{
												current.string_0 = Convert.ToString(class33_1.int_14);
											}
											else
											{
												if (Convert.ToInt32(current.string_0) > 0)
												{
													if (class33_1.int_14 == 12 && (current.string_0 == "12" || current.string_0 == "13"))
													{
														current.string_0 = Convert.ToString(Convert.ToInt32(current.string_0) + 1);
													}
													else
													{
														if (class33_1.int_14 == 3 && (current.string_0 == "3" || current.string_0 == "4"))
														{
															current.string_0 = Convert.ToString(Convert.ToInt32(current.string_0) + 1);
														}
														else
														{
															if (class33_1.int_14 == 6 && (current.string_0 == "6" || current.string_0 == "7"))
															{
																current.string_0 = Convert.ToString(Convert.ToInt32(current.string_0) + 1);
															}
															else
															{
																if (class33_1.int_14 == 9 && (current.string_0 == "9" || current.string_0 == "10"))
																{
																	current.string_0 = Convert.ToString(Convert.ToInt32(current.string_0) + 1);
																}
																else
																{
																	current.string_0 = Convert.ToString(class33_1.int_14);
																}
															}
														}
													}
												}
											}
											this.method_89(class33_1.int_14 + 2, current, false);
											current.method_5(true, true);
										}
									}
								}
								goto IL_1155;
							}
						}
						num = 14;
						List<Class63> list2 = this.method_93(class33_1.int_12, class33_1.int_13);
						lock (list2)
						{
							foreach (Class63 current in list2)
							{
								if (this.double_0[current.Int32_0, current.Int32_1] <= current.Double_0)
								{
									if (bool_14)
									{
										this.method_11(class33_1, current);
									}
									if (current.method_7().string_2.ToLower() == "pressure_pad")
									{
										current.string_0 = "1";
										current.method_5(false, true);
									}
									num = 15;
									if (current.method_7().string_2.ToLower() == "fbgate" && (!string.IsNullOrEmpty(current.string_2) || !string.IsNullOrEmpty(current.string_3)) && class33_1 != null && !class33_1.Boolean_4)
									{
										if (class33_1.string_0 != "")
										{
											class33_1.method_16().method_2().string_5 = class33_1.string_0;
											class33_1.string_0 = "";
											GClass5 gClass = new GClass5(266u);
											gClass.method_9(class33_1.int_0);
											gClass.method_7(class33_1.method_16().method_2().string_5);
											gClass.method_7(class33_1.method_16().method_2().string_6.ToLower());
											gClass.method_7(class33_1.method_16().method_2().string_4);
											gClass.method_9(class33_1.method_16().method_2().int_13);
											gClass.method_7("");
											this.method_59(gClass, null);
										}
										else
										{
											string a = class33_1.method_16().method_2().string_6;
											class33_1.string_0 = class33_1.method_16().method_2().string_5;
											if (a == "m")
											{
												Class98.smethod_1(class33_1, current.string_2);
											}
											else
											{
												Class98.smethod_1(class33_1, current.string_3);
											}
											GClass5 gClass = new GClass5(266u);
											gClass.method_9(class33_1.int_0);
											gClass.method_7(class33_1.method_16().method_2().string_5);
											gClass.method_7(class33_1.method_16().method_2().string_6.ToLower());
											gClass.method_7(class33_1.method_16().method_2().string_4);
											gClass.method_9(class33_1.method_16().method_2().int_13);
											gClass.method_7("");
											this.method_59(gClass, null);
										}
									}
									num = 16;
									if (current.method_7().string_2.ToLower() == "ball")
									{
										int num6 = current.Int32_0;
										int num7 = current.Int32_1;
										current.string_0 = "11";
										if (class33_1.int_8 == 4)
										{
											num7++;
											if (!this.method_79(null, current, num6, num7, 0, false, true, false))
											{
												this.method_79(null, current, num6, num7 - 2, 0, false, true, true);
											}
										}
										else
										{
											if (class33_1.int_8 == 0)
											{
												num7--;
												if (!this.method_79(null, current, num6, num7, 0, false, true, false))
												{
													this.method_79(null, current, num6, num7 + 2, 0, false, true, true);
												}
											}
											else
											{
												if (class33_1.int_8 == 6)
												{
													num6--;
													if (!this.method_79(null, current, num6, num7, 0, false, true, false))
													{
														this.method_79(null, current, num6 + 2, num7, 0, false, true, true);
													}
												}
												else
												{
													if (class33_1.int_8 == 2)
													{
														num6++;
														if (!this.method_79(null, current, num6, num7, 0, false, true, false))
														{
															this.method_79(null, current, num6 - 2, num7, 0, false, true, true);
														}
													}
													else
													{
														if (class33_1.int_8 == 3)
														{
															num6++;
															num7++;
															if (!this.method_79(null, current, num6, num7, 0, false, true, false))
															{
																this.method_79(null, current, num6 - 2, num7 - 2, 0, false, true, true);
															}
														}
														else
														{
															if (class33_1.int_8 == 1)
															{
																num6++;
																num7--;
																if (!this.method_79(null, current, num6, num7, 0, false, true, false))
																{
																	this.method_79(null, current, num6 - 2, num7 + 2, 0, false, true, true);
																}
															}
															else
															{
																if (class33_1.int_8 == 7)
																{
																	num6--;
																	num7--;
																	if (!this.method_79(null, current, num6, num7, 0, false, true, false))
																	{
																		this.method_79(null, current, num6 + 2, num7 + 2, 0, false, true, true);
																	}
																}
																else
																{
																	if (class33_1.int_8 == 5)
																	{
																		num6--;
																		num7++;
																		if (!this.method_79(null, current, num6, num7, 0, false, true, false))
																		{
																			this.method_79(null, current, num6 + 2, num7 - 2, 0, false, true, true);
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						IL_1155:;
					}
				}
			}
			catch (Exception ex)
			{
				GClass4.smethod_6(ex.ToString(), string.Concat(new object[]
				{
					"Room [ID: ",
					this.UInt32_0,
					"] [Part: ",
					num,
					"] Update User Status"
				}));
				this.method_34();
			}
		}
		public void method_88(int int_17, int int_18, Class63 class63_0)
		{
			if (int_17 == 5)
			{
				this.int_9 += int_18 - 1;
			}
			else
			{
				if (int_17 == 8)
				{
					this.int_12 += int_18 - 1;
				}
				else
				{
					if (int_17 == 11)
					{
						this.int_11 += int_18 - 1;
					}
					else
					{
						if (int_17 == 14)
						{
							this.int_10 += int_18 - 1;
						}
					}
				}
			}
			this.method_89(int_17, class63_0, false);
		}
		public void method_89(int int_17, Class63 class63_0, bool bool_13)
		{
			if (int_17 == 5)
			{
				this.int_9++;
				if (class63_0.string_0 == "5")
				{
					this.list_6.Add(class63_0);
				}
				if (this.list_10.Count > 0)
				{
					foreach (Class63 current in this.list_10)
					{
						current.string_0 = Convert.ToString(this.int_9);
						current.method_5(true, true);
					}
				}
				this.method_17(this.int_9);
			}
			else
			{
				if (int_17 == 8)
				{
					this.int_12++;
					if (class63_0.string_0 == "8")
					{
						this.list_7.Add(class63_0);
					}
					if (this.list_13.Count > 0)
					{
						foreach (Class63 current in this.list_13)
						{
							current.string_0 = Convert.ToString(this.int_12);
							current.method_5(true, true);
						}
					}
					this.method_17(this.int_12);
				}
				else
				{
					if (int_17 == 11)
					{
						this.int_11++;
						if (class63_0.string_0 == "11")
						{
							this.list_9.Add(class63_0);
						}
						if (this.list_12.Count > 0)
						{
							foreach (Class63 current in this.list_12)
							{
								current.string_0 = Convert.ToString(this.int_11);
								current.method_5(true, true);
							}
						}
						this.method_17(this.int_11);
					}
					else
					{
						if (int_17 == 14)
						{
							this.int_10++;
							if (class63_0.string_0 == "14")
							{
								this.list_8.Add(class63_0);
							}
							if (this.list_11.Count > 0)
							{
								foreach (Class63 current in this.list_11)
								{
									current.string_0 = Convert.ToString(this.int_10);
									current.method_5(true, true);
								}
							}
							this.method_17(this.int_10);
						}
					}
				}
			}
			if (bool_13 || (this.list_5.Count > 0 && this.list_6.Count + this.list_7.Count + this.list_9.Count + this.list_8.Count >= this.list_5.Count))
			{
				bool_13 = true;
				if (this.int_10 > this.int_9 && this.int_10 > this.int_11 && this.int_10 > this.int_12)
				{
					new Class14.Delegate2(this.method_90).BeginInvoke(14, null, null);
				}
				else
				{
					if (this.int_9 > this.int_10 && this.int_9 > this.int_11 && this.int_9 > this.int_12)
					{
						new Class14.Delegate2(this.method_90).BeginInvoke(5, null, null);
					}
					else
					{
						if (this.int_11 > this.int_9 && this.int_11 > this.int_10 && this.int_11 > this.int_12)
						{
							new Class14.Delegate2(this.method_90).BeginInvoke(11, null, null);
						}
						else
						{
							if (this.int_12 > this.int_9 && this.int_12 > this.int_11 && this.int_12 > this.int_10)
							{
								new Class14.Delegate2(this.method_90).BeginInvoke(8, null, null);
							}
						}
					}
				}
			}
			if (bool_13)
			{
				this.method_13();
			}
		}
		public void method_90(int int_17)
		{
			List<Class63> list = new List<Class63>();
			if (int_17 == 5)
			{
				list = this.list_6;
			}
			else
			{
				if (int_17 == 8)
				{
					list = this.list_7;
				}
				else
				{
					if (int_17 == 11)
					{
						list = this.list_9;
					}
					else
					{
						if (int_17 == 14)
						{
							list = this.list_8;
						}
					}
				}
			}
			try
			{
				for (int i = 4; i > 0; i--)
				{
					Thread.Sleep(500);
					foreach (Class63 current in list)
					{
						current.string_0 = "1";
						current.method_5(false, true);
					}
					Thread.Sleep(500);
					foreach (Class63 current in list)
					{
						current.string_0 = Convert.ToString(int_17);
						current.method_5(false, true);
					}
				}
				foreach (Class63 current in this.list_5)
				{
					current.string_0 = "0";
					current.method_5(true, true);
				}
			}
			catch
			{
			}
			this.list_9.Clear();
			this.list_7.Clear();
			this.list_6.Clear();
			this.list_8.Clear();
			this.int_10 = 0;
			this.int_11 = 0;
			this.int_9 = 0;
			this.int_12 = 0;
			foreach (Class63 current in this.list_10)
			{
				current.string_0 = "0";
				current.method_5(true, true);
			}
			foreach (Class63 current in this.list_13)
			{
				current.string_0 = "0";
				current.method_5(true, true);
			}
			foreach (Class63 current in this.list_12)
			{
				current.string_0 = "0";
				current.method_5(true, true);
			}
			foreach (Class63 current in this.list_11)
			{
				current.string_0 = "0";
				current.method_5(true, true);
			}
		}
		public void method_91(Class63 class63_0, Class33 class33_1)
		{
			class63_0.string_0 = "1";
			class63_0.method_5(false, true);
			class63_0.method_3(1);
			List<Class63> list = new List<Class63>();
			class33_1.method_3(true);
			foreach (Class63 @class in this.Hashtable_0.Values)
			{
				if (@class != class63_0 && !(@class.method_7().string_2.ToLower() != "bb_teleport"))
				{
					list.Add(@class);
				}
			}
			if (list.Count > 0)
			{
				Random random = new Random((int)Phoenix.smethod_6() * (int)class33_1.uint_0);
				int index = random.Next(0, list.Count);
				list[index].string_0 = "1";
				list[index].method_5(false, true);
				list[index].method_3(1);
				this.byte_0[class33_1.int_3, class33_1.int_4] = 1;
				this.byte_0[list[index].Int32_0, list[index].Int32_1] = 1;
				class33_1.method_7(list[index].Int32_0, list[index].Int32_1, list[index].Double_0);
				class33_1.bool_7 = true;
			}
		}
		public bool method_92(int int_17, int int_18)
		{
			return int_17 >= 0 && int_18 >= 0 && int_17 < this.Class28_0.int_4 && int_18 < this.Class28_0.int_5;
		}
		public List<Class63> method_93(int int_17, int int_18)
		{
			List<Class63> list = new List<Class63>();
			List<Class63> result;
			if (this.Hashtable_0 != null)
			{
				foreach (Class63 @class in this.Hashtable_0.Values)
				{
					if (@class.Int32_0 == int_17 && @class.Int32_1 == int_18)
					{
						list.Add(@class);
					}
					Dictionary<int, GClass10> dictionary = this.method_94(@class.method_7().int_2, @class.method_7().int_1, @class.Int32_0, @class.Int32_1, @class.int_3);
					foreach (GClass10 current in dictionary.Values)
					{
						if (current.Int32_0 == int_17 && current.Int32_1 == int_18)
						{
							list.Add(@class);
						}
					}
				}
				result = list;
			}
			else
			{
				result = null;
			}
			return result;
		}
		public Dictionary<int, GClass10> method_94(int int_17, int int_18, int int_19, int int_20, int int_21)
		{
			int num = 0;
			Dictionary<int, GClass10> dictionary = new Dictionary<int, GClass10>();
			if (int_17 > 1)
			{
				if (int_21 == 0 || int_21 == 4)
				{
					for (int i = 1; i < int_17; i++)
					{
						dictionary.Add(num++, new GClass10(int_19, int_20 + i, i));
						for (int j = 1; j < int_18; j++)
						{
							dictionary.Add(num++, new GClass10(int_19 + j, int_20 + i, (i < j) ? j : i));
						}
					}
				}
				else
				{
					if (int_21 == 2 || int_21 == 6)
					{
						for (int i = 1; i < int_17; i++)
						{
							dictionary.Add(num++, new GClass10(int_19 + i, int_20, i));
							for (int j = 1; j < int_18; j++)
							{
								dictionary.Add(num++, new GClass10(int_19 + i, int_20 + j, (i < j) ? j : i));
							}
						}
					}
				}
			}
			if (int_18 > 1)
			{
				if (int_21 == 0 || int_21 == 4)
				{
					for (int i = 1; i < int_18; i++)
					{
						dictionary.Add(num++, new GClass10(int_19 + i, int_20, i));
						for (int j = 1; j < int_17; j++)
						{
							dictionary.Add(num++, new GClass10(int_19 + i, int_20 + j, (i < j) ? j : i));
						}
					}
				}
				else
				{
					if (int_21 == 2 || int_21 == 6)
					{
						for (int i = 1; i < int_18; i++)
						{
							dictionary.Add(num++, new GClass10(int_19, int_20 + i, i));
							for (int j = 1; j < int_17; j++)
							{
								dictionary.Add(num++, new GClass10(int_19 + j, int_20 + i, (i < j) ? j : i));
							}
						}
					}
				}
			}
			return dictionary;
		}
		public bool method_95(int int_17, int int_18, bool bool_13)
		{
			return !this.bool_2 && this.method_96(int_17, int_18);
		}
		public bool method_96(int int_17, int int_18)
		{
			return this.method_43(int_17, int_18) != null;
		}
		public bool method_97(int int_17, int int_18)
		{
			return this.method_44(int_17, int_18) != null;
		}
		public string method_98(string string_10)
		{
			string result;
			try
			{
				if (string_10.Contains(Convert.ToChar(13)))
				{
					result = null;
				}
				else
				{
					if (string_10.Contains(Convert.ToChar(9)))
					{
						result = null;
					}
					else
					{
						string[] array = string_10.Split(new char[]
						{
							' '
						});
						if (array[2] != "l" && array[2] != "r")
						{
							result = null;
						}
						else
						{
							string[] array2 = array[0].Substring(3).Split(new char[]
							{
								','
							});
							int num = int.Parse(array2[0]);
							int num2 = int.Parse(array2[1]);
							if (num < 0 || num2 < 0 || num > 200 || num2 > 200)
							{
								result = null;
							}
							else
							{
								string[] array3 = array[1].Substring(2).Split(new char[]
								{
									','
								});
								int num3 = int.Parse(array3[0]);
								int num4 = int.Parse(array3[1]);
								if (num3 < 0 || num4 < 0 || num3 > 200 || num4 > 200)
								{
									result = null;
								}
								else
								{
									result = string.Concat(new object[]
									{
										":w=",
										num,
										",",
										num2,
										" l=",
										num3,
										",",
										num4,
										" ",
										array[2]
									});
								}
							}
						}
					}
				}
			}
			catch
			{
				result = null;
			}
			return result;
		}
		public bool method_99(int int_17, int int_18, int int_19, int int_20)
		{
			return (Math.Abs(int_17 - int_19) <= 1 && Math.Abs(int_18 - int_20) <= 1) || (int_17 == int_19 && int_18 == int_20);
		}
		public int method_100(int int_17, int int_18, int int_19, int int_20)
		{
			return Math.Abs(int_17 - int_19) + Math.Abs(int_18 - int_20);
		}
		internal void method_101()
		{
			for (int i = 0; i < this.class33_0.Length; i++)
			{
				Class33 @class = this.class33_0[i];
				if (@class != null)
				{
					@class.int_10 = @class.int_3;
					@class.int_11 = @class.int_4;
					@class.method_13();
					@class.method_3(false);
				}
			}
		}
		internal void method_102(int int_17)
		{
			this.int_15 = int_17;
		}
	}
}
