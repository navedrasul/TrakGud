using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ItemBatch_agr")]	public class ItemBatch_agr
	{
		public int id { get; set; }
		public float? qty { get; set; }
		public int? unitId { get; set; }
		public float? price { get; set; }

		public ItemBatch_agr() { }


		public ItemBatch_agr(int id, float? qty = default, int? unitId = default, float? price = default)		{
			this.id = id;
			this.qty = qty;
			this.unitId = unitId;
			this.price = price;
		}
	}
}