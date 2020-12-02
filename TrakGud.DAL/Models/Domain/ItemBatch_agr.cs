using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ItemBatch_agr
	{
		public int id { get; set; }
		public float? qty { get; set; }
		public int? unitId { get; set; }
		public float? price { get; set; }

		public ItemBatch_agr(int id_, float? qty_ = default, int? unitId_ = default, float? price_ = default)		{
			this.id = id_;
			this.qty = qty_;
			this.unitId = unitId_;
			this.price = price_;
		}
	}
}