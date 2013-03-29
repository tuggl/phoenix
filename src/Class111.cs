using System;
namespace ns0
{
	internal sealed class Class111
	{
		private uint uint_0;
		public int int_0;
		public int int_1;
		public Enum6 enum6_0;
		public uint uint_1;
		public uint uint_2;
		public uint uint_3;
		public string string_0;
		public uint uint_4;
		public string string_1;
		public double double_0;
		private string string_2;
		private string string_3;
		private string string_4;
		public int Int32_0
		{
			get
			{
				int result;
				if (this.enum6_0 == Enum6.const_0)
				{
					result = 1;
				}
				else
				{
					if (this.enum6_0 == Enum6.const_1)
					{
						result = 2;
					}
					else
					{
						result = 0;
					}
				}
				return result;
			}
		}
		public uint UInt32_0
		{
			get
			{
				return this.uint_0;
			}
		}
		public Class111(uint uint_5, int int_2, int int_3, uint uint_6, uint uint_7, string string_5, uint uint_8, string string_6, double double_1, uint uint_9)
		{
			this.uint_0 = uint_5;
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.enum6_0 = Enum6.const_0;
			this.uint_1 = uint_6;
			this.uint_2 = uint_7;
			this.uint_3 = uint_9;
			this.string_0 = string_5;
			this.uint_4 = uint_8;
			this.string_1 = string_6;
			this.double_0 = double_1;
			this.string_2 = Phoenix.smethod_15().method_2().method_26(uint_6);
			this.string_3 = Phoenix.smethod_15().method_2().method_26(uint_7);
			this.string_4 = Phoenix.smethod_15().method_2().method_26(uint_9);
		}
		public void method_0(uint uint_5, bool bool_0)
		{
			this.enum6_0 = Enum6.const_1;
			this.uint_3 = uint_5;
			this.string_4 = Phoenix.smethod_15().method_2().method_26(uint_5);
			if (bool_0)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1(string.Concat(new object[]
					{
						"UPDATE moderation_tickets SET status = 'picked', moderator_id = '",
						uint_5,
						"' WHERE id = '",
						this.uint_0,
						"' LIMIT 1"
					}));
				}
			}
		}
        public void method_1(Enum6 enum6_1, bool bool_0)
        {
            String text = null;
            this.enum6_0 = enum6_1;
            if (bool_0)
            {
                switch (enum6_1)
                {
                    case Enum6.const_2:
                        {
                            text = "resolved";
                            goto IL_42;
                        }
                    case Enum6.const_3:
                        {
                            text = "abusive";
                            goto IL_42;
                        }
                    case Enum6.const_4:
                        {
                            text = "invalid";
                            goto IL_42;
                        }
                }
            /*goto IL_2C;*/
            IL_42:
                using (Class6 @class = Phoenix.smethod_12().method_0())
                {
                    @class.method_1(string.Concat(new object[]
					{
						"UPDATE moderation_tickets SET status = '",
						text,
						"' WHERE id = '",
						this.uint_0,
						"' LIMIT 1"
					}));
                }
            }
        }
		public void method_2(bool bool_0)
		{
			this.enum6_0 = Enum6.const_0;
			if (bool_0)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1("UPDATE moderation_tickets SET status = 'open' WHERE id = '" + this.uint_0 + "' LIMIT 1");
				}
			}
		}
		public void method_3(bool bool_0)
		{
			this.enum6_0 = Enum6.const_5;
			if (bool_0)
			{
				using (Class6 @class = Phoenix.smethod_12().method_0())
				{
					@class.method_1("UPDATE moderation_tickets SET status = 'deleted' WHERE id = '" + this.uint_0 + "' LIMIT 1");
				}
			}
		}
		public GClass5 method_4()
		{
			GClass5 gClass = new GClass5(530u);
			gClass.method_11(this.uint_0);
			gClass.method_9(this.Int32_0);
			gClass.method_9(11);
			gClass.method_9(this.int_1);
			gClass.method_9(11);
			gClass.method_9(this.int_0);
			gClass.method_11(this.uint_1);
			gClass.method_7(this.string_2);
			gClass.method_11(this.uint_2);
			gClass.method_7(this.string_3);
			gClass.method_11(this.uint_3);
			gClass.method_7(this.string_4);
			gClass.method_7(this.string_0);
			gClass.method_11(this.uint_4);
			gClass.method_7(this.string_1);
			return gClass;
		}
	}
}
