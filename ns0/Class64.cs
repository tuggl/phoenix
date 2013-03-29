using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ns0
{
	internal sealed class Class64
	{
		private Class65[] class65_0;
		private int int_0;
		private uint uint_0;
		private uint uint_1;
		private uint uint_2;
		public bool Boolean_0
		{
			get
			{
				bool result;
				for (int i = 0; i < this.class65_0.Length; i++)
				{
					if (this.class65_0[i] != null && !this.class65_0[i].Boolean_0)
					{
						result = false;
						return result;
					}
				}
				result = true;
				return result;
			}
		}
		public Class64(uint uint_3, uint uint_4, uint uint_5)
		{
			this.uint_1 = uint_3;
			this.uint_2 = uint_4;
			this.class65_0 = new Class65[2];
			this.class65_0[0] = new Class65(uint_3, uint_5);
			this.class65_0[1] = new Class65(uint_4, uint_5);
			this.int_0 = 1;
			this.uint_0 = uint_5;
			Class65[] array = this.class65_0;
			for (int i = 0; i < array.Length; i++)
			{
				Class65 @class = array[i];
				if (!@class.method_0().dictionary_0.ContainsKey("trd"))
				{
					@class.method_0().method_11("trd", "");
					@class.method_0().bool_7 = true;
				}
			}
			GClass5 gClass = new GClass5(104u);
			gClass.method_11(uint_3);
			gClass.method_13(true);
			gClass.method_11(uint_4);
			gClass.method_13(true);
			this.method_13(gClass);
		}
		public bool method_0(uint uint_3)
		{
			bool result;
			for (int i = 0; i < this.class65_0.Length; i++)
			{
				if (this.class65_0[i] != null && this.class65_0[i].uint_0 == uint_3)
				{
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}
		public Class65 method_1(uint uint_3)
		{
			Class65 result;
			for (int i = 0; i < this.class65_0.Length; i++)
			{
				if (this.class65_0[i] != null && this.class65_0[i].uint_0 == uint_3)
				{
					result = this.class65_0[i];
					return result;
				}
			}
			result = null;
			return result;
		}
		public void method_2(uint uint_3, Class39 class39_0)
		{
			Class65 @class = this.method_1(uint_3);
			if (@class != null && class39_0 != null && class39_0.method_1().bool_4 && !@class.Boolean_0 && this.int_0 == 1)
			{
				this.method_8();
				@class.list_0.Add(class39_0);
				this.method_9();
			}
		}
		public void method_3(uint uint_3, Class39 class39_0)
		{
			Class65 @class = this.method_1(uint_3);
			if (@class != null && class39_0 != null && !@class.Boolean_0 && this.int_0 == 1)
			{
				this.method_8();
				@class.list_0.Remove(class39_0);
				this.method_9();
			}
		}
		public void method_4(uint uint_3)
		{
			Class65 @class = this.method_1(uint_3);
			if (@class != null && this.int_0 == 1)
			{
				@class.Boolean_0 = true;
				GClass5 gClass = new GClass5(109u);
				gClass.method_11(uint_3);
				gClass.method_13(true);
				this.method_13(gClass);
				if (this.Boolean_0)
				{
					this.method_13(new GClass5(111u));
					this.int_0++;
					this.method_8();
				}
			}
		}
		public void method_5(uint uint_3)
		{
			Class65 @class = this.method_1(uint_3);
			if (@class != null && this.int_0 == 1 && !this.Boolean_0)
			{
				@class.Boolean_0 = false;
				GClass5 gClass = new GClass5(109u);
				gClass.method_11(uint_3);
				gClass.method_13(false);
				this.method_13(gClass);
			}
		}
		public void method_6(uint uint_3)
		{
			Class65 @class = this.method_1(uint_3);
			if (@class != null && this.int_0 == 2)
			{
				@class.Boolean_0 = true;
				GClass5 gClass = new GClass5(109u);
				gClass.method_11(uint_3);
				gClass.method_13(true);
				this.method_13(gClass);
				if (this.Boolean_0)
				{
					this.int_0 = 999;
					Task task = new Task(new Action(this.method_7));
					task.Start();
				}
			}
		}
		private void method_7()
		{
			try
			{
				this.method_10();
				this.method_11();
			}
			catch (Exception ex)
			{
				GClass4.smethod_6(ex.ToString(), "Trade task");
			}
		}
		public void method_8()
		{
			using (GStruct0.smethod_0(this.class65_0))
			{
				Class65[] array = this.class65_0;
				for (int i = 0; i < array.Length; i++)
				{
					Class65 @class = array[i];
					@class.Boolean_0 = false;
				}
			}
		}
		public void method_9()
		{
			GClass5 gClass = new GClass5(108u);
			using (GStruct0.smethod_0(this.class65_0))
			{
				for (int i = 0; i < this.class65_0.Length; i++)
				{
					Class65 @class = this.class65_0[i];
					if (@class != null)
					{
						gClass.method_11(@class.uint_0);
						gClass.method_9(@class.list_0.Count);
						using (GStruct0.smethod_0(@class.list_0))
						{
							foreach (Class39 current in @class.list_0)
							{
								gClass.method_11(current.uint_0);
								gClass.method_7(current.method_1().char_0.ToString().ToLower());
								gClass.method_11(current.uint_0);
								gClass.method_9(current.method_1().int_0);
								gClass.method_13(true);
								gClass.method_13(true);
								gClass.method_7("");
								gClass.method_13(false);
								gClass.method_13(false);
								gClass.method_13(false);
								if (current.method_1().char_0 == 's')
								{
									gClass.method_9(-1);
								}
							}
						}
					}
				}
			}
			this.method_13(gClass);
		}
		public void method_10()
		{
			List<Class39> list_ = this.method_1(this.uint_1).list_0;
			List<Class39> list_2 = this.method_1(this.uint_2).list_0;
			foreach (Class39 current in list_)
			{
				if (this.method_1(this.uint_1).method_1().method_2().method_23().method_10(current.uint_0) == null)
				{
					this.method_1(this.uint_1).method_1().method_8("Trade failed.");
					this.method_1(this.uint_2).method_1().method_8("Trade failed.");
					return;
				}
			}
			foreach (Class39 current in list_2)
			{
				if (this.method_1(this.uint_2).method_1().method_2().method_23().method_10(current.uint_0) == null)
				{
					this.method_1(this.uint_1).method_1().method_8("Trade failed.");
					this.method_1(this.uint_2).method_1().method_8("Trade failed.");
					return;
				}
			}
			this.method_1(this.uint_2).method_1().method_2().method_23().method_18();
			this.method_1(this.uint_1).method_1().method_2().method_23().method_18();
			foreach (Class39 current in list_)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE items SET room_id = '0', user_id = '",
						this.method_1(this.uint_2).method_1().method_2().uint_0,
						"' WHERE id = '",
						current.uint_0,
						"' LIMIT 1"
					}));
				}
				this.method_1(this.uint_1).method_1().method_2().method_23().method_12(current.uint_0, this.method_1(this.uint_2).method_1().method_2().uint_0, true);
				this.method_1(this.uint_2).method_1().method_2().method_23().method_11(current.uint_0, current.uint_1, current.string_0, false);
			}
			foreach (Class39 current in list_2)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE items SET room_id = '0', user_id = '",
						this.method_1(this.uint_1).method_1().method_2().uint_0,
						"' WHERE id = '",
						current.uint_0,
						"' LIMIT 1"
					}));
				}
				this.method_1(this.uint_2).method_1().method_2().method_23().method_12(current.uint_0, this.method_1(this.uint_1).method_1().method_2().uint_0, true);
				this.method_1(this.uint_1).method_1().method_2().method_23().method_11(current.uint_0, current.uint_1, current.string_0, false);
			}
			this.method_1(this.uint_1).method_1().method_2().method_23().method_9(true);
			this.method_1(this.uint_2).method_1().method_2().method_23().method_9(true);

		}
		public void method_11()
		{
			for (int i = 0; i < this.class65_0.Length; i++)
			{
				Class65 @class = this.class65_0[i];
				if (@class != null && @class.method_0() != null)
				{
					@class.method_0().method_12("trd");
					@class.method_0().bool_7 = true;
				}
			}
			this.method_13(new GClass5(112u));
			this.method_14().list_2.Remove(this);
		}
		public void method_12(uint uint_3)
		{
			for (int i = 0; i < this.class65_0.Length; i++)
			{
				Class65 @class = this.class65_0[i];
				if (@class != null && @class.method_0() != null)
				{
					@class.method_0().method_12("trd");
					@class.method_0().bool_7 = true;
				}
			}
			GClass5 gClass = new GClass5(110u);
			gClass.method_11(uint_3);
			this.method_13(gClass);
		}
		public void method_13(GClass5 gclass5_0)
		{
			if (this.class65_0 != null)
			{
				for (int i = 0; i < this.class65_0.Length; i++)
				{
					Class65 @class = this.class65_0[i];
					if (@class != null && @class != null && @class.method_1() != null)
					{
						@class.method_1().method_14(gclass5_0);
					}
				}
			}
		}
		private Class14 method_14()
		{
			return Phoenix.smethod_15().method_9().method_19(this.uint_0);
		}
	}
}
