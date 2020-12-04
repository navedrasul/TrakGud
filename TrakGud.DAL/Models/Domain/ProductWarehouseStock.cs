using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TrakGud.DAL.Models.Domain
{
[Table("d__ProductWarehouseStock")]	public class ProductWarehouseStock
	{
		public int id { get; set; }
		public int warehouseId { get; set; }
		public int productId { get; set; }
		public float? qty { get; set; }
		public int? unitId { get; set; }

		public ProductWarehouseStock() { }


		public ProductWarehouseStock(int id, int warehouseId, int productId, float? qty = default, int? unitId = default)		{
			this.id = id;
			this.warehouseId = warehouseId;
			this.productId = productId;
			this.qty = qty;
			this.unitId = unitId;
		}
	}
}