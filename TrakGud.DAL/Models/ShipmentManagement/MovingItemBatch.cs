using System;
using System.Collections.Generic;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class MovingItemBatch: ItemBatch
	{
		public int shipmentId { get; set; }

		public MovingItemBatch(int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default, int shipmentId_): base(id_, itemBatchType_, productId_, addTS_, adderId_, sourceType_, sourceId_, modderId_, isRemoved_, modTS_)
		{
			this.shipmentId = shipmentId_;
		}
	}
}