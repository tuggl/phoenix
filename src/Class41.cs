using System;
using System.Collections.Generic;
using System.Data;
namespace ns0
{
	internal sealed class Class41
	{
		private Dictionary<uint, Class40> dictionary_0;
		private Dictionary<int, Class42> dictionary_1;
		public Class41()
		{
			this.dictionary_0 = new Dictionary<uint, Class40>();
			this.dictionary_1 = new Dictionary<int, Class42>();
		}
		public void method_0(Class6 class6_0)
		{
			GClass4.smethod_0("Loading Items..");
			this.dictionary_0 = new Dictionary<uint, Class40>();
			DataTable dataTable = class6_0.method_3("SELECT * FROM furniture;");
			if (dataTable != null)
			{
				foreach (DataRow dataRow in dataTable.Rows)
				{
					try
					{
						this.dictionary_0.Add((uint)dataRow["id"], new Class40((uint)dataRow["id"], (int)dataRow["sprite_id"], (string)dataRow["public_name"], (string)dataRow["item_name"], (string)dataRow["type"], (int)dataRow["width"], (int)dataRow["length"], (double)dataRow["stack_height"], Phoenix.smethod_3(dataRow["can_stack"].ToString()), Phoenix.smethod_3(dataRow["is_walkable"].ToString()), Phoenix.smethod_3(dataRow["can_sit"].ToString()), Phoenix.smethod_3(dataRow["allow_recycle"].ToString()), Phoenix.smethod_3(dataRow["allow_trade"].ToString()), Phoenix.smethod_3(dataRow["allow_marketplace_sell"].ToString()), Phoenix.smethod_3(dataRow["allow_gift"].ToString()), Phoenix.smethod_3(dataRow["allow_inventory_stack"].ToString()), (string)dataRow["interaction_type"], (int)dataRow["interaction_modes_count"], (string)dataRow["vending_ids"], dataRow["height_adjustable"].ToString(), Convert.ToByte((int)dataRow["EffectF"]), Convert.ToByte((int)dataRow["EffectM"])));
					}
					catch (Exception)
					{
						GClass4.smethod_1("Could not load item #" + (uint)dataRow["id"] + ", please verify the data is okay.");
					}
				}
			}
			GClass4.smethod_1("completed!");
			GClass4.smethod_0("Loading Soundtracks..");
			this.dictionary_1 = new Dictionary<int, Class42>();
			DataTable dataTable2 = class6_0.method_3("SELECT * FROM soundtracks;");
			if (dataTable2 != null)
			{
				foreach (DataRow dataRow in dataTable2.Rows)
				{
					try
					{
						this.dictionary_1.Add((int)dataRow["id"], new Class42((int)dataRow["id"], (string)dataRow["name"], (string)dataRow["author"], (string)dataRow["track"], (int)dataRow["length"]));
					}
					catch (Exception)
					{
						GClass4.smethod_1("Could not load item #" + (uint)dataRow["id"] + ", please verify the data is okay.");
					}
				}
			}
			GClass4.smethod_1("completed!");
		}
		public bool method_1(uint uint_0)
		{
			return this.dictionary_0.ContainsKey(uint_0);
		}
		public Class40 method_2(uint uint_0)
		{
			Class40 result;
			if (this.method_1(uint_0))
			{
				result = this.dictionary_0[uint_0];
			}
			else
			{
				result = null;
			}
			return result;
		}
		public bool method_3(int int_0)
		{
			return this.dictionary_1.ContainsKey(int_0);
		}
		public Class42 method_4(int int_0)
		{
			Class42 result;
			if (this.method_3(int_0))
			{
				result = this.dictionary_1[int_0];
			}
			else
			{
				result = null;
			}
			return result;
		}
	}
}
