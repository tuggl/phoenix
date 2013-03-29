using System;
using System.Threading;
namespace ns0
{
	internal sealed class Class0
	{
		public bool bool_0;
		private Thread thread_0;
		public Class0()
		{
			this.bool_0 = true;
			this.thread_0 = new Thread(new ThreadStart(this.method_1));
			this.thread_0.Name = "Pixel Manager";
			this.thread_0.Priority = ThreadPriority.Lowest;
		}
		public void method_0()
		{
			GClass4.smethod_0("Starting Reward Timer..");
			this.thread_0.Start();
			GClass4.smethod_1("completed!");
		}
		private void method_1()
		{
			try
			{
				while (this.bool_0)
				{
					if (Phoenix.smethod_15() != null && Phoenix.smethod_15().method_2() != null)
					{
						Phoenix.smethod_15().method_2().method_29();
					}
					Thread.Sleep(15000);
				}
			}
			catch (ThreadAbortException)
			{
			}
		}
		public bool method_2(Class16 class16_0)
		{
			double num = (Phoenix.smethod_6() - class16_0.method_2().double_0) / 60.0;
			return num >= (double)Class13.Int32_0;
		}
		public void method_3(Class16 class16_0)
		{
			try
			{
				if (class16_0.method_2().Boolean_0)
				{
					Class33 @class = class16_0.method_2().Class14_0.method_53(class16_0.method_2().uint_0);
					if (@class.int_1 <= Class13.int_14)
					{
						double double_ = Phoenix.smethod_6();
						class16_0.method_2().double_0 = double_;
						if (Class13.Int32_3 > 0 && (class16_0.method_2().int_3 < Class13.int_3 || Class13.int_3 == 0))
						{
							class16_0.method_2().int_3 += Class13.Int32_3;
							class16_0.method_2().method_16(Class13.Int32_3);
						}
						if (Class13.Int32_1 > 0 && (class16_0.method_2().int_2 < Class13.int_5 || Class13.int_5 == 0))
						{
							class16_0.method_2().int_2 += Class13.Int32_1;
							if (class16_0.method_2().bool_14)
							{
								class16_0.method_2().int_2 += Class13.Int32_1;
							}
							class16_0.method_2().method_13(true);
						}
						if (Class13.Int32_2 > 0 && (class16_0.method_2().int_12 < Class13.int_4 || Class13.int_4 == 0))
						{
							class16_0.method_2().int_12 += Class13.Int32_2;
							class16_0.method_2().method_14(false, true);
						}
					}
				}
			}
			catch
			{
			}
		}
	}
}
