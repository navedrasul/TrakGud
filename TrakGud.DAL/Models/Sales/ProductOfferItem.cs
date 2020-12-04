using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
[Table("s__ProductOfferItem")]	public class ProductOfferItem
	{
		public int id { get; set; }
		public int productId { get; set; }
		public int productOfferId { get; set; }
		public float qty { get; set; }
		public int unitId { get; set; }
		public float? maxQty { get; set; }

		public ProductOfferItem() { }


		public ProductOfferItem(int id, int productId, int productOfferId, float qty, int unitId, float? maxQty = default)		{
			this.id = id;
			this.productId = productId;
			this.productOfferId = productOfferId;
			this.qty = qty;
			this.unitId = unitId;
			this.maxQty = maxQty;
		}
	}
}