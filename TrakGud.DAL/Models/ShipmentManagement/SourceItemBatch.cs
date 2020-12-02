using System;
using System.Collections.Generic;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class SourceItemBatch: ItemBatch
	{
		public float? shippedQty { get; set; }
		public int? shippedUnitId { get; set; }

		public SourceItemBatch(int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, float? shippedQty_ = default, int? shippedUnitId_ = default, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default): base(id_, itemBatchType_, productId_, addTS_, adderId_, sourceType_, sourceId_, modderId_, isRemoved_, modTS_)
		{
			this.shippedQty = shippedQty_;
			this.shippedUnitId = shippedUnitId_;
		}
	}
}