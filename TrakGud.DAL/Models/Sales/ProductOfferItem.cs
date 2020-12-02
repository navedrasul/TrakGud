using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Sales
{
	public class ProductOfferItem
	{
		public int id { get; set; }
		public int productId { get; set; }
		public int productOfferId { get; set; }
		public float qty { get; set; }
		public int unitId { get; set; }
		public float? maxQty { get; set; }

		public ProductOfferItem(int id_, int productId_, int productOfferId_, float qty_, int unitId_, float? maxQty_ = default)		{
			this.id = id_;
			this.productId = productId_;
			this.productOfferId = productOfferId_;
			this.qty = qty_;
			this.unitId = unitId_;
			this.maxQty = maxQty_;
		}
	}
}