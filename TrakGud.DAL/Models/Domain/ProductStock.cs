using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ProductStock")]	public class ProductStock
	{
		public int id { get; set; }
		public int productId { get; set; }
		public float? qty { get; set; }
		public int? unitId { get; set; }

		public ProductStock() { }


		public ProductStock(int id, int productId, float? qty = default, int? unitId = default)		{
			this.id = id;
			this.productId = productId;
			this.qty = qty;
			this.unitId = unitId;
		}
	}
}