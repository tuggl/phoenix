using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class129
	{
		public Dictionary<uint, Class131> dictionary_0;
		public Dictionary<uint, Class130> dictionary_1;
		public List<Class130> list_0;
		public List<Class130> list_1;
		public Class129()
		{
			this.dictionary_0 = new Dictionary<uint, Class131>();
			this.dictionary_1 = new Dictionary<uint, Class130>();
			this.list_0 = new List<Class130>();
			this.list_1 = new List<Class130>();
		}
		public void method_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Help Categories..");
			this.dictionary_0.Clear();
			DataTable dataTable = class6_0.method_3("SELECT id, caption FROM help_subjects");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					this.dictionary_0.Add((uint)dataRow["id"], new Class131((uint)dataRow["id"], (string)dataRow["caption"]));
				}
				GClass4.smethod_1("completed!");
			}
		}
		public Class131 method_1(uint uint_0)
		{
			Class131 result;
			if (this.dictionary_0.ContainsKey(uint_0))
			{
				result = this.dictionary_0[uint_0];
			}
			else
			{
				result = null;
			}
			return result;
		}
		public void method_2()
		{
			this.dictionary_0.Clear();
		}
		public void method_3(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Help Topics..");
			this.dictionary_1.Clear();
			DataTable dataTable = class6_0.method_3("SELECT id, title, body, subject, known_issue FROM help_topics");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					Class130 @class = new Class130((uint)dataRow["id"], (string)dataRow["title"], (string)dataRow["body"], (uint)dataRow["subject"]);
					this.dictionary_1.Add((uint)dataRow["id"], @class);
					int num = int.Parse(dataRow["known_issue"].ToString());
					if (num == 1)
					{
						this.list_1.Add(@class);
					}
					else
					{
						if (num == 2)
						{
							this.list_0.Add(@class);
						}
					}
				}
				GClass4.smethod_1("completed!");
			}
		}
		public Class130 method_4(uint uint_0)
		{
			Class130 result;
			if (this.dictionary_1.ContainsKey(uint_0))
			{
				result = this.dictionary_1[uint_0];
			}
			else
			{
				result = null;
			}
			return result;
		}
		public void method_5()
		{
			this.dictionary_1.Clear();
			this.list_0.Clear();
			this.list_1.Clear();
		}
		public int method_6(uint uint_0)
		{
			int num = 0;
			using (GStruct0.smethod_0(this.dictionary_1))
			{
				foreach (Class130 current in this.dictionary_1.Values)
				{
					if (current.uint_1 == uint_0)
					{
						num++;
					}
				}
			}
			return num;
		}
		public GClass5 method_7()
		{
			GClass5 gClass = new GClass5(518u);
			gClass.method_9(this.list_0.Count);
			using (GStruct0.smethod_0(this.list_0))
			{
				foreach (Class130 current in this.list_0)
				{
					gClass.method_11(current.UInt32_0);
					gClass.method_7(current.string_0);
				}
			}
			gClass.method_9(this.list_1.Count);
			using (GStruct0.smethod_0(this.list_1))
			{
				foreach (Class130 current in this.list_1)
				{
					gClass.method_11(current.UInt32_0);
					gClass.method_7(current.string_0);
				}
			}
			return gClass;
		}
		public GClass5 method_8()
		{
			GClass5 gClass = new GClass5(519u);
			gClass.method_9(this.dictionary_0.Count);
			using (GStruct0.smethod_0(this.dictionary_0))
			{
				foreach (Class131 current in this.dictionary_0.Values)
				{
					gClass.method_11(current.UInt32_0);
					gClass.method_7(current.string_0);
					gClass.method_9(this.method_6(current.UInt32_0));
				}
			}
			return gClass;
		}
		public GClass5 method_9(Class130 class130_0)
		{
			GClass5 gClass = new GClass5(520u);
			gClass.method_11(class130_0.UInt32_0);
			gClass.method_7(class130_0.string_1);
			return gClass;
		}
		public GClass5 method_10(string string_0)
		{
			DataTable dataTable = null;
			using (Class6 @class = Phoenix.smethod_12().method_0())
			{
				@class.method_0("query", string_0);
				dataTable = @class.method_3("SELECT id,title FROM help_topics WHERE title LIKE @query OR body LIKE @query LIMIT 25");
			}
			GClass5 gClass = new GClass5(521u);
			GClass5 result;
			if (dataTable == null)
			{
				gClass.method_13(false);
				result = gClass;
			}
			else
			{
				gClass.method_9(dataTable.Rows.Count);
				foreach (DataRow dataRow in dataTable.Rows)
				{
					gClass.method_11((uint)dataRow["id"]);
					gClass.method_7((string)dataRow["title"]);
				}
				result = gClass;
			}
			return result;
		}
		public GClass5 method_11(Class131 class131_0)
		{
			GClass5 gClass = new GClass5(522u);
			gClass.method_11(class131_0.UInt32_0);
			gClass.method_7("");
			gClass.method_9(this.method_6(class131_0.UInt32_0));
			using (GStruct0.smethod_0(this.dictionary_1))
			{
				foreach (Class130 current in this.dictionary_1.Values)
				{
					if (current.uint_1 == class131_0.UInt32_0)
					{
						gClass.method_11(current.UInt32_0);
						gClass.method_7(current.string_0);
					}
				}
			}
			return gClass;
		}
	}
}
