using System;
namespace ns0
{
	public struct GStruct1
	{
		internal int int_0;
		internal int int_1;
		internal GStruct1(int int_2, int int_3)
		{
			this.int_0 = int_2;
			this.int_1 = int_3;
		}
		public static bool smethod_0(GStruct1 gstruct1_0, GStruct1 gstruct1_1)
		{
			return object.ReferenceEquals(gstruct1_0, gstruct1_1) || (/*gstruct1_0 != null && gstruct1_1 != null && */gstruct1_0.int_0 == gstruct1_1.int_0 && gstruct1_0.int_1 == gstruct1_1.int_1);
		}
		public static bool smethod_1(GStruct1 gstruct1_0, GStruct1 gstruct1_1)
		{
			return !GStruct1.smethod_0(gstruct1_0, gstruct1_1);
		}
		public override int GetHashCode()
		{
			return this.int_0 ^ this.int_1;
		}
		public override bool Equals(object obj)
		{
			return base.GetHashCode().Equals(obj.GetHashCode());
		}
	}
}
