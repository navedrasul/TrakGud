using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__Item")]	public class Item
	{
		public int id { get; set; }
		public int prodId { get; set; }
		public DateTime addTS { get; set; }
		public int adderId { get; set; }
		public float? price { get; set; }
		public int? modderId { get; set; }
		public bool? isRemoved { get; set; }
		public float? qty { get; set; }
		public int? unitId { get; set; }
		public DateTime? expireTS { get; set; }
		public float? expireMargin { get; set; }
		public bool? isFixed { get; set; }
		public bool? isExpired { get; set; }
		public DateTime? modTS { get; set; }

		public Item() { }


		public Item(int id, int prodId, DateTime addTS, int adderId, float? price = default, int? modderId = default, bool? isRemoved = default, float? qty = default, int? unitId = default, DateTime? expireTS = default, float? expireMargin = default, bool? isFixed = default, bool? isExpired = default, DateTime? modTS = default)		{
			this.id = id;
			this.prodId = prodId;
			this.addTS = addTS;
			this.adderId = adderId;
			this.price = price;
			this.modderId = modderId;
			this.isRemoved = isRemoved;
			this.qty = qty;
			this.unitId = unitId;
			this.expireTS = expireTS;
			this.expireMargin = expireMargin;
			this.isFixed = isFixed;
			this.isExpired = isExpired;
			this.modTS = modTS;
		}
	}
}