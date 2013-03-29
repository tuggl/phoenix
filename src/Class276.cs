using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
namespace ns0
{
	internal sealed class Class276
	{
		private Task task_0;
		private bool bool_0;
		private Hashtable hashtable_0;
		public Class276()
		{
			this.bool_0 = false;
			this.hashtable_0 = new Hashtable();
			this.task_0 = new Task(new Action(this.method_0));
			this.task_0.Start();
		}
		private void method_0()
		{
			while (!this.bool_0)
			{
				try
				{
					Hashtable hashtable = new Hashtable();
					hashtable.Add(-2, Phoenix.smethod_15().method_7().method_12(null, -2).method_14());
					Hashtable hashtable2 = this.hashtable_0;
					this.hashtable_0 = hashtable;
					hashtable2.Clear();
				}
				catch (Exception ex)
				{
					GClass4.smethod_6(ex.ToString(), "Navigator cache task");
				}
				Thread.Sleep(100000);
			}
		}
		internal byte[] method_1(int int_0)
		{
			byte[] result;
			try
			{
				result = (this.hashtable_0[int_0] as byte[]);
			}
			catch
			{
				result = null;
			}
			return result;
		}
	}
}
