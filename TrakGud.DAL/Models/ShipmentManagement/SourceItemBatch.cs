using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
[Table("sm__SourceItemBatch")]	public class SourceItemBatch: ItemBatch
	{
		public float? shippedQty { get; set; }
		public int? shippedUnitId { get; set; }

		public SourceItemBatch() { }


		public SourceItemBatch(int id, string itemBatchType, int productId, DateTime addTS, int adderId, float? shippedQty = default, int? shippedUnitId = default, string sourceType = default, int? sourceId = default, int? modderId = default, bool? isRemoved = default, DateTime? modTS = default): base(id, itemBatchType, productId, addTS, adderId, sourceType, sourceId, modderId, isRemoved, modTS)
		{
			this.shippedQty = shippedQty;
			this.shippedUnitId = shippedUnitId;
		}
	}
}