using System;
using System.Collections.Generic;
using System.Text;
using TrakGud.DAL.Models.Domain;

namespace TrakGud.DAL.Models.ShipmentManagement
{
	public class ShippedItemBatch: ItemBatch
	{
		public int? vehicleId { get; set; }

		public ShippedItemBatch(int id_, string itemBatchType_, int productId_, DateTime addTS_, int adderId_, int? vehicleId_ = default, string sourceType_ = default, int? sourceId_ = default, int? modderId_ = default, bool? isRemoved_ = default, DateTime modTS_ = default): base(id_, itemBatchType_, productId_, addTS_, adderId_, sourceType_, sourceId_, modderId_, isRemoved_, modTS_)
		{
			this.vehicleId = vehicleId_;
		}
	}
}