using System;
using System.Collections.Generic;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class DestinationItemBatch: ItemBatch
	{
		public float? receivedQty { get; set; }
		public int? receivedUnitId { get; set; }

		public DestinationItemBatch(int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default, float? receivedQty_ = default, int? receivedUnitId_ = default): base(id_, itemBatchType_, productId_, addTS_, adderId_, sourceType_, sourceId_, modderId_, isRemoved_, modTS_)
		{
			this.receivedQty = receivedQty_;
			this.receivedUnitId = receivedUnitId_;
		}
	}
}