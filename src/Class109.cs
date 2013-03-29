using System;
namespace ns0
{
	internal sealed class Class109
	{
		private uint uint_0;
		private uint uint_1;
		private Class17 class17_0;
		private Class11 class11_0;
		public Class109(Class17 class17_1, Class11 class11_1, uint uint_2, uint uint_3)
		{
			this.class17_0 = class17_1;
			this.class11_0 = class11_1;
			this.uint_0 = uint_2;
			this.uint_1 = uint_3;
		}
		public void method_0()
		{
			if (this.class17_0 != null && this.class11_0 != null)
			{
				this.class11_0.bool_7 = true;
				this.class11_0.uint_5 = this.uint_1;
				this.class17_0.method_5(this.uint_0, "");
			}
		}
	}
}
