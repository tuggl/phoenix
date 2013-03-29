using System;
using System.Collections.Generic;
namespace ns0
{
	internal sealed class Class65
	{
		public uint uint_0;
		private uint uint_1;
		private bool bool_0;
		public List<Class39> list_0;
		public bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}
		public Class65(uint uint_2, uint uint_3)
		{
			this.uint_0 = uint_2;
			this.uint_1 = uint_3;
			this.bool_0 = false;
			this.list_0 = new List<Class39>();
		}
		public Class33 method_0()
		{
			Class14 @class = Phoenix.smethod_15().method_9().method_19(this.uint_1);
			Class33 result;
			if (@class == null)
			{
				result = null;
			}
			else
			{
				result = @class.method_53(this.uint_0);
			}
			return result;
		}
		public Class16 method_1()
		{
			return Phoenix.smethod_15().method_2().method_2(this.uint_0);
		}
	}
}
