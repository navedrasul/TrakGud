using System;
using System.Collections.Generic;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
	public class ProductStock
	{
		public int id { get; set; }
		public int productId { get; set; }
		public float? qty { get; set; }
		public int? unitId { get; set; }

		public ProductStock(int id_, int productId_, float? qty_ = default, int? unitId_ = default)		{
			this.id = id_;
			this.productId = productId_;
			this.qty = qty_;
			this.unitId = unitId_;
		}
	}
}