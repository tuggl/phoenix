using System;
namespace ns0
{
	internal sealed class Class104
	{
		private uint uint_0;
		internal bool bool_0;
		private string string_0;
		private string string_1;
		private string string_2;
		private string string_3;
		public uint UInt32_0
		{
			get
			{
				return this.uint_0;
			}
		}
		internal string String_0
		{
			get
			{
				return this.string_0;
			}
		}
		internal string String_1
		{
			get
			{
				Class16 @class = Phoenix.smethod_15().method_2().method_2(this.uint_0);
				string result;
				if (@class != null)
				{
					result = @class.method_2().string_1;
				}
				else
				{
					using (Class6 class2 = Phoenix.smethod_12().method_0())
					{
						result = class2.method_5("SELECT real_name FROM users WHERE id = '" + this.uint_0 + "' LIMIT 1");
					}
				}
				return result;
			}
		}
		internal string String_2
		{
			get
			{
				return this.string_1;
			}
		}
		internal string String_3
		{
			get
			{
				return this.string_2;
			}
		}
		internal string String_4
		{
			get
			{
				return this.string_3;
			}
		}
		internal bool Boolean_0
		{
			get
			{
				Class16 @class = Phoenix.smethod_15().method_2().method_2(this.uint_0);
				return @class != null && @class.method_2() != null && @class.method_2().method_21() != null && !@class.method_2().method_21().bool_0 && !@class.method_2().bool_13;
			}
		}
		internal bool Boolean_1
		{
			get
			{
				Class16 @class = Phoenix.smethod_15().method_2().method_2(this.uint_0);
				return @class != null && (@class.method_2().Boolean_0 && !@class.method_2().bool_12);
			}
		}
		public Class104(uint uint_1, string string_4, string string_5, string string_6, string string_7)
		{
			this.uint_0 = uint_1;
			this.string_0 = string_4;
			this.string_1 = string_5;
			this.string_2 = string_6;
			this.string_3 = Phoenix.smethod_21(Convert.ToDouble(string_7)).ToString();
			this.bool_0 = false;
		}
		public void method_0(GClass5 gclass5_0, bool bool_1)
		{
			if (bool_1)
			{
				gclass5_0.method_11(this.uint_0);
				gclass5_0.method_7(this.string_0);
				gclass5_0.method_7(this.string_2);
				bool boolean_ = this.Boolean_0;
				gclass5_0.method_13(boolean_);
				if (boolean_)
				{
					gclass5_0.method_13(this.Boolean_1);
				}
				else
				{
					gclass5_0.method_13(false);
				}
				gclass5_0.method_7("");
				gclass5_0.method_13(false);
				gclass5_0.method_7(this.string_1);
				gclass5_0.method_7(this.string_3);
				gclass5_0.method_7("");
			}
			else
			{
				gclass5_0.method_11(this.uint_0);
				gclass5_0.method_7(this.string_0);
				gclass5_0.method_13(true);
				if (this.uint_0 == 0u)
				{
					gclass5_0.method_13(true);
					gclass5_0.method_13(false);
				}
				else
				{
					bool boolean_ = this.Boolean_0;
					gclass5_0.method_13(boolean_);
					if (boolean_)
					{
						gclass5_0.method_13(this.Boolean_1);
					}
					else
					{
						gclass5_0.method_13(false);
					}
				}
				gclass5_0.method_7(this.string_1);
				gclass5_0.method_13(false);
				gclass5_0.method_7(this.string_2);
				gclass5_0.method_7(this.string_3);
				gclass5_0.method_7("");
				gclass5_0.method_7("");
			}
		}
	}
}
