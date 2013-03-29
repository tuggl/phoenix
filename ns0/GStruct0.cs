using System;
using System.Threading;
namespace ns0
{
	public struct GStruct0 : IDisposable
	{
		public sealed class GException0 : ApplicationException
		{
			public GException0() : base("Timeout, Waiting for Lock...")
			{
			}
		}
		private readonly object object_0;
		private GStruct0(object object_1)
		{
			this.object_0 = object_1;
		}
		public static GStruct0 smethod_0(object object_1)
		{
			return GStruct0.smethod_1(object_1, TimeSpan.FromSeconds(0.0));
		}
		public static GStruct0 smethod_1(object object_1, TimeSpan timeSpan_0)
		{
			GStruct0 result = new GStruct0(object_1);
			if (!Monitor.TryEnter(object_1, timeSpan_0))
			{
				throw new GStruct0.GException0();
			}
			return result;
		}
		public void Dispose()
		{
			Monitor.Exit(this.object_0);
		}
	}
}
