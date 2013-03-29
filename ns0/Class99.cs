using System;
namespace ns0
{
	internal abstract class Class99
	{
		public int int_0;
		private int int_1;
		private uint uint_0;
		public Class99()
		{
		}
		public void method_0(int int_2, int int_3, uint uint_1)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
			this.uint_0 = uint_1;
		}
		public Class14 method_1()
		{
			return Phoenix.smethod_15().method_9().method_19(this.uint_0);
		}
		public Class33 method_2()
		{
			return this.method_1().method_52(this.int_1);
		}
		public Class34 method_3()
		{
			Class33 @class = this.method_2();
			Class34 result;
			if (@class == null)
			{
				result = null;
			}
			else
			{
				result = this.method_2().class34_0;
			}
			return result;
		}
		public abstract void vmethod_0();
		public abstract void vmethod_1(bool bool_0);
		public abstract void vmethod_2(Class33 class33_0);
		public abstract void vmethod_3(Class16 class16_0);
		public abstract void vmethod_4(Class33 class33_0, string string_0);
		public abstract void vmethod_5(Class33 class33_0, string string_0);
		public abstract void vmethod_6();
	}
}
