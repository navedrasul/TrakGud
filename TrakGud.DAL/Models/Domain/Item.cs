using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class Item
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
		public DateTime expireTS { get; set; }
		public float? expireMargin { get; set; }
		public bool? isFixed { get; set; }
		public bool? isExpired { get; set; }
		public DateTime modTS { get; set; }

		public Item(int id_, int prodId_, DateTime addTS_, int adderId_, float? price_ = default, int? modderId_ = default, bool? isRemoved_ = default, float? qty_ = default, int? unitId_ = default, DateTime expireTS_ = default, float? expireMargin_ = default, bool? isFixed_ = default, bool? isExpired_ = default, DateTime modTS_ = default)		{
			this.id = id_;
			this.prodId = prodId_;
			this.addTS = addTS_;
			this.adderId = adderId_;
			this.price = price_;
			this.modderId = modderId_;
			this.isRemoved = isRemoved_;
			this.qty = qty_;
			this.unitId = unitId_;
			this.expireTS = expireTS_;
			this.expireMargin = expireMargin_;
			this.isFixed = isFixed_;
			this.isExpired = isExpired_;
			this.modTS = modTS_;
		}
	}
}